<?php

include_once 'usuario.php';
include_once 'comentario.php';

$varEmail = $_POST['email'];
$varComentario = $_POST['comentario'];

if(usuario::VerificaMail($varEmail))
{
    comentario::Archivar($varEmail,$varComentario);
}


?>

