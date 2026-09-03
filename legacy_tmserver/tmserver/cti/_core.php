<?

	ini_set('memory_limit', '-1');
	set_time_limit(0);

	//include_once("../_debug.php"); // DEBUG POST ARGS EXAMPLE, ERROR REPORTING

	include_once("../dbconfig.php");
	include_once("./system_functions.php");
	include_once("./variables.php");
	$nowDate = date("Y-m-d H:i:s");

	$db = mysql_connect($mysql_hostname, $mysql_user, $mysql_password) or die("db connect error");
	mysql_select_db($mysql_database, $db) or die("db connect error");

	$var = json_decode($_POST['args']);
	if(!isset($var)) {
		http_response_code(403.8);
		die();
	}

	$args = array();
	foreach($var as $key => $value)
		$args = array_merge($args, array($key => cleanup($value)));

	$type = $args[type];


?>