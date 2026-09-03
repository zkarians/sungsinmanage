<?

$pc_version = 195;
$android_version = 12;

// POST //////////////////
//$pcv=cleanup($_GET['pcv']);
//$adv=cleanup($_GET['adv']);

//$id=cleanup($_POST['id']);
//$pw=cleanup($_POST['pw']);
//$version=cleanup($_POST['version']);

$thisIP = $_SERVER['REMOTE_ADDR'];

include_once("./dbconfig.php");
include_once("./cti/system_functions.php");

$bd = mysql_connect($mysql_hostname, $mysql_user, $mysql_password) or die("db connect error");
mysql_select_db($mysql_database, $bd) or die("db connect error");

$condate = date("Y-m-d H:i:s");

$var = json_decode($_POST['args']);
if(!isset($var)) {
	http_response_code(403.8);
	die();
}

$args = array();
foreach($var as $key => $value)
	$args = array_merge($args, array($key => cleanup($value)));

$id = $args[id];
$pw = $args[pw];
$version = $args[version];

$result=mysql_query("

select account_code, acgb_code, acgb, result.team_code, team, id, pw, name, allow_ip, if(cti.idx is null,null,cti.idx) as cti_idx from(

SELECT a.account_code, a.acgb_code, acgb, team_code, account_id as id, account_pw as pw, account_name as name, allow_ip
FROM ss_account a 

left join ss_accountgb b
on a.acgb_code = b.acgb_code) as result

left join ss_team c
on c.team_code = result.team_code

left join cti_agents cti
on account_code = cti.account_idx and expire = 0

WHERE `id` LIKE '$id' AND `pw` LIKE '$pw' ");

$row = mysql_fetch_array($result);


if ($row==null) {

	echo json_encode(array(
		"response" => "fail",
		"cause" => "no_match"
	));

}else {

	if(($row[allow_ip] != null && $thisIP == $row[allow_ip]) || $row[allow_ip] == null){

		echo json_encode(array(
			"response" => "ok",
			"output" => array(
					"acgb_code" => $row[acgb_code], // 구분코드
					"acgb" => $row[acgb], // 구분
					"team_code" => $row[team_code], // 소속 번호
					"team" => $row[team], // 소속 문자
					"name" => $row[name], // 이름
					"date" => $condate,
					"account_code" => $row[account_code], // 코드
					"cti_idx" => $row[cti_idx] //cti 접속 권한
				)
		));

	}else{

		echo json_encode(array(
			"response" => "fail",
			"cause" => "permission_error"
		));

	}


}


?>