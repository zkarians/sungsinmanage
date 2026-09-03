<?

ini_set('display_errors', '0');

function cleanup($c) {
	$c=trim($c);
	$c=htmlspecialchars($c, ENT_QUOTES);
	$c=eregi_replace("%", "$#37;", $c);
	$c=eregi_replace("<","&lt;", $c);
	$c=eregi_replace(">","&gt;", $c);
	$c=eregi_replace("&amp;","&", $c);
	$c=eregi_replace("update","", $c);
	$c=eregi_replace("UPDATE","", $c);
	$c=eregi_replace("delete","", $c);
	$c=eregi_replace("DELETE","", $c);
	$c=eregi_replace("select","", $c);
	$c=eregi_replace("SELECT","", $c);
	$c=nl2br($c);
	$c=StripSlashes($c);
	return($c);
}

$acc_code = cleanup($_POST['acc_code']);

$type = cleanup($_GET['t']);

$id=cleanup($_POST['id']);
$pw=cleanup($_POST['pw']);

$tc = $_POST['tc'];

$oc=$_GET['oc'];
$op=$_GET['op'];
$oe=addslashes($_GET['oe']);
if($_POST['oa']==null) $oa=$_GET['oa']; else $oa=$_POST['oa']; // 배송지 주소 수정시 사용 (API 1.95 추가)
$oa=addslashes($oa);

$cc=$_GET['cc'];
$cp=$_GET['cp'];
$cn=$_GET['cn'];
$ca=addslashes($_GET['ca']);
$call=cleanup($_GET['call']);

if($_POST['pc']==null) $pc=$_GET['pc']; else $pc=$_POST['pc'];
$pc=addslashes($pc);
$pt=$_GET['pt'];
$pg=$_GET['pg'];
$pn=$_GET['pn'];
$pp=$_GET['pp'];
$ps=$_GET['ps'];

if ($pc==null) $pc="";
if ($pt==null) $pt="";
if ($pg==null) $pg="";
if ($pn==null) $pn="";
if ($pp==null) $pp="";
if ($ps==null) $ps="";

$ac=cleanup($_GET['ac']);
$acgb=cleanup($_GET['acgb']);
if($_POST['gb']==null) $gb=cleanup($_GET['gb']); else $gb=cleanup($_POST['gb']);
if($_POST['acgb']==null) $acgb=cleanup($_GET['acgb']); else $acgb=cleanup($_POST['acgb']);

$ai=$_GET['ai'];
$ap=$_GET['ap'];
$an=$_GET['an'];
if($_POST['ac']==null) $ac=cleanup($_GET['ac']); else $ac=cleanup($_POST['ac']);

$dateFrom=cleanup($_GET['dateFrom']);
$dateTo=cleanup($_GET['dateTo']);

$index=cleanup($_GET['i']);  // 인덱스
$status=cleanup($_GET['s']);  // 상태
$od=addslashes($_GET['od']);  // 송장번호

include_once("./dbconfig.php");
 
$bd = mysql_connect($mysql_hostname, $mysql_user, $mysql_password) or die(mysql_error()); 
mysql_select_db($mysql_database, $bd) or die(mysql_error()); 

$condate = date("Y-m-d H:i:s"); //현재날짜시간

