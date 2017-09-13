<?php

class Estacionamiento
{
    #public $_autos = array();  
    
    static function Guardar($auto)
    {              
        $ahora = date("Y-m-d H:i:s");
        echo '<br>Estoy guardando patente:'.$auto->_patente;
        
        $archivo = fopen('Archivos/Estacionados.txt',"a");
        fwrite($archivo,$auto->_patente." - ".$ahora."\r\n");         
        fclose($archivo);
    }

    static function Sacar($auto)
    {
        echo '<br>Estoy Sacando autos<br>';        
        $archivo = fopen('Archivos/Estacionados.txt',"r");       
            #HAY QUE ELIMINAR EL AUTO!!   
        while(!feof($archivo ))
        {
            #echo fgets($archivo).'<br>'; //-->ok  
            $aux = fgets($archivo);
            $cadena = explode("-",$aux);
            echo $cadena[0].'<br>';          
            #echo $cadena[1].'<br>';
        }
        fclose($archivo);      
     
    }

    #testeo 

    static function Testeo($cadena)
    {
        echo $cadena.' Desde funcion Testeo';
    }

}

?>