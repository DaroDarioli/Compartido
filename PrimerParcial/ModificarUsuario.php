<?php

include_once 'usuario.php';

$varEmail = $_POST['email'];
$varNombre = $_POST['nombre'];
$varEdad = $_POST['edad'];
$varClave = $_POST['clave'];

$varUser =  new Usuario();
$varUser->setNombre($varNombre);
$varUser->setMail($varEmail);
$varUser->setClave($varClave);
$varUser->setAge($varEdad);

//echo $varUser->ToString();


if(usuario::VerificaMail($varEmail)){
    
   usuario::MoficarLista($varUser);

}


?>

