<?php

include_once 'usuario.php';
include_once 'comentario.php';

$varEmail = $_POST['email'];
$varComentario = $_POST['titulo'];


if(usuario::VerificaMail($varEmail)){    

    if($_FILES['archivo']['type'] == "image/png" || $_FILES['archivo']['type'] == "image/jpeg"){
                
        $destino = "./ImagenesDeComentario/".$varComentario.'.jpg'; 

        move_uploaded_file($_FILES['archivo']['tmp_name'], $destino);
        comentario::ArchivarConImagen($varEmail,$destino,$varComentario);
        echo '<h4>Se guardó la imagen: '.$_FILES['archivo']['name'].'</h4>';        
    }
    else
    {
        echo 'La terminación del archivo es inválida';
    } 
}
else{
    echo 'Email no valido';
}
    




?>



