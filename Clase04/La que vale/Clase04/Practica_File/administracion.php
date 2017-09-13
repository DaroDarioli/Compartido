<?php

include_once "empleado.php";

$varNombre = $_POST['nombre'];
$varApellido = $_POST['apellido'];
$varDNI = $_POST['dni'];
#var_dump($_FILES);
$varEmplado = new empleado($varNombre,$varApellido,$varDNI);
#echo $varEmplado->ToString();
 
$archivo = fopen('Archivos/Empleados.txt',"a");
fwrite($archivo,$varEmplado->ToString()."\r\n");         
fclose($archivo);




#empleado::Archivar($varEmplado);


$destino = "./Nueva/".$_FILES['archivo']['name'];
move_uploaded_file($_FILES['archivo']['tmp_name'], $destino);








/*


#echo 'Nombre: '.$varNombre;
$destino = "../RecibeImagen/";

#$destino = "../RecibeImagen/".$_FILES['archivo'];

if(move_uploaded_file( $_FILES['archivo'],$destino))
{
    echo '<br>Se cargó la imagen<br>'.$varNombre;
}
    

#move_uploaded_file(file,newloc)

*/

?>

