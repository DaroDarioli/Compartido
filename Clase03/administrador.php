<?php
//llama a guardar y sacar 
//tiene q recibir auto, y si es guardar o sacar

include_once 'vehiculo.php';
include_once 'estacionamiento.php';

$auto1 = new Vehiculo('abc1'); 
$auto2 = new Vehiculo('abc2');
$auto3 = new Vehiculo('abc3');
$auto4 = new Vehiculo('abc4');
$auto5 = new Vehiculo('abc5');

$accion = "Guardar";

if($accion == "Guardar")
{
    Estacionamiento::Guardar($auto1);
    Estacionamiento::Guardar($auto2);
    Estacionamiento::Guardar($auto3);
    Estacionamiento::Guardar($auto4);
    Estacionamiento::Guardar($auto5);
}
else
{
     Estacionamiento::Sacar($auto1);
}


?>