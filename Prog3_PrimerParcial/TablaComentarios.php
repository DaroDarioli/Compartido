<?php

include_once 'usuario.php';
include_once 'comentario.php';

$varEmail = $_POST['email'];
$varComentario = $_POST['comentario'];

$usuario = usuario::VerificaMailComentario($varEmail);

    $archivo = fopen('comentarioConImagen.txt',"r");        
    
    
    echo '<html><head><meta charset="UTF-8"><meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge"><link rel="stylesheet" href="CSS/estilo.css">
    </head><body><h3>Perfil de usuario</h3>';
    
    
    while(!feof($archivo))
    {
        $aux = fgets($archivo);
        $cadena = explode("-",$aux);
        if($cadena[0] == "")continue; 
    
        else if($cadena[0] == $varEmail)
        {        
            echo '<h3>Mail'.$cadena[0].'</div>';
            echo '<h3>Comentario'.$cadena[1].'</div>';
            echo '<img src= '.$cadena[2].'height="200" width="200"><br>'; 
        }
         
        
               
    }
    echo '</body></html>';
    fclose($archivo);     
    





/* (2pt.) TablaComentarios.php, puede recibir datos del comentario como el usuario, 
el titulo o nada para hacer una busqueda,
 y retornará una tabla con: 
(la imagen del comentario, el titulo , la edad del usuario y el nombre ) */


?>

