<?php

include_once 'comentario.php';

class usuario
{
public $_nombre;

public $_edad;

public $_email;

public $_clave;

public function __constructor(){
   
      
}

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
    if((fwrite($archivo,$usuario->ToString())) != false){
        echo "Se archivó el elemento";
    }         
    else{
        echo "No se pudo archivar el elemento";
    }
    fclose($archivo);
}

public function ToString()
{
    return $this->getEmail().'-'.$this->getClave().'-'.$this->getNombre().'-'.$this->getAge()."\r\n";    
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

        else if($cadena[0] == $mail && $cadena[1] == $clave)
        {
            $retorno = 'Bienvenido!'; 
            break;          
        }
        else if($cadena[0] == $mail && $cadena[1] != $clave)
        {
            $retorno = "No se reconoce la clave";
        }                   
    }
    fclose($archivo);        
    return $retorno;
}


public static function VerificaMail($mail){

    $archivo = fopen('usuarios.txt',"r");        
    $retorno = 0;

    while(!feof($archivo)){

        $aux = fgets($archivo);
        $cadena = explode("-",$aux);
        if($cadena[0] == "")
            continue; 
        
        else if($cadena[0] == $mail){
            $retorno = 1; 
            break;          
        }                   
    }
    fclose($archivo);        
    return $retorno;
}

public static function MoficarLista($varUsuario)
{
    $acumulador = 0;
    $lista = array(self::TraerListaUsuarios());
   
    foreach($lista as $K){

        $aux = $K->ToString();
        $cadena = explode('-',$aux);
        if($cadena[2] == $varUsuario->getNombre()){
            array_splice($lista,$acumulador,1,$varUsuario);
        }
        $acumulador++;
    }
    //var_dump($lista);
}


public static function TraerListaUsuarios()
{
    $archivo = fopen('usuarios.txt',"r");      
    
    $listaUsuarios = array();

    while(!feof($archivo))
    {
        $aux = fgets($archivo);
        $cadena = explode("-",$aux);

        $cadena[0] = trim($cadena[0]);
        if($cadena[0] != ""){

            $auxUsuario = new Usuario();
            $auxUsuario->setMail($cadena[0]);
            $auxUsuario->setClave($cadena[1]);
            $auxUsuario->setNombre($cadena[2]);
            $auxUsuario->setAge($cadena[3]);               
            array_push($listaUsuarios,$auxUsuario);				
        }        
                
    }
    fclose($archivo); 
    // var_dump($listaUsuarios);       
    return $listaUsuarios;
}

/*
public static function TraerTodosLosUsuarios()
{

    $ListaDeUsuariosLeidos = array();

    //leo todos los productos del archivo
    $archivo=fopen("archivos/usuario.txt", "r");
    
    while(!feof($archivo))
    {
        $archAux = fgets($archivo);
        $usuarios = explode("-", $archAux);
        //http://www.w3schools.com/php/func_string_explode.asp
        $usuarios[0] = trim($usuarios[0]);
        if($usuarios[0] != ""){
            $ListaDeUsuariosLeidos[] = new Usuario($usuarios[0], $usuarios[1],$usuarios[2],$usuarios[3]);
        }
    }
    fclose($archivo);
    
    return $ListaDeUsuariosLeidos;
    
}
}






*/


public static function VerificaMailComentario($mail)
{
    $archivo = fopen('usuarios.txt',"r");        
    $retorno = "";

    while(!feof($archivo))
    {
        $aux = fgets($archivo);
        $cadena = explode("-",$aux);
        if($cadena[0] == "")continue; 
        
        if($cadena[0] == $mail){
            $retorno = $aux; 
            break;          
        }                   
    }
    fclose($archivo);        
    return $retorno;
}

}

?>

