<?php

require_once 'AccesoDatos.php';
require_once 'TableRows.php';
require_once 'mesa.php';

class mesaApi extends mesa
{   
    public function CargarMesa($request,$response,$args){
              

        $miMesa = new mesa();
        $ArrayDeParametros = $request->getParsedBody();                     
        $miMesa->id_mesa = $ArrayDeParametros['id_mesa'];
        $miMesa->id_sector = $ArrayDeParametros['id_sector'];
        $miMesa->id_estado_mesa = $ArrayDeParametros['id_estado_mesa']; 
        
        try{

            $var = mesa::TraerUno($miMesa->id_mesa);             
        }    
        catch(Exception $e) {
            
            return $e->getMessage();

        }        
        if($var == null){        
    
            return $miMesa->Insertar();
        }
        else{

            return $response->withJson(false, 200);            
        } 
    }
    
    public function TraerMesa($request, $response, $args) {
        
        $vector  = $request->getParams('id_mesa');       
        $vId = $vector['id_mesa'];         
        
        $laMesa = mesa::TraerUno($vId);
        $newResponse = $response->withJson($laMesa, 200);  
        return $newResponse;
    }

    public function TraerMesas($request, $response, $args) {
        
        $Empleados = mesa::TraerTodos();        
        $newResponse = $response->withJson($Empleados, 200);  
        return $newResponse;
    }  


    public function ModificarMesa($request, $response,$args)
    {
        $vMesa = new mesa();
        $vector  = $request->getParams('id_sector','id_estado_mesa','id_mesa');
      
        $vMesa->id_mesa = $vector['id_mesa'];
        $vMesa->id_sector = $vector['id_sector'];
        $vMesa->id_estado_mesa = $vector['id_estado_mesa'];
       
	   	$resultado =$vMesa->Modificar();
	  	$responseObj= new stdclass();
	    $responseObj->resultado=$resultado;
        $responseObj->tarea="modificar";
	    return $response->withJson($responseObj, 200);	
    }


    public function BorraMesa($request, $response, $args) {
    
        $vMesa = new mesa();
        $vId = $args['id_mesa'];
        $var = mesa::TraerUno($vId);
        
        if($var != null){
               
            $vMesa = $var[0];       
           
            $cantidadDeBorrados=$vMesa->BorrarUno(); 

            $objDelaRespuesta= new stdclass();
            $objDelaRespuesta->cantidad=$cantidadDeBorrados;

            if($cantidadDeBorrados == 1)$objDelaRespuesta->resultado="Se borró un elemento!!!";
            
            elseif($cantidadDeBorrados > 1) $objDelaRespuesta->resultado="Se borró más de un elemento!!!";
            
            elseif($cantidadDeBorrados < 1) $objDelaRespuesta->resultado="No se borró ningún elemento!!!";
            
            $newResponse = $response->withJson($objDelaRespuesta, 200);  
            return $newResponse; 
        }
        else{

            return "No existe ninguna mesa con ese código";
        }
    }


    // public function RetirarAuto($request, $response, $args) {
                  
    //         $vector  = $request->getParams('patente');                   
    //         $vPatente = $vector['patente'];
    //         $objDelaRespuesta = new stdclass();
    //         $objDelaRespuesta->itsOk = false;
    //         $newResponse = $response->withJson($objDelaRespuesta, 200);
            
    //         $var = auto::TraerUno($vPatente);             

    //         if($var != null){
                       
                
    //             $vAuto = new auto(); 
    //             $vAuto = $var[0];
                
    //             $vHora = date('H:i:s');
    //             $ingresoStr = explode(":",$vAuto->hora);
    //             $salidaStr = explode(":",$vHora);
                
    //             $ingreso = (int)$ingresoStr[0];
    //             $egreso = (int)$salidaStr[0];

    //             if((int)$ingresoStr[1] < (int)$salidaStr[1]){ $egreso +=1;}

    //             $objDelaRespuesta->auto = $vAuto;
    //             $objDelaRespuesta->costo = ($egreso - $ingreso)*10;

    //           //  if(($vAuto->BorrarUno()) > 0){
    //                 $objDelaRespuesta->itsOk = true;
    //            // }; 
           
    //         $newResponse = $response->withJson($objDelaRespuesta, 200);  
    //      //   return $newResponse; 
    //         }            
    //         return $newResponse; 
            
    //     }

}


?>