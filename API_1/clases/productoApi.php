<?php

require_once 'AccesoDatos.php';
require_once 'TableRows.php';
require_once 'producto.php';

class productoApi extends producto
{   
    public function CargarProducto($request,$response,$args){
        
        $miProducto = new producto();
        $ArrayDeParametros = $request->getParsedBody(); 

        $miProducto->id_producto = $ArrayDeParametros['id_producto'];
        $miProducto->nombre_producto = $ArrayDeParametros['nombre_producto'];
        $miProducto->descripcion = $ArrayDeParametros['descripcion']; 
        $miProducto->id_cocina = $ArrayDeParametros['id_cocina']; 
        $miProducto->precio = $ArrayDeParametros['precio']; 
        
        $var = producto::TraerUno($miProducto->nombre_producto);             
        
        if($var == null){               
            return $miProducto->Insertar();
        }
        else{
            return $response->withJson(false, 200);            
        } 
    }
    
    public function TraerProductos($request, $response, $args) {
     //  auto::ImprimirListado();
        $Productos=producto::TraerTodos();        
        $newResponse = $response->withJson($Productos, 200); 
        return $newResponse;
    }

    public function TraerUnProducto($request, $response, $args) {
        
        $vector  = $request->getParams('id_producto');       
        $vId = $vector['id_producto'];         
        
        $elProducto = auto::TraerUno($vId);
        $newResponse = $response->withJson($elProducto, 200);  
        return $newResponse;
    }

    public function ModificarProducto($request, $response, $args)
    {
        $vProducto = new producto();
        $vid = $args['id_producto'];

        $vector  = $request->getParams('nombre_producto','descripcion','id_cocina','precio');
        
        $vProducto->patente = $vPatente;
        $vProducto->nombre_producto = $vector['nombre_producto'];
        $vProducto->descripcion = $vector['descripcion'];
        $vProducto->id_cocina = $vector['id_cocina'];
        $vProducto->precio = $vector['precio'];
            

        //____________________//
	   	$resultado =$vProducto->Modificar();
	  	$responseObj= new stdclass();
	    $responseObj->resultado=$resultado;
        $responseObj->tarea="modificar";
	    return $response->withJson($responseObj, 200);	
    }
   
    public function BorrarProducto($request, $response, $args) {
    
        $vProducto = new producto();
        $vId = $args['id_producto'];
        $var = pructo::TraerUno($vId);
        
        if($var != null){
               
            $vProducto = $var[0];       
            $borrar = $vProducto->foto;  
            if(copy($borrar,"./Eliminados/".$vProducto->nombre_producto.'.jpg'))  unlink($borrar);
            
            $cantidadDeBorrados=$vProducto->BorrarUno(); 

            $objDelaRespuesta= new stdclass();
            $objDelaRespuesta->cantidad=$cantidadDeBorrados;

            if($cantidadDeBorrados == 1)$objDelaRespuesta->resultado="Se borró un elemento!!!";
            
            elseif($cantidadDeBorrados > 1) $objDelaRespuesta->resultado="Se borró más de un elemento!!!";
            
            elseif($cantidadDeBorrados < 1) $objDelaRespuesta->resultado="No se borró ningún elemento!!!";
            
            $newResponse = $response->withJson($objDelaRespuesta, 200);  
            return $newResponse; 
        }
        else{

            return "No existe ningún producto con ese código de identificación";
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