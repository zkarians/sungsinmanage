<?
include_once("./_core.php");

$id = $args[id];
$pw = $args[pw];

$isAdmin = isAdminAccount($id,$pw);


switch($type){

	case "getAgents":

		if(!$isAdmin) return;

		$result = mysql_query("SELECT idx, account_code, account_id, account_name, regist_date, expire_date, expire, logging, last_date FROM cti_agents
							left join ss_account
							on account_idx = account_code ");

		$array = array();

		while($row = mysql_fetch_array($result)){
			array_push($array, array(
				"idx" => $row[idx],
				"account_code" => $row[account_code],
				"account_id" => $row[account_id],
				"account_name" => unhtmlspecialchars($row[account_name]),
				"regist_date" => $row[regist_date],
				"expire_date" => $row[expire_date],
				"expire" => ($row[account_code] == null?1 : $row[expire]),
				"logging" => $row[logging],
				"last_date" => $row[last_date]
			));	

		}
		
		echo json_encode(array(
			"response" => "ok",
			"output" => json_encode($array)
		));

		break;

	case "getDB":

		if(!$isAdmin) return;

		$flag = $args[flag];

		switch($flag){
			case "blacklist" :
				$where = " WHERE blacklist = 1";
				break;
			default : 
				$where = " WHERE blacklist is null";
		}

		$result = mysql_query(" select idx, name, status, last_date from cti_db $where");

		$array = array();

		while($row = mysql_fetch_array($result)){

			$count_result = mysql_query("SELECT result, COUNT(*) as count FROM cti_tm_list 
			where db_idx = $row[idx] GROUP BY result ");
			
			$call_counts = array( 0 => 0, 1 => 0, 2 => 0, 3 => 0, 4 => 0, 5 => 0, 6 => 0, 7 => 0, 8 => 0);

			// 0=미처리 1=동의 2=무관심 3=TM거부 4=무응답 5=통화중 6=통화예약 7=결번 8=본인아님

			$nosplit_count = mysql_query("SELECT COUNT(idx) as count FROM cti_tm_list
			where agent_idx is null and db_idx = $row[idx] "); //and blacklist=0
			$nosplit_count = mysql_fetch_array($nosplit_count);
			$nosplit_count = $nosplit_count[count]; //총 미배분 건수

			$blacklist_count = mysql_query("SELECT COUNT(idx) as count FROM cti_tm_list
			where blacklist = 1 and db_idx = $row[idx]");
			$blacklist_count = mysql_fetch_array($blacklist_count);
			$blacklist_count = $blacklist_count[count]; //총 미배분 건수

			while($counts = mysql_fetch_array($count_result)){
				if($counts[result]==6) $call_counts[0] += $counts[count];
				else $call_counts[$counts[result]] = $counts[count];
			}

			//$call_counts[0] -= $blacklist_count;

			array_push($array, array(
				"idx" => $row[idx],
				"name" => unhtmlspecialchars($row[name]),
				"status" => $row[status],
				"call_counts" => json_encode($call_counts),
				"last_date" => $row[last_date],
				"nosplit_count" => $nosplit_count,
				"blacklist_count" => $blacklist_count
			));

		}

		
		echo json_encode(array(
			"response" => "ok",
			"output" => json_encode($array)
		));

		break;

	case "getAgentsResult" :

		if(!$isAdmin) return;

		$db_idx = $args[db_idx];
		$option = $args[option];

		if($option != null){
			$option = " and result = $option";
		}else{
			$option = "";
		}

		$result = mysql_query("SELECT agent_idx, COUNT(*) as count FROM cti_tm_list 
		where agent_idx is not null and db_idx = $db_idx GROUP BY agent_idx ");

		$array = array();
		while($row = mysql_fetch_array($result)){

			$result0 = mysql_query("SELECT count(agent_idx) as count FROM cti_tm_list 
			where db_idx = $db_idx and agent_idx = $row[agent_idx] and result = 0 ");
			$result0 = mysql_fetch_array($result0);

			$result1 = mysql_query("SELECT count(agent_idx) as count FROM cti_tm_list 
			where db_idx = $db_idx and agent_idx = $row[agent_idx] and result = 1 ");
			$result1 = mysql_fetch_array($result1);

			array_push($array, array(
				"agent_idx" => $row[agent_idx],
				"result0" => $result0[count],
				"result1" => $result1[count],
				"resultAll" => $row[count]
			));

		}

		echo json_encode(array(
			"response" => "ok",
			"output" => json_encode($array)
		));

		break;

	case "getCusData":

		if(!$isAdmin) return;

		$db_idx = $args[db_idx];
		$option = $args[option];
		$page = $args[page];
		$all = $args[all];
		$blacklistViewMode = $args[blacklistViewMode];

		$limit = $page * 500;
		$limit = "limit $limit, 500";

		if($option != null)
			$option = "and result = $option";

		if($all == 1) {
			$limit = "";
		}

		if($blacklistViewMode == 1){
			$blacklistWhere = " and blacklist = 1";
		}else{
			$blacklistWhere = " and blacklist = 0";
		}

		if($blacklistViewMode == 2){
			$blacklistWhere = "";
		}

		$result = mysql_query(" select idx, agent_idx, name, product_name, seller, price, phone_number, home_number,
		address, result, call_time, call_count, call_phone, restored, comment, comment2, blacklist from cti_tm_list 
		where db_idx = $db_idx $blacklistWhere $option ORDER by idx ASC  $limit ");

		$count = mysql_query(" select count(idx) as count from cti_tm_list where db_idx = $db_idx $blacklistWhere $option");
		$count = mysql_fetch_array($count);

		$array = array();

		while($row = mysql_fetch_array($result)){

			array_push($array, array(
				"idx" => $row[idx],
				"agent_idx" => $row[agent_idx],
				"name" => unhtmlspecialchars($row[name]),
				"product_name" => unhtmlspecialchars($row[product_name]),
				"seller" => unhtmlspecialchars($row[seller]),
				"price" => $row[price],
				"phone_number" => $row[phone_number],
				"home_number" => $row[home_number],
				"address" => unhtmlspecialchars($row[address]),
				"result" => $row[result],
				"call_time" => $row[call_time],
				"call_count" => $row[call_count],
				"call_phone" => $row[call_phone],
				"restored" => $row[restored],
				"comment" =>unhtmlspecialchars($row[comment]),
				"comment2" => unhtmlspecialchars($row[comment2]),
				"blacklist" => $row[blacklist]

			));

		}

		
		echo json_encode(array(
			"response" => "ok",
			"output" => json_encode($array),
			"max_page" => ceil($count[count]/500),
			"count" => $count[count]
		));

		break;

	case "agentGetTMList":

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

		$db_idx = $args[db_idx];

		$result = mysql_query(" select idx, agent_idx, name, product_name, seller, price, phone_number, home_number,
		address, result, call_time, call_count, call_phone, restored, comment, comment2, blacklist from cti_tm_list 
		where db_idx = $db_idx and agent_idx = $account_idx ORDER by idx ASC ");

		$array = array();

		while($row = mysql_fetch_array($result)){

			array_push($array, array(
				"idx" => $row[idx],
				"agent_idx" => $row[agent_idx],
				"name" => unhtmlspecialchars($row[name]),
				"product_name" => unhtmlspecialchars($row[product_name]),
				"seller" => unhtmlspecialchars($row[seller]),
				"price" => $row[price],
				"phone_number" => $row[phone_number],
				"home_number" => $row[home_number],
				"address" => unhtmlspecialchars($row[address]),
				"result" => $row[result],
				"call_time" => $row[call_time],
				"call_count" => $row[call_count],
				"call_phone" => $row[call_phone],
				"restored" => $row[restored],
				"comment" =>unhtmlspecialchars($row[comment]),
				"comment2" => unhtmlspecialchars($row[comment2]),
				"blacklist" => $row[blacklist]
			));

		}

		
		echo json_encode(array(
			"response" => "ok",
			"output" => json_encode($array)
		));

		break;


	case "getAgentPush":

		$idx = $args[idx];
		$isAgent = isAllowAgent($idx, $id, $pw);

		if(!$isAgent) {
			echo json_encode(array(
				"response" => "fail",
				"cause" => "permission_error"
			));
			return;
		}

		$result = mysql_query("SELECT notify FROM cti_agents WHERE idx = $idx");

		$notify = mysql_fetch_array($result);
		$notify = $notify[notify];

		if($notify == 1) {
			mysql_query("UPDATE cti_agents SET notify = null WHERE idx = $idx " );
			echo json_encode(array(
				"response" => "ok"
			));
		}

		break;


	case "getFindCustomer":

		$idx = $args[idx];
		$call_number = $args[call_number];
		$isAgent = isAllowSearchAgent($id, $pw);

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

		$call_number = removeHyphen($call_number);

		$result = mysql_query("
										SELECT idx, db_idx FROM cti_tm_list
										WHERE (replace(replace(phone_number, ' ', ''),'-','') = '$call_number' or replace(replace(home_number, ' ', ''),'-','') = '$call_number')
											and agent_idx = $account_idx
										");

		$detail = mysql_fetch_array($result);

		if (!$detail) {
			echo json_encode(array(
				"response" => "ok",
				"output" => null
			));
			return;
		}

		//$detail['idx'];
		$db_idx = $detail['db_idx'];

		//return;

		$result = mysql_query(" select idx, agent_idx, name, product_name, seller, price, phone_number, home_number,
							address, result, call_time, call_count, call_phone, restored, comment, comment2, blacklist from cti_tm_list 
							where db_idx = $db_idx and agent_idx = $account_idx ORDER by idx ASC ");

		$array = array();

		$i=0;

		while($row = mysql_fetch_array($result)){

			array_push($array, array(
				"db_idx" => $db_idx,
				"idx" => $row[idx],
				"agent_idx" => $row[agent_idx],
				"name" => unhtmlspecialchars($row[name]),
				"product_name" => unhtmlspecialchars($row[product_name]),
				"seller" => unhtmlspecialchars($row[seller]),
				"price" => $row[price],
				"phone_number" => $row[phone_number],
				"home_number" => $row[home_number],
				"address" => unhtmlspecialchars($row[address]),
				"result" => $row[result],
				"call_time" => $row[call_time],
				"call_count" => $row[call_count],
				"call_phone" => $row[call_phone],
				"restored" => $row[restored],
				"comment" =>unhtmlspecialchars($row[comment]),
				"comment2" => unhtmlspecialchars($row[comment2]),
				"blacklist" => $row[blacklist],
				"is_correct" => ($row['idx'] == $detail['idx'] ? true : false),
				"page" => ($row['idx'] == $detail['idx'] ? floor($i/500) : 0)
			));

			$i++;

		}
		
		echo json_encode(array(
			"response" => "ok",
			"output" => json_encode($array)
		));

		break;


}


?>