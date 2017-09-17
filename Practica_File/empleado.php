<?php

include_once "persona.php";

class empleado extends Persona
{
    private $_legajo;

    private $_pathPhoto;

    private $_sueldo;


    public function __construct($nombre, $apellido,$dni,$sexo,$legajo,$sueldo)
    {
        $this->_legajo = $legajo;
        $this->_sueldo = $sueldo;        
        parent::__construct($nombre,$apellido,$dni,$sexo);
    }

    public function getLegajo()
    {
        return $this->_legajo;
    }

    public function getSueldo()
    {
        return $this->_sueldo;
    }

    public function setPathToPhoto($path)
    {
        $this->_pathPhoto = $path;
    }

    public function getPathPhoto()
    {
        return $this->_pathPhoto;
    }
   

    function MostrarEmpleado()
    {
        return 'Apellido: '.$this->getApellido().' Imagen: '.$this->getPathPhoto();
    }

    static function Archivar($empleado)
    {   
        $archivo = fopen('Archivos/EmpleadosImagen.txt',"a");
        fwrite($archivo,$empleado->MostrarEmpleado()."\r\n");         
        fclose($archivo);
    }


}



?>