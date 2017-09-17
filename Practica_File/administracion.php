<?php

include_once "empleado.php";

$varNombre = $_POST['nombre'];
$varApellido = $_POST['apellido'];
$varDNI = $_POST['dni'];
$varSexo = $_POST['sexo'];
$varLegajo = $_POST['legajo'];
$varSueldo = $_POST['sueldo'];

$varEmplado = new empleado($varNombre,$varApellido,$varDNI,$varSexo,$varLegajo,$varSueldo);
var_dump($_FILES);


if(isset($_POST["cargarEmpleado"]))
{ 
    if($_FILES['archivo']['type'] == "image/png" ||$_FILES['archivo']['type'] == "image/jpeg")
    {
        if($_FILES["archivo"]['size'] < 1000000)
        {           
            $destino = "./Nueva/".$_FILES['archivo']['name']; 
            if(file_exists($destino) == false)
            {
                move_uploaded_file($_FILES['archivo']['tmp_name'], $destino);
                echo 'Se guardó la imagen: '.$_FILES['archivo']['name'];
                $varEmplado->setPathToPhoto($destino);
                empleado::Archivar($varEmplado);
            }
            else
            {
                echo '<h3>No se pueden guardar imágenes con nombre repetidos</3>';
            }         
         
        }
        else
        {
            echo 'La imagen seleccionada supera el tamaño permitido (1 MB)';
        }
    }
    else
    {
        echo 'La terminación del archivo es inválida';
    }    
}



$archivo = fopen('Archivos/Empleados.txt',"a");
$escritura = fwrite($archivo,$varEmplado->ToString()."\r\n");         
if($escritura == false)
{
    echo 'El archivo no pudo ser agegregado';
    echo '<a href =\"mostrar.php\">Mostrar Empleados</a>';
}
else
{
    echo '<h3>El empleado fue cargado correctamente</h3>';
    echo '<a href = "mostrar.php">Mostrar Empleados</a>';
}
fclose($archivo);

?>

