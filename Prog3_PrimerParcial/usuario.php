<?php

include_once 'comentario.php';

class usuario
{
    public $_nombre;

    public $_edad;

    public $_email;

    public $_clave;

    public function __constructor() {}

    public function setNombre($nombre)
    {
        $this->_nombre = $nombre;
    }

    public function getNombre()
    {
        return $this->_nombre;
    }

    public function setAge($age)
    {
        $this->_edad = $age;
    }

    public function getAge()
    {
        return $this->_edad;
    }

    public function setMail($email)
    {
        $this->_email = $email;
    }

    public function getEmail()
    {
        return $this->_email;
    }

    public function setClave($clave)
    {
        $this->_clave = $clave;
    }

    public function getClave()
    {
        return $this->_clave;
    }

    public function Archivar($usuario)
    {   
        $archivo = fopen('usuarios.txt',"a");
        fwrite($archivo,$usuario->ToString());         
        fclose($archivo);
    }

    public function ToString()
    {
        return $this->getEmail().'-'.$this->getNombre().'-'.$this->getAge().'-'.$this->getClave()."\r\n";
     
    }

    public static function VerificaUsuario($mail,$clave)
    {
        $archivo = fopen('usuarios.txt',"r");        
        $retorno =  'Usuario inexistente';

        while(!feof($archivo))
        {
            $aux = fgets($archivo);
            $cadena = explode("-",$aux);
            if($cadena[0] == "")continue; 

            $cantidad = strlen($cadena[3]);

            $auxiliar = substr($cadena[3],1,$cantidad-2);
            var_dump($auxiliar);
            var_dump($clave);
            if($cadena[0] == $mail && $cadena[3] == $clave)
            {
                $retorno = 'Bienvenido!'; 
                break;          
            }

            else if($cadena[0] == $mail && $cadena[3] != $clave)
            {
                $retorno = "No se reconoce la clave";
                break;
            }
                   
        }
        fclose($archivo);        
        return $retorno;
    }


    public static function VerificaMail($mail)
    {
        $archivo = fopen('usuarios.txt',"r");        
        $retorno = 0;

        while(!feof($archivo))
        {
            $aux = fgets($archivo);
            $cadena = explode("-",$aux);
            if($cadena[0] == "")continue; 
           
            if($cadena[0] == $mail)
            {
                $retorno = 1; 
                break;          
            }
                   
        }
        fclose($archivo);        
        return $retorno;
    }


    public static function VerificaMailComentario($mail)
    {
        $archivo = fopen('usuarios.txt',"r");        
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

