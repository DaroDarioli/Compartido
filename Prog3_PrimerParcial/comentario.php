<?php


class comentario
{
 
    public static function Archivar($usuario,$comentario)
    {   
        $archivo = fopen('comentario.txt',"a");
        fwrite($archivo,$usuario.'-'.$comentario."\r\n");        
        fclose($archivo);
    }

    public static function ArchivarConImagen($mail,$comentario,$path)
    {   
        $archivo = fopen('comentarioConImagen.txt',"a");
        fwrite($archivo,$mail.'-'.$comentario.'-'.$path."\r\n");        
        fclose($archivo);
    }


    public static function VerificaMail($mail)
    {
        $archivo = fopen('comentarioConImagen.txt',"r");        
        $retorno = "";

        while(!feof($archivo))
        {
            $aux = fgets($archivo);
            $cadena = explode("-",$aux);
            if($cadena[0] == "")continue; 
           
            if($cadena[0] == $mail)
            {
                $retorno = $aux; 
                break;          
            }
                   
        }
        fclose($archivo);        
        return $retorno;
    }
    
}
?>

