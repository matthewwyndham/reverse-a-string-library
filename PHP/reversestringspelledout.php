<?php  
$string = $_GET['string']; 
$length = strlen($string);  
for ($i=($length-1) ; $i >= 0 ; $i--)   
{  
  echo $string[$i];  
}  
?>  