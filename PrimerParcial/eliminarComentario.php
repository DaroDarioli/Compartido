<?php

include_once 'usuario.php';
include_once 'comentario.php';

$varEmail = $_POST['email'];
//$varComentario = $_POST['comentario'];

$usuario = usuario::VerificaMailComentario($varEmail);

if($usuario != ""){

echo comentario::ModificarListado($varEmail);

}


?>

