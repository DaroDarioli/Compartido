<?php
#include_once 'persona.php';
include_once 'auto.php';

class auto
{
    private $_color;

    private $_precio;

    private $_marca;

    private $_fecha;

    public function __construct()    
    {
       $argumentos = func_get_args(); 
    
       switch(sizeof(func_get_args()))      
       {
        case 0:
            break; 
        case 1:
            $this->_color = $argumentos[0]; 
            break;              
        case 2:
            $this->_color = $argumentos[0]; 
            $this->_precio= $argumentos[1]; 
            break;   
        case 3:
            $this->_color = $argumentos[0]; 
            $this->_precio= $argumentos[1]; 
            $this->_marca= $argumentos[2]; 
            break;          
       }
    }


    function Mostrar_Auto()
    {
        echo '<br>Color'.$this->_color.' Precio: '.$this->_precio;
    }

    function Mostrar_Auto_Con_Marca()
    {
        $this->Mostrar_Auto();
        echo 'Marca: '.$this->_marca;
    }

}


?>