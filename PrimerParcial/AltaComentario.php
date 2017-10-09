<?php

include_once 'usuario.php';
include_once 'comentario.php';

$varEmail = $_POST['email'];
$varTitulo = $_POST['titulo'];
$varComentario = $_POST['comentario'];


if(usuario::VerificaMail($varEmail))
{
    comentario::Archivar($varEmail,$varTitulo,$varComentario);
}


?>

