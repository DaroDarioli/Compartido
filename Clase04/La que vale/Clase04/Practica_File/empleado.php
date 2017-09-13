<?php


class empleado
{
    public $_nombre;

    public $_apellido;

    public $_dni;

    public function __construct($nombre,$apellido,$dni)
    {
        $this->_nombre = $nombre;
        $this->_apellido = $apellido;
        $this->_dni = $dni;

    }

    function ToString()
    {
        return 'Apellido: '.$this->_apellido.' Nombre: '.$this->_nombre.' DNI: '.$this->_dni;
    }

    static function Archivar($empleado)
    {          
        echo '<br>Estoy archivando empleado'; 
        $archivo = fopen('Archivos/Empleados.txt',"a");
        fwrite($archivo,$empleado->ToString()."\r\n");         
        fclose($archivo);
    }


}



?>