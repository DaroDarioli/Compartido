<?php

include_once 'vehiculo.php';
include_once 'estacionamiento.php';
#paara pasar hipertexto fuera del servidor, sino serìa phpinfo
#metodo get y post, manda las peticiones html o javascript; para emular
#usamos postman

#por get se pide cierta info
#var_dump($_GET);

#para testear is a postman -->post-->body-->cargar parámetro-->send

$patente = $_POST['patente'];
$auto = new vehiculo($_POST['patente']);
$accion = $_POST['accion'];

if($accion == "Guardar")
{
   echo 'Guardo auto patente: '.$patente;
    Estacionamiento::Testeo($patente);
    Estacionamiento::Guardar($auto);
}
else if($accion == "Sacar")
{
     echo 'Saco auto patente: '.$patente;
}
else
    echo 'Parametro de acción inválido: '.$accion;


/*var_dump($_POST);
echo 'HOLA HTTP AVELLANEDA';
*/
#$_GET[];

?>