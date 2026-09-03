<?

function cleanup($c) {
	$c=str_replace(array("\r", "\n"), "<br>", $c);
	$c=trim($c);
	$c=mysql_real_escape_string($c);
	$c=htmlspecialchars($c, ENT_QUOTES);
	$c=nl2br($c);
	$c=StripSlashes($c);
	$c=addslashes($c);
	return($c);
}

function txtcleanup($c) {
	$c=trim($c);
	$c=htmlspecialchars($c, ENT_QUOTES);
	$c=StripSlashes($c);
	$c=addslashes($c);
	return($c);
}

function unhtmlspecialchars($string) { 
	$string = str_replace('&amp;', '&', $string);
	$string = str_replace('&#039;', '\'', $string);
	$string = str_replace('&quot;', '"', $string);
	$string = str_replace('&lt;', '<', $string);
	$string = str_replace('&gt;', '>', $string);
	$string = str_replace("<br>", "\n", $string);
	return $string;
}

function isJson($string) {
 json_decode($string);
 return (json_last_error() == JSON_ERROR_NONE);
}

function han ($s) { return reset(json_decode('{"s":"'.$s.'"}')); }
function to_han ($str) { return preg_replace('/(\\\u[a-f0-9]+)+/e','han("$0")',$str); }

function autoWhere($column_name, $or_and, $array, $quoteEnable = false, $equalString = "=") {
	$tmp = "";
	if(count($array) <= 0) return "";
	foreach ($array as $v) {
		$tmp = $tmp . ($tmp==null?"":$or_and) . " `" . $column_name . "` ". $equalString ." " . ($quoteEnable?"'":"") . $v . ($quoteEnable?"' ":" ");
	}
	return trim($tmp);
}

function autoString($array, $frontText, $endText) {
	$bin = array();
	foreach ($array as $v) {
		$v = $frontText . $v . $endText;
		array_push($bin, $v);		
	}
	return $bin;
}

function formatNumber($phoneNumber) {
    $phoneNumber = preg_replace('/[^0-9]/','',$phoneNumber);

    if(strlen($phoneNumber) > 10) {
        $countryCode = substr($phoneNumber, 0, strlen($phoneNumber)-10);
        $areaCode = substr($phoneNumber, -10, 2);
        $nextThree = substr($phoneNumber, -8, 4);
        $lastFour = substr($phoneNumber, -4, 4);

        $phoneNumber = $countryCode.$areaCode.'-'.$nextThree.'-'.$lastFour;
    }
    else if(strlen($phoneNumber) == 10) {
        $areaCode = substr($phoneNumber, 0, 3);
        $nextThree = substr($phoneNumber, 3, 3);
        $lastFour = substr($phoneNumber, 6, 4);

        $phoneNumber = $areaCode.'-'.$nextThree.'-'.$lastFour;
    }
    else if(strlen($phoneNumber) == 7) {
        $nextThree = substr($phoneNumber, 0, 3);
        $lastFour = substr($phoneNumber, 3, 4);

        $phoneNumber = $nextThree.'-'.$lastFour;
    }

    return $phoneNumber;
}

function removeHyphen($callNumber) {
	return str_replace(' ','',str_replace('-','',$callNumber));
}

function generateRandomString($length = 10) {
    $characters = '0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ';
    $charactersLength = strlen($characters);
    $randomString = '';
    for ($i = 0; $i < $length; $i++) {
        $randomString .= $characters[rand(0, $charactersLength - 1)];
    }
    return $randomString;
}

function generateRandomStringNumber($length = 10) {
    $characters = '1234567890';
    $charactersLength = strlen($characters);
    $randomString = '';
    for ($i = 0; $i < $length; $i++) {
        $randomString .= $characters[rand(0, $charactersLength - 1)];
    }
    return $randomString;
}

function encrypt($pure_string, $encryption_key) {
    $iv_size = mcrypt_get_iv_size(MCRYPT_BLOWFISH, MCRYPT_MODE_ECB);
    $iv = mcrypt_create_iv($iv_size, MCRYPT_RAND);
    $encrypted_string = mcrypt_encrypt(MCRYPT_BLOWFISH, $encryption_key, $pure_string, MCRYPT_MODE_ECB, $iv);
    return $encrypted_string;
}

function decrypt($encrypted_string, $encryption_key) {
    $iv_size = mcrypt_get_iv_size(MCRYPT_BLOWFISH, MCRYPT_MODE_ECB);
    $iv = mcrypt_create_iv($iv_size, MCRYPT_RAND);
    $decrypted_string = mcrypt_decrypt(MCRYPT_BLOWFISH, $encryption_key, $encrypted_string, MCRYPT_MODE_ECB, $iv);
    return $decrypted_string;
}

?>