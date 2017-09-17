<?php


class Persona
{
    private $_nombre;

    private $_apellido;

    private $_dni;

    private $_sexo;

    public function __construct($nombre,$apellido,$dni,$sexo)
    {
        $this->_nombre = $nombre;
        $this->_apellido = $apellido;
        $this->_dni = $dni;
        $this->_sexo = $sexo;

    }


    public function getApellido()
    {
        return $this->_apellido;
    }

    public function getDNI()
    {
        return $this->_dni;
    }

    public function getNombre()
    {
        return $this->_nombre;
    }

    public function Hablar($idioma)
    {

    }

    public function ToString()
    {
        return 'Apellido: '.$this->_apellido.' Nombre: '.$this->_nombre.' DNI: '.$this->_dni.' Sexo: '.$this->_sexo;
    }

   

}



?>