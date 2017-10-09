<?php

include_once 'usuario.php';

$varNombre = $_POST['nombre'];
$varEmail = $_POST['email'];
//$varAdmin = $_GET['admin'];
//$varUser = $_GET['user'];
$varEdad = $_POST['edad'];
$varClave = $_POST['clave'];

$varUser =  new Usuario();
$varUser->setNombre($varNombre);
$varUser->setMail($varEmail);
$varUser->setClave($varClave);
$varUser->setAge($varEdad);

$varUser->Archivar($varUser);

?>

