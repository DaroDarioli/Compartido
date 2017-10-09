<?php

include_once 'usuario.php';

$varEmail = $_POST['email'];
$varClave = $_POST['clave'];

echo usuario::VerificaUsuario($varEmail,$varClave);


?>

