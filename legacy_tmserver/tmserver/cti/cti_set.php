<?
include_once("./_core.php");

$id = $args[id];
$pw = $args[pw];

$isAdmin = isAdminAccount($id,$pw);

switch($type){

	case "addAgent":

		if(!$isAdmin) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$account_idx = $args[account_idx];

		$already_find = mysql_query("SELECT count(account_idx) as count FROM cti_agents WHERE account_idx = $account_idx");
		$already_find = mysql_fetch_array($already_find);
		$already_find = $already_find[count];

		if($already_find > 0){
			echo json_encode(array(
				"response" => "fail",
				"cause" => "already_exist"
			));
			return;
		}

		$result = mysql_query("INSERT INTO `cti_agents` (`account_idx`, `regist_date`) 
		VALUES ('$account_idx', '$nowDate')");

		if($result == 1) {
			echo json_encode(array(
				"response" => "ok",
				"idx" => mysql_insert_id(),
				"date" => $nowDate
			));

		}else{
			echo json_encode(array(
				"response" => "fail",
				"cause" => "query_error"
			));

		}

		break;

	case "agentReset":

		if(!$isAdmin) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$idx = $args[idx];

		$result = mysql_query("UPDATE cti_agents SET expire_date = NULL, expire = 0
							   WHERE idx = $idx");

		if($result == 1) {
			echo json_encode(array(
				"response" => "ok",
				"output" => $nowDate
			));

		}else{
			echo json_encode(array(
				"response" => "fail",
				"cause" => "no_exist"
			));

		}

		break;

	case "agentDelete":

		if(!$isAdmin) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$idx = $args[idx];

		$result = mysql_query("UPDATE cti_agents SET logging = null, expire_date = '$nowDate', expire = 1
							   WHERE idx = $idx");

		if($result == 1) {

			echo json_encode(array(
				"response" => "ok",
				"output" => $nowDate
			));

		}else{
			echo json_encode(array(
				"response" => "fail",
				"cause" => "no_exist"
			));

		}

		break;

	case "addDB":

		if(!$isAdmin) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$name = $args[name];
		$upload_mode = $args[upload_mode];
		$data = base64_decode(str_replace(" ","+",$args[data]));		

		if(!isJson($data)){
			echo json_encode(array(
				"response" => "fail",
				"cause" => "execute_error"
			));
			//echo $args[data];
			return;
		}

		$data = json_decode($data);

		//echo count($data);

		mysql_query("START TRANSACTION");

		if($upload_mode=="blacklist"){
			$db_insert_result = mysql_query("INSERT INTO cti_db (`name`, `blacklist`) VALUES ('$name', 1)");
		}else{
			$db_insert_result = mysql_query("INSERT INTO cti_db (`name`) VALUES ('$name')");
		}

		$idx = mysql_insert_id();

		foreach($data as $json){

			//echo to_han(json_encode($json))."<br><br>";

			//$address = to_han($json->address);

			if($json->product_name == null)
				$product_name = "null";
			else{
				$product_name = cleanup($json->product_name);
				$product_name = "'$product_name'";
			}

			if($json->seller == null)
				$seller = "null";
			else{
				$seller = cleanup($json->seller);
				$seller = "'$seller'";
			}

			if($json->price == null)
				$price = "null";
			else{
				$price = cleanup($json->price);
				$price = "$price";
			}

			if($json->phone_number == null)
				$phone = "null";
			else{
				$phone = cleanup($json->phone_number);
				$phone = "'$phone'";
			}

			if($json->home_number == null)
				$home = "null";
			else{
				$home = cleanup($json->home_number);
				$home = "'$home'";
			}

			if($json->address == null)
				$address = "null";
			else{
				$address = cleanup($json->address);
				$address = "'$address'";
			}

			if($json->comment == null)
				$comment = "null";
			else{
				$comment = cleanup($json->comment);
				$comment = "'$comment'";
			}

			if($json->comment2 == null)
				$comment2 = "null";
			else{
				$comment2 = cleanup($json->comment2);
				$comment2 = "'$comment2'";
			}

			$result = mysql_query("INSERT INTO cti_tm_list (
			`db_idx`, `name`, `product_name`, `seller`, `price`, `phone_number`, `home_number`, `address`, `comment`, `comment2`, `blacklist`) 
			VALUES (			
			$idx, '$json->name', $product_name, $seller, $price, $phone, $home, $address, $comment, $comment2, $json->blacklist) ");

			if($result != 1) {
				echo json_encode(array(
					"response" => "fail",
					"cause" => mysql_error()."  =>".json_encode($json)
				));
				mysql_query("ROLLBACK");
				return;
			}

			//echo mysql_error()."<br><br>";

		}
		
		if($db_insert_result == 1) {
			echo json_encode(array(
				"response" => "ok",
				"output" => $idx
			));
			mysql_query("COMMIT");

		}else{
			echo json_encode(array(
				"response" => "fail",
				"cause" => "add_fail"
			));
			mysql_query("ROLLBACK");

		}		

		break;

	case "putDB":

		if(!$isAdmin) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$idx = $args[idx];
		$data = base64_decode(str_replace(" ","+",$args[data]));		

		if(!isJson($data)){
			echo json_encode(array(
				"response" => "fail",
				"cause" => "execute_error"
			));
			return;
		}

		$data = json_decode($data);

		mysql_query("START TRANSACTION");

		foreach($data as $json){

			if($json->product_name == null)
				$product_name = "null";
			else{
				$product_name = cleanup($json->product_name);
				$product_name = "'$product_name'";
			}

			if($json->seller == null)
				$seller = "null";
			else{
				$seller = cleanup($json->seller);
				$seller = "'$seller'";
			}

			if($json->price == null)
				$price = "null";
			else{
				$price = cleanup($json->price);
				$price = "$price";
			}

			if($json->phone_number == null)
				$phone = "null";
			else{
				$phone = cleanup($json->phone_number);
				$phone = "'$phone'";
			}

			if($json->home_number == null)
				$home = "null";
			else{
				$home = cleanup($json->home_number);
				$home = "'$home'";
			}

			if($json->address == null)
				$address = "null";
			else{
				$address = cleanup($json->address);
				$address = "'$address'";
			}

			if($json->comment == null)
				$comment = "null";
			else{
				$comment = cleanup($json->comment);
				$comment = "'$comment'";
			}

			if($json->comment2 == null)
				$comment2 = "null";
			else{
				$comment2 = cleanup($json->comment2);
				$comment2 = "'$comment2'";
			}

			//echo $json->gender;

			$result = mysql_query("INSERT INTO cti_tm_list (
			`db_idx`, `name`, `product_name`, `seller`, `price`, `phone_number`, `home_number`, `address`, `comment`, `comment2`, `blacklist`) 
			VALUES (			
			$idx, '$json->name', $product_name, $seller, $price, $phone, $home, $address, $comment, $comment2, $json->blacklist) ");

			if($result != 1) {
				echo json_encode(array(
					"response" => "fail",
					"cause" => mysql_error()."  =>".json_encode($json)
				));
				mysql_query("ROLLBACK");
				return;
			}

			//echo mysql_error()."<br><br>";

		}

		mysql_query("COMMIT");

		echo json_encode(array(
			"response" => "ok"
		));

		break;

	case "setDB":

		if(!$isAdmin) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$idx = $args[idx];

		$result = mysql_query(" select status from cti_db where idx = $idx");
		$db_status = mysql_fetch_array($result);
		$db_status = $db_status[status];

		$name = $args[name];
		$status = $args[status];

		if($name != null) $name = "name = '$name'";
		else {
			$where = "status = $status";
			if($status == 1)
				$where .= ", last_date = '$nowDate' ";
		}
		
		$result = mysql_query("UPDATE cti_db SET $name $where WHERE idx = $idx");

		if($result == 1) {
			mysql_query("UPDATE cti_agents SET notify = 1 WHERE logging >= 1 " );	
				
			echo json_encode(array(
				"response" => "ok",
				"output" => $nowDate
			));
		}else{
			echo json_encode(array(
				"response" => "fail",
				"cause" => "no_exist"
			));
		}

		break;

	case "delDB" :

		if(!$isAdmin) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$idx = $args[idx];

		$result = mysql_query(" select status from cti_db where idx = $idx");
		$db_status = mysql_fetch_array($result);
		$db_status = $db_status[status];

		mysql_query("START TRANSACTION");

		$result = mysql_query("DELETE FROM `cti_db` WHERE idx = $idx");
		$result2 = mysql_query("DELETE FROM `cti_tm_list` WHERE `db_idx` = $idx");

		if($result == 1 && $result2 == 1) {
			echo json_encode(array(
				"response" => "ok"				
			));

		}else{
			mysql_query("ROLLBACK");

			echo json_encode(array(
				"response" => "fail",
				"cause" => "no_exist"
			));

			return;
		}		

		if($db_status != 0)
			mysql_query("UPDATE cti_agents SET notify = 1 WHERE logging >= 1 " );

		mysql_query("COMMIT");

		break;

	case "autoSplit" :

		if(!$isAdmin) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$db_idx = $args[idx];

		$result = mysql_query(" select status from cti_db where idx = $db_idx");
		$db_status = mysql_fetch_array($result);
		$db_status = $db_status[status];

		$LoginAgent = $args[LoginAgent];
		$forceSplit = $args[forceSplit];

		if($forceSplit == null){
			$forceSplit = "and agent_idx is null";
		}else{
			$forceSplit = "";
		}

		if($LoginAgent == 1){
			$LoginAgent = "and logging is not null";
		}

		$agent_count = mysql_query("SELECT count(idx) as count FROM cti_agents WHERE expire = 0 $LoginAgent");
		$agent_count = mysql_fetch_array($agent_count);
		$agent_count = $agent_count[count];

		//echo '$agent_count='.$agent_count."<br>";

		$db_count = mysql_query("SELECT count(idx) as count FROM cti_tm_list WHERE db_idx = $db_idx and blacklist=0 $forceSplit");
		$db_count = mysql_fetch_array($db_count);
		$db_count = $db_count[count];

		//echo '$db_count='.$db_count."<br>";

		$count = floor($db_count / $agent_count);

		//echo '$count='.$count."<br>";

		$array = array();
		$result = mysql_query("SELECT idx, account_idx, acgb_code FROM cti_agents 

		left join ss_account
		on account_idx = account_code 

		WHERE expire = 0 $LoginAgent");
		while($row = mysql_fetch_array($result)){
			//if($args[LoginAgent] == null) {
				if($row[acgb_code] == 2){
					array_push($array, $row[account_idx]);
				}else{
					if($args[forceSplit] != null)
						array_push($array, $row[account_idx]);
				}
			//}
		}

		$result = mysql_query("SELECT idx FROM cti_tm_list WHERE db_idx = $db_idx and blacklist=0 $forceSplit ORDER by idx ASC");

		$nowCount = 1;
		$nowAgent = 0;
		$rotate_finish = false;
		while($row = mysql_fetch_array($result)){
			if($nowAgent>=count($array)){
				$nowCount = 1;
				$nowAgent = 0;
				$rotate_finish = true;
			}

			mysql_query("UPDATE `cti_tm_list` SET agent_idx = $array[$nowAgent] 
			WHERE `idx` = $row[idx] and `db_idx` = $db_idx $forceSplit");

			if($nowCount >= $count){
				$nowCount = 1;
				$nowAgent ++;
			}else{
				$nowCount++;
			}
			if($rotate_finish){
				$nowCount = 1;
				$nowAgent++;
			}
			
		}

		if($db_status != 0){
			foreach($array as $agent_idx) {
				mysql_query("UPDATE cti_agents SET notify = 1 WHERE logging >= 1 and account_idx = $agent_idx " );
			}
		}

		echo json_encode(array(
			"response" => "ok"			
		));
		
		break;

	case "putAgent" : //수동 배분

		if(!$isAdmin) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$db_idx = $args[db_idx];

		$result = mysql_query(" select status from cti_db where idx = $db_idx");
		$db_status = mysql_fetch_array($result);
		$db_status = $db_status[status];

		$agent_idx = $args[agent_idx];
		$idxs = base64_decode(str_replace(" ","+",$args[idxs]));

		if(!isJson($idxs)){
			echo json_encode(array(
				"response" => "fail",
				"cause" => "execute_error"
			));
			return;
		}

		$idxs = json_decode($idxs);

		$nolist = array();

		mysql_query("START TRANSACTION");

		foreach($idxs as $idx){

			if($db_status != 0) { //기존 agent 푸시
				$result = mysql_query("SELECT agent_idx, result FROM cti_tm_list 
				WHERE idx = $idx and agent_idx is not null" );
				$tm = mysql_fetch_array($result);
				if($tm[result] == 5) {
					array_push($nolist, $idx);
					continue;
				}else{
					mysql_query("UPDATE cti_agents SET notify = 1 WHERE account_idx = $tm[agent_idx] " );
				}
			}

			$result = mysql_query("UPDATE `cti_tm_list` SET `agent_idx` = $agent_idx 
			WHERE idx = $idx " );

			if($result != 1) {
				echo json_encode(array(
					"response" => "fail",
					"cause" => mysql_error()."  =>".$idx
				));
				mysql_query("ROLLBACK");
				return;
			}

		}

		if($db_status != 0)
			mysql_query("UPDATE cti_agents SET notify = 1 WHERE logging >= 1 and account_idx = $agent_idx " );

		mysql_query("COMMIT");

		echo json_encode(array(
			"response" => "ok",
			"nolist" => $nolist
		));

		break;

	case "customPutAgent" : //사용자 정의 배분

		if(!$isAdmin) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$db_idx = $args[db_idx];
		$random = $args[random];

		$result = mysql_query(" select status from cti_db where idx = $db_idx");
		$db_status = mysql_fetch_array($result);
		$db_status = $db_status[status];

		$idxs = base64_decode(str_replace(" ","+",$args[idxs]));

		if(!isJson($idxs)){
			echo json_encode(array(
				"response" => "fail",
				"cause" => "execute_error"
			));
			return;
		}

		$idxs = json_decode($idxs);

		foreach($idxs as $idx){

			$agent_idx = $idx->idx;
			$agent_split_count = $idx->count;

			if($random == 0){

				mysql_query("UPDATE `cti_tm_list` SET `agent_idx` = $agent_idx 
					WHERE db_idx = $db_idx and agent_idx is null and blacklist=0 ORDER by idx limit $agent_split_count" );

			}else{ //랜덤

				$result = mysql_query("SELECT idx FROM cti_tm_list WHERE db_idx = $db_idx and agent_idx is null and blacklist=0" );
				$databases = array();
				while($row = mysql_fetch_array($result)){
					array_push($databases,$row[idx]);
				}

				$array = array();

				if(count($databases) <= $agent_split_count) {

					mysql_query("UPDATE `cti_tm_list` SET `agent_idx` = $agent_idx 
						WHERE db_idx = $db_idx and agent_idx is null and blacklist=0 ORDER by idx limit $agent_split_count" );

				}else{

					for($i=0; $i<=$agent_split_count-1; $i++){
						$number = rand(0, count($databases)-1);
						$exist = false;
						foreach ($array as $num){							
							if($num==$number) {
								$exist = true;
								break;
							}
						}

						if($exist){
							$i--;
							continue;
						}

						$tm_idx = $databases[$number];

						$result = mysql_query("UPDATE `cti_tm_list` SET `agent_idx` = $agent_idx 
								WHERE idx = $tm_idx " );

						array_push($array, $number);

					}

				}

			}
			
			if($db_status != 0)
				mysql_query("UPDATE cti_agents SET notify = 1 WHERE logging >= 1 and account_idx = $agent_idx " );

		}

		echo json_encode(array(
			"response" => "ok"
		));

		break;

	case "dbRestore" :

		if(!$isAdmin) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$idx = $args[idx];
		$option = $args[option];
		$idxs = base64_decode(str_replace(" ","+",$args[idxs]));

		$result = mysql_query(" select status from cti_db where idx = $idx");
		$db_status = mysql_fetch_array($result);
		$db_status = $db_status[status];

		if($option != null){
			if($option == 0)
				$option = " and (result = 0 or result = 6) ";
			else
				$option = " and result = $option ";			
		}

		$nolist = array();
		
		if($idxs != null){

			if($db_status != 0)
				$where = " and agent_idx is not null";// and result != 5";

			if(!isJson($idxs)){
				echo json_encode(array(
					"response" => "fail",
					"cause" => "execute_error"
				));
				return;
			}

			$idxs = json_decode($idxs);

			mysql_query("START TRANSACTION");

			foreach($idxs as $idx){

				if($db_status != 0) {
					$result = mysql_query("SELECT count(agent_idx) as count FROM cti_tm_list 
					WHERE idx = $idx and result = 5 and agent_idx is not null" );
					$tm = mysql_fetch_array($result);
					if($tm[count] >= 1) {
						array_push($nolist, $idx);
						continue;
					}
				}

				$result = mysql_query("UPDATE `cti_tm_list` SET `agent_idx` = null 
				WHERE idx = $idx $where" );

				if($result != 1) {
					echo json_encode(array(
						"response" => "fail",
						"cause" => mysql_error()."  =>".$idx
					));
					mysql_query("ROLLBACK");
					return;
				}

			}

			if($db_status != 0)
				mysql_query("UPDATE cti_agents SET notify = 1 WHERE logging >= 1 " );

			mysql_query("COMMIT");

			echo json_encode(array(
				"response" => "ok",
				"nolist" => $nolist
			));

			return;

		}

		if($idx != null){

			if($db_status != 0){
				$where = " and agent_idx is not null and result != 5";
			}else{
				mysql_query("UPDATE `cti_tm_list` SET `result` = 0 
				WHERE db_idx = $idx and result = 5" );
			}

			mysql_query("START TRANSACTION");

			$result = mysql_query("UPDATE `cti_tm_list` SET `agent_idx` = null 
			WHERE db_idx = $idx $where $option" );

			if($result != 1) {
				echo json_encode(array(
					"response" => "fail",
					"cause" => mysql_error()."  =>".$idx
				));
				mysql_query("ROLLBACK");
				return;
			}

			if($db_status != 0)
				mysql_query("UPDATE cti_agents SET notify = 1 WHERE logging >= 1 " );

			mysql_query("COMMIT");

			echo json_encode(array(
				"response" => "ok"			
			));

		}

		break;

	case "modifyCustomer" : //고객정보 수정

		$agent_idx = $args[agent_idx];

		$isAgent = isAllowAgent($agent_idx, $id, $pw);

		if(!$isAgent) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$cus_idx = $args[cus_idx];

		$result = mysql_query("SELECT account_idx FROM cti_agents WHERE idx = $agent_idx");
		$account_idx = mysql_fetch_array($result);
		$account_idx = $account_idx[account_idx];

		$result = mysql_query(" select count(idx) as count from cti_tm_list WHERE idx = $cus_idx and agent_idx = $account_idx");
		$permission = mysql_fetch_array($result);
		$permission = $permission[count];

		if($permission <= 0 ){
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

	
		$data = base64_decode(str_replace(" ","+",$args[data]));

		if(!isJson($data)){
			echo json_encode(array(
				"response" => "fail",
				"cause" => "execute_error"
			));
			return;
		}

		$data = json_decode($data);

		if($data->name != null){
			$name = cleanup($data->name);
			$name = "'$name'";
		}else
			$name = "null";

		if($data->product_name != null){
			$product_name = cleanup($data->product_name);
			$product_name = "'$product_name'";
		}else
			$product_name = "null";
		
		if($data->seller != null){
			$seller = cleanup($data->seller);
			$seller = "'$seller'";
		}else
			$seller = "null";
		
		if($data->price != null){
			$price = cleanup($data->price);
			$price = "'$price'";
		}else
			$price = "null";

		if($data->phone_number != null){
			$phone_number = formatNumber($data->phone_number);
			$phone_number = "'$phone_number'";
		}else
			$phone_number = "null";
		
		if($data->home_number != null){
			$home_number = formatNumber($data->home_number);
			$home_number = "'$home_number'";
		}else
			$home_number = "null";
		
		if($data->address != null){
			$address = cleanup($data->address);
			$address = "'$address'";
		}else
			$address = "null";
		
		if($data->comment != null){
			$comment = cleanup($data->comment);
			$comment = "'$comment'";
		}else
			$comment = "null";

		if($data->comment2 != null){
			$comment2 = cleanup($data->comment2);
			$comment2 = "'$comment2'";
		}else
			$comment2 = "null";
		
		mysql_query("START TRANSACTION");

		$result = mysql_query("UPDATE cti_tm_list SET 
			name = $name,
			product_name = $product_name,
			seller = $seller,
			price = $price,
			phone_number = $phone_number,
			home_number = $home_number,
			address = $address,
			comment = $comment,
			comment2 = $comment2 
		WHERE idx = $cus_idx " );

		if($result != 1) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => mysql_error()."  =>".$cus_idx
			));
			mysql_query("ROLLBACK");
			return;
		}

		mysql_query("COMMIT");

		echo json_encode(array(
			"response" => "ok",
			"nolist" => $nolist
		));

		break;

	case "delCustomer" : //고객정보 삭제

		if(!$isAdmin) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$db_idx = $args[db_idx];

		$result = mysql_query(" select status from cti_db where idx = $db_idx");
		$db_status = mysql_fetch_array($result);
		$db_status = $db_status[status];

		$agent_idx = $args[agent_idx];
		$idxs = base64_decode(str_replace(" ","+",$args[idxs]));

		if(!isJson($idxs)){
			echo json_encode(array(
				"response" => "fail",
				"cause" => "execute_error"
			));
			return;
		}

		$idxs = json_decode($idxs);

		$nolist = array();

		mysql_query("START TRANSACTION");

		foreach($idxs as $idx){

			if($db_status != 0) { //기존 agent 푸시
				$result = mysql_query("SELECT agent_idx, result FROM cti_tm_list 
				WHERE idx = $idx and agent_idx is not null" );
				$tm = mysql_fetch_array($result);
				if($tm[result] == 5) {
					array_push($nolist, $idx);
					continue;
				}else{
					mysql_query("UPDATE cti_agents SET notify = 1 WHERE account_idx = $tm[agent_idx] " );
				}
			}

			$result = mysql_query("DELETE FROM cti_tm_list WHERE idx = $idx " );

			if($result != 1) {
				echo json_encode(array(
					"response" => "fail",
					"cause" => mysql_error()."  =>".$idx
				));
				mysql_query("ROLLBACK");
				return;
			}

		}

		//if($db_status != 0)
		//	mysql_query("UPDATE cti_agents SET notify = 1 WHERE logging >= 1 and account_idx = $agent_idx " );

		mysql_query("COMMIT");

		echo json_encode(array(
			"response" => "ok",
			"nolist" => $nolist
		));

		break;

	case "setBlacklist" : //블랙리스트 등록

		if(!$isAdmin) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$deleteMode = $args[deleteMode];
		$idxs = base64_decode(str_replace(" ","+",$args[idxs]));

		if(!isJson($idxs)){
			echo json_encode(array(
				"response" => "fail",
				"cause" => "execute_error"
			));
			return;
		}

		$idxs = json_decode($idxs);

		//$nolist = array();

		mysql_query("START TRANSACTION");

		foreach($idxs as $idx){

			if($deleteMode)
				$result = mysql_query("DELETE FROM cti_tm_list WHERE idx = $idx " );		
			else
				$result = mysql_query("UPDATE cti_tm_list SET blacklist = 1 WHERE idx = $idx " );
			

			if($result != 1) {
				echo json_encode(array(
					"response" => "fail",
					"cause" => mysql_error()."  =>".$idx
				));
				mysql_query("ROLLBACK");
				return;
			}

		}

		mysql_query("COMMIT");

		echo json_encode(array(
			"response" => "ok"
		));

		break;

	case "agentLogin" :

		$idx = $args[idx];
		$isAgent = isAllowAgent($idx, $id, $pw);

		if(!$isAgent) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$result = mysql_query("SELECT account_idx FROM cti_agents WHERE idx = $idx");
		$account_idx = mysql_fetch_array($result);
		$account_idx = $account_idx[account_idx];

		$refresh = $args[refresh];

		if($refresh == 0){

			mysql_query("START TRANSACTION");

			$result = mysql_query("UPDATE cti_agents SET logging = 1, last_date = '$nowDate', notify = null WHERE idx = $idx " );

			if($result != 1) {
				echo json_encode(array(
					"response" => "fail",
					"cause" => mysql_error()."  =>".$idx
				));
				mysql_query("ROLLBACK");
				return;
			}

			mysql_query("COMMIT");

		}

		$result = mysql_query(" select idx, name from cti_db where status = 1");

		$array = array();

		while($row = mysql_fetch_array($result)){
			$myTMcount = mysql_query(" select count(idx) as count from cti_tm_list 
										where db_idx = $row[idx] and agent_idx = $account_idx");
			$myTMcount = mysql_fetch_array($myTMcount);
			if($myTMcount[count]<=0) continue;
			array_push($array, array(
				"idx" => $row[idx],
				"name" => $row[name]
			));
		}

		echo json_encode(array(
			"response" => "ok",
			"output" => json_encode($array)
		));

		break;

	case "agentLogout" :

		$idx = $args[idx];
		$isAgent = isAllowAgent($idx, $id, $pw);

		if(!$isAgent) return;		

		$result = mysql_query("UPDATE cti_agents SET logging = null WHERE idx = $idx " );

		if($result == 1) {
			echo json_encode(array(
				"response" => "ok",
			));
		}else{
			echo json_encode(array(
				"response" => "fail",
				"cause" => mysql_error()
			));
		}

		break;

	case "agentBreak" :

		$idx = $args[idx];
		$isAgent = isAllowAgent($idx, $id, $pw);

		if(!$isAgent) return;		

		$result = mysql_query("UPDATE cti_agents SET logging = 2 WHERE idx = $idx " );

		if($result == 1) {
			echo json_encode(array(
				"response" => "ok",
			));
		}else{
			echo json_encode(array(
				"response" => "fail",
				"cause" => mysql_error()
			));
		}

		break;

	case "agentUnbreak" :

		$idx = $args[idx];
		$isAgent = isAllowAgent($idx, $id, $pw);

		if(!$isAgent) return;

		$result = mysql_query("UPDATE cti_agents SET logging = 1 WHERE idx = $idx " );

		if($result == 1) {
			echo json_encode(array(
				"response" => "ok",
			));
		}else{
			echo json_encode(array(
				"response" => "fail",
				"cause" => mysql_error()
			));
		}

		break;



	case "startCall" :

		$agent_idx = $args[agent_idx];
		$cus_idx = $args[cus_idx];
		$call_phone = $args[call_phone];

		$isAgent = isAllowAgent($agent_idx, $id, $pw);

		if(!$isAgent) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$result = mysql_query("SELECT account_idx FROM cti_agents WHERE idx = $agent_idx");
		$account_idx = mysql_fetch_array($result);
		$account_idx = $account_idx[account_idx];

		$result = mysql_query("SELECT agent_idx, call_count FROM cti_tm_list WHERE idx = $cus_idx");
		$tm = mysql_fetch_array($result);
		$tm_agent_idx = $tm[agent_idx];

		if($account_idx != $tm_agent_idx){ //나의 고객정보가 아닐경우
			echo json_encode(array(
				"response" => "fail",
				"cause" => "is_not_my_customer"
			));
			return;
		}

		$call_count = $tm[call_count] + 1;

		$result = mysql_query("UPDATE cti_tm_list 
		SET result = 5, call_count = $call_count, call_phone = '$call_phone', call_time = '$nowDate'
		WHERE idx = $cus_idx" );

		if($result == 1) {
			echo json_encode(array(
				"response" => "ok",
			));
		}else{
			echo json_encode(array(
				"response" => "fail",
				"cause" => mysql_error()
			));
		}

		break;


	case "endCall" :

		$agent_idx = $args[agent_idx];
		$cus_idx = $args[cus_idx];
		$status = $args[status];

		$isAgent = isAllowAgent($agent_idx, $id, $pw);

		if(!$isAgent) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$result = mysql_query("SELECT account_idx FROM cti_agents WHERE idx = $agent_idx");
		$account_idx = mysql_fetch_array($result);
		$account_idx = $account_idx[account_idx];

		$result = mysql_query("SELECT agent_idx, call_count FROM cti_tm_list WHERE idx = $cus_idx");
		$tm = mysql_fetch_array($result);
		$tm_agent_idx = $tm[agent_idx];

		if($account_idx != $tm_agent_idx){ //나의 고객정보가 아닐경우
			echo json_encode(array(
				"response" => "fail",
				"cause" => "is_not_my_customer"
			));
			return;
		}

		$result = mysql_query("UPDATE cti_tm_list SET result = $status WHERE idx = $cus_idx" );

		if($result == 1) {
			echo json_encode(array(
				"response" => "ok",
			));
		}else{
			echo json_encode(array(
				"response" => "fail",
				"cause" => mysql_error()
			));
		}

		break;

	case "dbFactoryReset": //DB 완전 초기화

		if(!$isAdmin) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$remove_agent = $args[remove_agent];
		$remove_db = $args[remove_db];

		if($remove_agent)
			$result = mysql_query("TRUNCATE `cti_agents`" );	

		if($remove_db){
			$result = mysql_query("TRUNCATE `cti_db`" );	
			$result = mysql_query("TRUNCATE `cti_tm_list`" );	
		}

		if($result == 1) {
			echo json_encode(array(
				"response" => "ok",
			));
		}else{
			echo json_encode(array(
				"response" => "fail",
				"cause" => mysql_error()
			));
		}			

		break;

	case "restoreBlacklist":

		if(!$isAdmin) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$db_idx = $args[db_idx];
		
		$result = mysql_query("UPDATE cti_tm_list SET blacklist = 0 WHERE db_idx = $db_idx and blacklist = 1");

		if($result == 1) {
			echo json_encode(array(
				"response" => "ok"
			));
		}else{
			echo json_encode(array(
				"response" => "fail",
				"cause" => "no_exist"
			));
		}

		break;

}


?>