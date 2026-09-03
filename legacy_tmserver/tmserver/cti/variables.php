<?

// 관리자 권한인지 확인
function isAdminAccount($id, $pw) {

	$result = mysql_query(" select count(account_code) as count from ss_account
		where account_id like '$id' and account_pw like '$pw' and acgb_code = 5"); //5는 루트관리자

	$count = mysql_fetch_array($result);
	return $count[count] > 0;

}

// 허용된 Agent인지 확인
function isAllowAgent($idx, $id, $pw) {

	$result = mysql_query(" select count(account_code) as count from ss_account

		left join cti_agents
		on account_code = account_idx

		where account_id like '$id' and account_pw like '$pw' and idx = $idx and expire = 0");

	$count = mysql_fetch_array($result);
	return $count[count] > 0;

}

// 허용된 Agent인지 확인 (검색
function isAllowSearchAgent($id, $pw) {

	$result = mysql_query(" select count(account_code) as count from ss_account

		left join cti_agents
		on account_code = account_idx

		where account_id like '$id' and account_pw like '$pw' and expire = 0");

	$count = mysql_fetch_array($result);
	return $count[count] > 0;

}

// 계정 가져오기
function getAccount($id) {

	$result = mysql_query(" select account_code, account_name
		from ss_account
		where account_id like '$id' and account_pw like '$pw' and acgb_code = 3 LIMIT 1");

	return mysql_fetch_array($result);

}

?>