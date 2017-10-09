<?php

include_once 'usuario.php';
include_once 'comentario.php';

$varEmail = $_POST['email'];
//$varComentario = $_POST['comentario'];

$usuario = usuario::VerificaMailComentario($varEmail);

if($usuario != ""){

    $archivo = fopen('comentarioConImagen.txt',"r");        
    $miContenido  = "";

    $miContenido  = $miContenido.'<html><head><meta charset="UTF-8"><meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge"><link rel="stylesheet" href="CSS/estilo.css">
    </head><body><h3>Perfil de usuario</h3>';

    $cuerpo = "";

    while(!feof($archivo)){

        $aux = fgets($archivo);
        $cadena = explode("-",$aux);
        $datosUsuarios = explode("-",$usuario);

        if($cadena[0] == "")continue; 

        else if($cadena[0] == $varEmail){

            $cuerpo = $cuerpo.'<h3>Mail: '.$cadena[0].'</h3>';
            $cuerpo = $cuerpo.'<h3>Edad: '.$datosUsuarios[3].'</h3>';
            $cuerpo = $cuerpo.'<h3>Comentario: '.$cadena[1].'</h3>';
            $cuerpo = $cuerpo.'<img src= '.$cadena[2].'height="200" width="200"><br>'; 
        }            
    }

    $miContenido = $miContenido.'<div>'.$cuerpo.'</div></body></html>';
    fclose($archivo); 

    comentario::ArmarHTML("Listado",$miContenido);
}
else{
    echo 'El usuario no fue cargado';
}

    



/* (2pt.) TablaComentarios.php, puede recibir datos del comentario como el usuario, 
el titulo o nada para hacer una busqueda,
 y retornará una tabla con: 
(la imagen del comentario, el titulo , la edad del usuario y el nombre ) */


?>

