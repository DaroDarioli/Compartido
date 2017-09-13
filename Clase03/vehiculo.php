<?php

class Vehiculo
{
    public $_patente;

    function __construct($patente)
    {
        $this->_patente = $patente;
    }

    function ToString()
    {
        return $this->_patente;
    }

}


?>