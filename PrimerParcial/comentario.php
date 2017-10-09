<?php


class comentario
{
    public $_mail;

    public $_comentario;

    public $_pathPhoto;
    
    function __constructor(){}

    public function setPathPhoto($path){
        $this->_pathPhoto = $path;
    }

    public function getPathPhoto(){
        return $this->_pathPhoto;
    }

    public function setComntario($comentario){
        $this->_comentario = $comentario;
    }

    public function getComentario(){
        return $this->_comentario;
    }

    public function setMail($mail){
        $this->_mail = $mail;
    }

    public function getMail(){
        return $this->_mail;
    }

    public static function Archivar($usuario,$titulo,$comentario)
    {   
        $archivo = fopen('comentario.txt',"a");

        if((fwrite($archivo,$usuario.'-'.$titulo.'-'.$comentario."\r\n")) != false){
            echo "Se guardó el comentario";
        }
        else{
            echo "No se pudo guardar el comentario";
        }
        fclose($archivo);
    }

    public static function MoverABorrados($auxMail)
    {
        //lau@mail-./ImagenesDeComentario/milton.jpg-milton

        $archivo = fopen('comentarioConImagen.txt',"r");        
        $retorno = 0;

        $hora = date("h_i_sa");
        $camino = "./Del/".$hora.".jpg";

        while(!feof($archivo)){
    
            $aux = fgets($archivo);
            $cadena = explode("-",$aux);
            if($cadena[0] == "")continue; 
            
            else if($cadena[0] == $auxMail){
            
                $file = $cadena[1];
                rename($file,$camino);           
            
                $retorno = 1; 
                break;          
            }                   
        }
        fclose($archivo);        
        return $retorno;
    }


    public static function ModificarListado($auxMail)
    {
        $archivo = fopen('comentarioConImagen.txt',"r");   
        $temporal = fopen('Archivos/ComentariosTemporales.txt',"w");
        $retorno = 0;

        while(!feof($archivo))
        {
            $aux = fgets($archivo);
            if($aux == "")continue; 
            fwrite($temporal,$aux."\r\n");
        }
        fclose($archivo);
        fclose($temporal);

        $temporal = fopen('Archivos/ComentariosTemporales.txt',"r");
        $archivo = fopen('comentarioConImagen.txt',"w");
        $eliminados = fopen('Archivos/ComentariosEliminados.txt','a');

        $hora = date("h_i_sa");
        $camino = "./Del/".$hora.".jpg";
       
        while(!feof($temporal))
        {
            $aux = fgets($temporal);
            if($aux == "")continue; 

            $cadena = explode("-",$aux);            
            
            if(($cadena[0] == $auxMail))
            {
                $file = $cadena[1];
                rename($file,$camino); 
                fwrite($eliminados,$camino."\r\n");
                $retorno = 1;
            }
            else
            {
                fwrite($archivo,$aux."\r\n");
            }
        }    

        fclose($archivo);
        fclose($temporal);  
        fclose($eliminados);
        return $retorno;    
    }












    public static function ArchivarConImagen($mail,$path,$comentario)
    {   
        $archivo = fopen('comentarioConImagen.txt',"a");
        fwrite($archivo,$mail.'-'.$path.'-'.$comentario."\r\n");        
        fclose($archivo);
    }


    public static function ArmarHTML($pagina,$contenido)
    {   
        $direccion = $pagina.'.html';

        $archivo = fopen($direccion,"w");
        $itsOK = fwrite($archivo,$contenido);  
        
        if($itsOK){
            print("<a href=$direccion>Listado de Usuarios</a>");
            fclose($archivo);
        }
        else{
            print("Error al crear la página");
            fclose($archivo);
        }            
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

