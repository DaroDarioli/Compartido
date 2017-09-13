<?php

           
$archivo = fopen('Archivos/Empleados.txt',"r");       
    
while(!feof($archivo ))
{
    echo fgets($archivo).'<br>'; //-->ok  
 /*   $aux = fgets($archivo);
    $cadena = explode("-",$aux);
    echo $cadena[0].'<br>';          
    #echo $cadena[1].'<br>';*/
}
fclose($archivo);      
 



?>