$sql = mysql_query("
					SELECT acgb_code, account_id, account_code
					FROM ss_account
					WHERE `account_id` LIKE '$id' AND `account_pw` LIKE '$pw' ");

$adminCheck = mysql_fetch_array($sql);
$account_id = $adminCheck[account_id];
$account_code = $adminCheck[account_code];
$check_acgb = $adminCheck[acgb_code];

if ($check_acgb != 1 && $check_acgb != 3 && $check_acgb != 5 && $tc != 99) {
	echo "fail";
	return;
}
				
switch($type) {
	case "getOrder" :


				$condition= "
					WHERE order_date >= '$dateFrom' 
					AND order_date <= '$dateTo 23:59' ";


					if($tc==99) {

						$condate2 = date("Y-m-d"); // 현재
						$rs = date("Y-m-d",strtotime("-7 day", time())); //7일전

						$condition = "
							WHERE order_date >= '$rs' 
							AND order_date <= '$condate2 23:59' AND e.account_code = '$ac' ";
					}

				$result = mysql_query("

					select `index`, e.account_code, e.account_name, order_date, cus_code, cus_name, cus_call, cus_phone, order_address, product_code, order_status, order_delivery, order_etc 
					from (
					
							select `index`, a.account_code, order_date, a.cus_code, b.cus_name, cus_call, cus_phone, order_address, product_code, order_status, order_delivery, order_etc 
							from ss_order a
							left join ss_customer b
							on TRIM(a.cus_code) LIKE TRIM(b.cus_code)) as c

					left join ss_account e
					on c.account_code LIKE e.account_code
					
					$condition

					 ORDER BY `index` DESC 								 ");

				//echo mysql_error();

				while($row = mysql_fetch_array($result)){

					$spl = trimExplode("<product>", $row[product_code], 1);

					$arr = array();

					for($i=0; $i<count($spl); $i++) {

						$br = trimExplode("<br>", $spl[$i], 1);

						$search = mysql_query(" select * from ss_product WHERE product_code like '$br[0]' ");

						$sRow = mysql_fetch_array($search);

						array_push($arr, "<product>".$sRow[product_name]."<br>".$br[1]."<br>".$br[2]."<br>".$br[3]."<br>".$sRow[gb_code]."<br>".$br[0]);

					}

					$product_names = implode($arr);

					echo "<split>".$row[index]."<next>".
						$row[order_date]."<next>".$row[account_name]."<next>".
						$row[cus_code]."<next>".$row[cus_name]."<next>".$row[cus_call]."<next>".
						$row[cus_phone]."<next>".$row[order_address]."<next>".
						$product_names."<next>".$row[order_status]."<next>".$row[order_delivery]."<next>".$row[order_etc]."<end>";
				}

		break;

	case "getOrderV2" :

		mysql_query("SET SQL_BIG_SELECTS=1");

		$condition= "
			WHERE order_date >= '$dateFrom' 
			AND order_date <= '$dateTo 23:59' ";


			if($tc==99) {

				$condate2 = date("Y-m-d"); // 현재
				$rs = date("Y-m-d",strtotime("-7 day", time())); //7일전

				$condition = "
					WHERE order_date >= '$rs' 
					AND order_date <= '$condate2 23:59' AND e.account_code = '$ac' ";
			}

		$result = mysql_query("

			select `index`, e.account_code, e.account_name, order_date, cus_code, cus_name, cus_call, cus_phone, order_address, product_code, order_status, order_delivery, order_etc 
			from (
			
					select `index`, a.account_code, order_date, a.cus_code, b.cus_name, cus_call, cus_phone, order_address, product_code, order_status, order_delivery, order_etc 
					from ss_order a
					left join ss_customer b
					on TRIM(a.cus_code) LIKE TRIM(b.cus_code)) as c

			left join ss_account e
			on c.account_code LIKE e.account_code
			
			$condition

			 ORDER BY `index` DESC 								 ");

		//echo mysql_error();

		while($row = mysql_fetch_array($result)){
/*
			$spl = trimExplode("<product>", $row[product_code], 1);

			$arr = array();

			for($i=0; $i<count($spl); $i++) {

				$br = trimExplode("<br>", $spl[$i], 1);

				$search = mysql_query(" select * from ss_product WHERE product_code like '$br[0]' ");

				$sRow = mysql_fetch_array($search);

				array_push($arr, "<product>".$sRow[product_name]."<br>".$br[1]."<br>".$br[2]."<br>".$br[3]."<br>".$sRow[gb_code]."<br>".$br[0]);

			}

			$product_names = implode($arr);*/

			echo "<split>".$row[index]."<next>".
				$row[order_date]."<next>".$row[account_name]."<next>".
				$row[cus_code]."<next>".$row[cus_name]."<next>".$row[cus_call]."<next>".
				$row[cus_phone]."<next>".$row[order_address]."<next>".
				$row[product_code]."<next>".$row[order_status]."<next>".$row[order_delivery]."<next>".$row[order_etc]."<end>";
		}

		break;

	case "getOrderV3" :

		mysql_query("SET SQL_BIG_SELECTS=1");

		$condition= "
			WHERE order_date >= '$dateFrom' 
			AND order_date <= '$dateTo 23:59' ";

		if($tc==99) {

			$condate2 = date("Y-m-d"); // 현재
			$rs = date("Y-m-d",strtotime("-7 day", time())); //7일전

			$condition = "
				WHERE order_date >= '$rs' 
				AND order_date <= '$condate2 23:59' AND a.account_code = '$ac' ";
		}

		$result = mysql_query("

			
					select `index`, a.account_code, order_date, a.cus_code, b.cus_name, b.cus_call, b.cus_phone, order_address, product_code, order_status, order_delivery, order_etc 
					from ss_order a
					left join ss_customer b
					on a.cus_code LIKE b.cus_code

			$condition

			ORDER BY `index` DESC ");

		$rows = array();
		while($r = mysql_fetch_assoc($result)) {
			$rows[] = $r;
		}

		$ss_order = json_encode($rows);

		$result = mysql_query("

			select `account_code`, `account_name` from `ss_account` ORDER BY `account_code` ASC ");
	
	
		$rows = array();
		while($r = mysql_fetch_assoc($result)) {
			$rows[] = $r;
		}

		$ss_account = json_encode($rows);

		echo json_encode(array(

			"ss_order" =>$ss_order,
			"ss_account" => $ss_account

		));

		//echo $ss_order_json;

		break;

	case "getCustomer" :

		$result = mysql_query("SELECT cus_code, account_id, cus_name, cus_call, cus_phone, cus_address FROM (
										
											SELECT cus_code, acc.account_id, cus_name, cus_call, cus_phone, cus_address FROM ss_customer cus 
											LEFT JOIN ss_account acc 
											ON cus.account_code LIKE acc.account_code
		
										) as res
										WHERE cus_code like '%$cc%' AND cus_name Like '%$cn%' AND
										cus_phone Like '%$cp%' AND
										cus_call Like '%$call%' ORDER BY `cus_code` ASC");

		while($row = mysql_fetch_array($result)){
			echo "<split>".$row[cus_code]."<next>".$row[account_id]."<next>".$row[cus_name]."<next>".$row[cus_call]."<next>".
				$row[cus_phone]."<next>".str_replace("<other>"," ",$row[cus_address]);
		}


		break;

	case "getProduct" :

				$result = mysql_query("

										select * from ss_product 

										WHERE product_code like '%$pc%' AND team_code Like '%$pt%' AND gb_code Like '%$pg%' 
										AND product_name Like '%$pn%' ORDER BY `product_code` ASC");

										

				while($row = mysql_fetch_array($result)){
					echo "<split>".$row[product_code]."<next>".$row[team_code]."<next>".$row[gb_code]."<next>".$row[product_name]
						."<next>".$row[product_price]."<next>".$row[product_stock];
				}


		break;

	case "getAccount" :

		if ($check_acgb == 5) {

				$result = mysql_query("

										select * from ss_account 

										WHERE account_code like '%$ac%' AND acgb_code Like '%$acgb%' AND team_code Like '%$gb%' 
										AND account_id Like '%$ai%' AND account_name Like '%$an%'  ORDER BY `account_code` ASC");

		} else {

			echo "fail";
			return;

				$result = mysql_query("

										select * from ss_account 

										WHERE account_code like '%$ac%' AND acgb_code Like '%$acgb%' AND team_code Like '%$gb%' 
										AND account_id Like '%$ai%' AND account_name Like '%$an%' AND acgb_code != 5 ORDER BY `account_code` ASC");

		}

				while($row = mysql_fetch_array($result)){
					echo "<split>".$row[account_code]."<next>".$row[acgb_code]."<next>".$row[team_code]."<next>".$row[account_id]
						."<next>".$row[account_pw]."<next>".$row[account_name]."<next>".$row[allow_ip];
				}


		break;

	case "cusSearchA" : //관리자가 고객 검색

				$result = mysql_query("SELECT * FROM ss_customer 
												WHERE (cus_code like '%$cc%' OR cus_name Like '%$cc%' OR
												cus_phone Like '%$cc%' OR
												cus_call Like '%$cc%') AND account_code=$acc_code ORDER BY `cus_name` ASC");

				while($row = mysql_fetch_array($result)){
					echo "<split>".$row[cus_code]."<next>".$row[cus_name]."<next>".$row[cus_call]."<next>".$row[cus_phone]."<next>".$row[cus_address];
				}


		break;

	case "searchCustomer" :

				$result = mysql_query("SELECT * FROM ss_customer 
												WHERE cus_name Like '$cc' AND account_code=$acc_code ORDER BY `cus_name` ASC");

				while($row = mysql_fetch_array($result)){
					echo "<split>".$row[cus_code]."<next>".$row[cus_name]."<next>".$row[cus_call]."<next>".$row[cus_phone]."<next>".$row[cus_address];
				}


		break;

/////////////////////////////////////////////////////////////////
// SET
/////////////////////////////////////////////////////////////////

	case "setOrder" :


			$result = mysql_query("SELECT cus_code, count(*) as count FROM ss_customer 
												WHERE (cus_code like '$cc' OR (cus_name Like '%$cn%' AND
												cus_phone Like '%$cp%')) AND account_code = $acc_code");

			$qresult = mysql_fetch_array($result);

			if ($qresult[count]<=0){ // 고객정보 추가 또는 수정

				$result = mysql_query("INSERT into `ss_customer`  (`cus_name`, `account_code`, `cus_call`, `cus_phone`, `cus_address`) values('$cn', $acc_code, '$call', '$cp','$ca')");

				//$errorMsg = mysql_error();

				if ($result != 1) {
					if($acc_code==null) {
					echo "서버 알림: 주문 할 수 없습니다.\n문제 1. 앱을 업데이트 하십시오.\n문제 2. 정상적인 경로가 아닙니다.";
					}else echo "서버 알림: 쿼리에 문제가 있습니다.";
					return;
				}

				$cc=mysql_insert_id();

			}else{
				$cc=$qresult[cus_code];
				
				$result = mysql_query("UPDATE `ss_customer` SET `cus_name`='$cn', `cus_call`='$call', `cus_phone`='$cp', `cus_address`='$ca' WHERE `cus_code`=$cc AND account_code = $acc_code");

				//$errorMsg = mysql_error();

				if ($result != 1) {
					if($acc_code==null) {
					echo "서버 알림: 주문 할 수 없습니다.\n문제 1. 앱을 업데이트 하십시오.\n문제 2. 정상적인 경로가 아닙니다.";
					}else echo "서버 알림: 쿼리에 문제가 있습니다.";
					return;
				}

			}


			//$errorMsg="";

			$spl = trimExplode("<product>", $pc,1);

			for($i=0; $i<count($spl); $i++) {

				$br = trimExplode("<br>", $spl[$i], 1);

				// 재고 확인 및 재고 감소
				$result = mysql_query("SELECT product_stock, product_name FROM `ss_product` WHERE `product_code`='$br[0]'");
				$res = mysql_fetch_array($result);
				if ($res[product_stock]<$br[2]) { //재고가 있는지 체크
					//$i--;
					echo "[".$res[product_name]."] 제품의 재고가 없어 주문할 수 없습니다.\n";
					return;
				}


			}


			for($i=0; $i<count($spl); $i++) {
				$br = trimExplode("<br>", $spl[$i], 1);

				// 재고, 수량만큼 감소
				$result = mysql_query("UPDATE ss_product SET product_stock=product_stock - $br[2] WHERE `product_code`='$br[0]' ");

				if ($result != 1) {
					echo "서버 알림: 쿼리에 문제가 있습니다.";
					break;
				}

			}

/*
			if ($i <> count($spl)) {
			
				$transaction = $i;

				for($i=0; $i<$transaction; $i++) {

					$br = trimExplode("<br>", $spl[$i], 1);

					// 재고, 수량만큼 감소
					$result = mysql_query("UPDATE ss_product SET product_stock=product_stock + $br[2] WHERE `product_code`='$br[0]' ");

					if ($result != 1) {
						$errorMsg += mysql_error();
						break;
					}

				}

			}

			echo $errorMsg;

			return;

			*/

			// 주문 추가
			$result = mysql_query("

				INSERT into `ss_order`  (`account_code` ,`cus_code`, `product_code`, `order_address`, `order_date`, `order_status`, `order_delivery`, `order_etc`) 
				
				values('$ac', '$cc', '$pc' , '$od','$condate', 1, '', '$oe')
				
			");

			$log_string = '<type>setOrder\n<account_code>'.$ac.'\n<cus_code>'.$cc.'\n<product_codes>'.$pc.'\n<order_delivery>'.$od.'\n<order_date>'.$condate.'\n<status>1\n<order_etc>'.$oe;

			$log = mysql_query("

				INSERT into `ss_log` (`date`, `log`) values('$condate', '$log_string')
				
			");

			//$errorMsg = mysql_error();

			if ($result == 1) {
				echo "ok";
			}
			else {
				echo "서버 알림: 쿼리에 문제가 있습니다.";
			}

			return;

		break;

	case "orderMod" :
/*
		if ($pc==null) {
			$result = mysql_query("UPDATE `ss_order` SET  `order_address`='$oa', `order_delivery`='$od', `order_etc`='$oe' WHERE `index`=$index");
		}else if ($oa==null) {
			$result = mysql_query("UPDATE `ss_order` SET `product_code`='$pc', `order_delivery`='$od', `order_etc`='$oe' WHERE `index`=$index");
		}else if ($oa==null && $pc==null) {
			$result = mysql_query("UPDATE `ss_order` SET `order_delivery`='$od', `order_etc`='$oe' WHERE `index`=$index");
		}else {
			$result = mysql_query("UPDATE `ss_order` SET `product_code`='$pc', `order_address`='$oa', `order_delivery`='$od', `order_etc`='$oe' WHERE `index`=$index");
		}*/

		$result = mysql_query("UPDATE `ss_order` SET `product_code`='$pc', `order_address`='$oa', `order_delivery`='$od', `order_etc`='$oe' WHERE `index`=$index");


			$log_string = '<type>orderMod\n<index>'.$index.'\n<product_code>'.$pc.'\n<order_address>'.$oa.'\n<order_delivery>'.$od.'\n<order_etc>'.$oe;

			$log = mysql_query("

				INSERT into `ss_log` (`date`, `log`) values('$condate', '$log_string')
				
			");

		if ($result == 1) echo "ok";
		else echo mysql_error();

		break;

	case "setOrderStatus" :

		if($status==0) { //관리자

			$result = mysql_query("UPDATE `ss_order` SET `order_delivery`='$od' WHERE `index`=$index");
			
			$log_string = '<type>setOrderStatus\n<index>'.$index.'\n<order_delivery>'.$od.'\n<order_status>'.$status.'\n<order_etc>'.$oe;

			$log = mysql_query("

				INSERT into `ss_log` (`date`, `log`) values('$condate', '$log_string')
				
			");

		}

		else { //최고관리자

			if ($pc == null) {
			
				$log_string = '<type>setOrderStatus_ERROR\n<index>'.$index.'\n<product_code>'.$pc.'\n<order_address>'.$oa.'\n<order_delivery>'.$od.'\n<order_status>'.$status.'\n<order_etc>'.$oe;

				$log = mysql_query("

					INSERT into `ss_log` (`date`, `log`) values('$condate', '$log_string')
					
				");

				echo "ok";
				return;
			}

			$result = mysql_query("SELECT order_status, product_code FROM `ss_order` WHERE `index`=$index");

			$row = mysql_fetch_array($result);

			$OriginalStatus =$row[order_status];
			$getProductCodes = $row[product_code];

			$spl = trimExplode("<product>", $getProductCodes,1);

			for($i=0; $i<count($spl); $i++) {

				$br = trimExplode("<br>", $spl[$i], 1);

				if ($OriginalStatus == 1 || $OriginalStatus == 2 || $OriginalStatus == 4) { // 발송전 취소로 인한 재고 추가
					if ($status == 3) {
						$result = mysql_query("UPDATE ss_product SET product_stock=product_stock + $br[2] WHERE `product_code`='$br[0]'");
						
						if ($result != 1) {
							echo "서버 알림: 쿼리에 문제가 있습니다.";
							return;
						}
					}
				}

				if ($OriginalStatus == 3) {
					if ($status == 2 || $status == 4) { // 재고가 있는지 체크
						$result = mysql_query("SELECT product_stock FROM `ss_product` WHERE `product_code`='$br[0]'");
						$tmp = mysql_fetch_array($result);
						$tmp = $tmp[product_stock];
						if ($tmp<$br[2]) { //재고가 있는지 체크
							echo "해당 상품의 재고가 없습니다.";
							return;
						}
					}
				}
			}

			for($i=0; $i<count($spl); $i++) {

				$br = trimExplode("<br>", $spl[$i], 1);

				if ($OriginalStatus == 3) {
					if ($status == 2 || $status == 4) { // 재고가 있는지 체크
						$result = mysql_query("UPDATE ss_product SET product_stock=product_stock - $br[2] WHERE `product_code`='$br[0]'");

						if ($result != 1) {
							echo "서버 알림: 쿼리에 문제가 있습니다.";
							return;
						}
					}
				}

			}
			$result = mysql_query("UPDATE `ss_order` SET `product_code`='$pc', `order_address`='$oa', `order_status`='$status', `order_delivery`='$od', `order_etc`='$oe' WHERE `index`=$index");

			$log_string = '<type>setOrderStatus\n<index>'.$index.'\n<product_code>'.$pc.'\n<order_address>'.$oa.'\n<order_delivery>'.$od.'\n<order_status>'.$status.'\n<order_etc>'.$oe;

			$log = mysql_query("

				INSERT into `ss_log` (`date`, `log`) values('$condate', '$log_string')
				
			");

		}

		if ($result == 1) echo "ok";
		else echo "서버 알림: 쿼리에 문제가 있습니다.";
		
		break;


	case "modCustomer" :

		$getCode = mysql_fetch_array(mysql_query("SELECT `account_code` FROM `ss_account` WHERE `account_id` = '$ac' "));

		if($getCode==null) {
			echo "존재하지 않는 등록자ID 입니다.";
			return;
		}

		$result = mysql_query("SELECT count(*) as count FROM `ss_customer` WHERE `cus_code`=$cc");

		if (mysql_num_rows($result)<=0){

			$result = mysql_query("INSERT into `ss_customer`  (`cus_name`, `account_code`, `cus_call`, `cus_phone`, `cus_address`) values('$cn', '$getCode[account_code]', '$call', '$cp','$ca')");

			//$errorMsg = mysql_error();

			if ($result == 1) echo "ok";
			else echo "서버 알림: 쿼리에 문제가 있습니다.";

			return;

		}


		$result = mysql_query("UPDATE `ss_customer` SET `cus_name`='$cn', `account_code` = '$getCode[account_code]', `cus_call`='$call', `cus_phone`='$cp', `cus_address`='$ca' WHERE `cus_code`=$cc");

		//$errorMsg = mysql_error();

		if ($result == 1) echo "ok";
		else echo "서버 알림: 쿼리에 문제가 있습니다.";
		
		break;


	case "delCustomer" :

		$result = mysql_query("DELETE FROM `ss_customer` WHERE `cus_code` = $cc");

		//$errorMsg = mysql_error();

		if ($result == 1) echo "ok";
		else echo "서버 알림: 쿼리에 문제가 있습니다.";
		
		break;



	case "modProduct" :

		$result = mysql_query("SELECT count(*) as count FROM `ss_product` WHERE `product_code` LIKE '$pc'");
		$tmp = mysql_fetch_array($result);
		$tmp = $tmp[count];
		if ($tmp<=0){

			$result = mysql_query("INSERT into `ss_product`  (`product_code` ,`team_code`, `gb_code`, `product_name`, `product_price`, `product_stock`) values('$pc', $pt, $pg, '$pn', $pp, $ps)");

			//$errorMsg = mysql_error();

			if ($result == 1) echo "ok";
			else echo "서버 알림: 쿼리에 문제가 있습니다.";

			return;

		}


		$result = mysql_query("UPDATE `ss_product` SET `team_code`=$pt, `gb_code`=$pg, `product_name`='$pn', `product_price`=$pp , `product_stock`=$ps WHERE `product_code`='$pc'");

		//$errorMsg = mysql_error();

		if ($result == 1) echo "ok";
		else echo "서버 알림: 쿼리에 문제가 있습니다.";
		
		break;


	case "delProduct" :

		$result = mysql_query("DELETE FROM `ss_product` WHERE`product_code`='$pc'");

		//$errorMsg = mysql_error();

		if ($result == 1) echo "ok";
		else echo "서버 알림: 쿼리에 문제가 있습니다.";
		
		break;


	case "modAccount" :

		$result = mysql_query(" SELECT count(*) as count FROM `ss_account` WHERE `account_code` = $ac ");
		$tmp = mysql_fetch_array($result);

		$allow_ip=$_GET['allow_ip'];

		$ip_count = mysql_query(" SELECT count(account_code) as count FROM `ss_account` WHERE allow_ip is null and (acgb_code = 3 or acgb_code = 5)");
		$ip_count = mysql_fetch_array($ip_count);
		$ip_count = $ip_count[count];
		if($ip_count <= 1 && $allow_ip != null && ($acgb ==3 || $acgb ==5)) {
			echo "서버 알림: 최고관리자/루트관리자 최소 한명은 IP가 할당되지 않아야 합니다.";
			return;
		}

		if($allow_ip == null){
			$allow_ip = "null";
		}else{
			$allow_ip = "'$allow_ip'";
		}

		// $check_acgb

		if ($ai == $account_id && $acgb != $check_acgb) {		
			echo "서버 알림: 현재 로그인 중인 계정의 구분은 변경할 수 없습니다.";
			return;
		}

		$tmp = $tmp[count];
		if ($tmp<=0){
			$result = mysql_query(" INSERT into `ss_account`  (`acgb_code`, `team_code`, `account_id`, `account_pw`, `account_name`, `allow_ip`) values($acgb, $gb, '$ai', '$ap', '$an', $allow_ip) ");

			if ($result == 1) echo "ok";
			else echo "서버 알림: 필수 항목을 기입하십시오.";

			return;
		}


		$result = mysql_query(" UPDATE `ss_account` SET `acgb_code`=$acgb, `team_code`=$gb, `account_id`='$ai', `account_pw`='$ap', `account_name`='$an', `allow_ip` = $allow_ip WHERE `account_code`=$ac ");

		if ($result == 1) echo "ok";
		else echo "서버 알림: 필수 항목을 기입하십시오.";
		
		break;


	case "delAccount" :

		if ($ac == $account_code) {
			echo "서버 알림: 현재 로그인 중인 계정은 삭제할 수 없습니다.";
			return;
		}

		$result = mysql_query("DELETE FROM `ss_account` WHERE `account_code` = $ac");

		if ($result == 1) echo "ok";
		else echo "서버 알림: 쿼리에 문제가 있습니다.";
		
		break;

}

function trimExplode($delim, $string, $onlyNonEmptyValues=0){
	$temp = explode($delim,$string);
	$newtemp=array();
	while(list($key,$val)=each($temp))      {
		if (!$onlyNonEmptyValues || strcmp("",trim($val)))      {
			$newtemp[]=trim($val);
		}
	}
	reset($newtemp);
	return $newtemp;
}


?>