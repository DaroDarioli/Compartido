<?php

include_once "empleado.php";
           
$archivo = fopen('Archivos/Empleados.txt',"r");       
  
/*
while(!feof($archivo ))
{
    echo fgets($archivo).'<br>'; //-->ok  
 /*   $aux = fgets($archivo);
    $cadena = explode("-",$aux);
    echo $cadena[0].'<br>';          
    #echo $cadena[1].'<br>';
}
fclose($archivo);      
 
*/

           
$archivo = fopen('Archivos/EmpleadosImagen.txt',"r");       

while(!feof($archivo))
{   
    $aux = fgets($archivo);
    $cadena = explode("Imagen: ",$aux);
    if($cadena[0] == "")break;  
    echo '<img src= '.$cadena[1].' alt="Smiley face" height="100" width="100"><br><h5>'.$cadena[0].'</h5><br>';     
}
fclose($archivo);  

?>