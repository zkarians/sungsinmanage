<?

function cleanup($c) {
	$c=trim($c);
	$c=htmlspecialchars($c, ENT_QUOTES);
	$c=eregi_replace("%", "$#37;", $c);
	$c=eregi_replace("<","&lt;", $c);
	$c=eregi_replace(">","&gt;", $c);
	$c=eregi_replace("&amp;","&", $c);
	$c=nl2br($c);
	$c=StripSlashes($c);
	return($c);
}

$pc_version = 195;
$android_version = 12;

// POST //////////////////
$pcv=cleanup($_GET['pcv']);
$adv=cleanup($_GET['adv']);

$id=cleanup($_POST['id']);
$pw=cleanup($_POST['pw']);

include_once("./dbconfig.php");
 
$bd = mysql_connect($mysql_hostname, $mysql_user, $mysql_password) or die("db connect error");
mysql_select_db($mysql_database, $bd) or die("db connect error");

$condate = date("Y-m-d H:i:s");

$result=mysql_query("

select account_code, acgb_code, acgb, result.team_code, team, id, pw, name from(

SELECT a.account_code, a.acgb_code, acgb, team_code, account_id as id, account_pw as pw, account_name as name 
FROM ss_account a 
left join ss_accountgb b
on a.acgb_code = b.acgb_code) as result

left join ss_team c
on c.team_code = result.team_code

WHERE `id` LIKE '$id' AND `pw` LIKE '$pw' ");

$row = mysql_fetch_array($result);

if ($row==null) {

	echo "fail";

}else {

	echo 

	$row[acgb_code] // 구분코드
	."<next>".

	$row[acgb] // 구분
	."<next>".

	$row[team_code] // 소속 번호
	."<next>".

	$row[team] // 소속 문자
	."<next>".

	$row[name] // 이름
	."<next>".

	$condate
	."<next>".

	$row[account_code] // 코드			

	;

}


?>