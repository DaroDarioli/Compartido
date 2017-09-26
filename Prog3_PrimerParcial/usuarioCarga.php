<?php

include_once 'usuario.php';

$varNombre = $_GET['nombre'];
$varEmail = $_GET['email'];
$varAdmin = $_GET['admin'];
$varUser = $_GET['user'];
$varEdad = $_GET['edad'];
$varClave = $_GET['clave'];

$varUser =  new Usuario();
$varUser->setNombre($varNombre);
$varUser->setMail($varEmail);
$varUser->setClave($varClave);
$varUser->setAge($varEdad);

$varUser->Archivar($varUser);

?>

