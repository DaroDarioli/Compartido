<?php

require_once 'AccesoDatos.php';
require_once 'pedido.php';

class pedidoApi extends pedido
{    
       
    public function CargarPedido($request, $response,$args){
    
        $vPedido = new pedido();
        $vector = $request->getParsedBody();
                       
        $vPedido->id_comanda = $vector['id_comanda'];
        $vPedido->id_producto = $vector['id_producto'];      
        $vPedido->estado_pedido = "1";

        if (isset($_POST['cantidad_producto']) && !empty($_POST['cantidad_producto'])) 
        {
            $vPedido->cantidad_producto = $vector['cantidad_producto'];   
        }else{  
            $vPedido->cantidad_producto = 100;
        }    

        return $vPedido->Insertar();         
    }
     
    public function TraerPendientes($request, $response, $args) {
        
        $Pedidos = pedido::TraerTodosLosPedidosPendientes();        
        $newResponse = $response->withJson($Pedidos, 200);  
        return $newResponse;
    }  
    

    public function TraerTodosLosPendientesSector($request, $response, $args) {
        
        $vector = $request->getParams('id_cocina');
        $vId = $vector['id_cocina'];   
       
        $Pedidos = pedido::TraerTodosLosPedidosPendientesSector($vId);        
        $newResponse = $response->withJson($Pedidos, 200);  
        return $newResponse;
    }  


    // public function TraerUnaComanda($request, $response, $args) {   
        
    //     $objDelaRespuesta = new stdclass();  
    //     $objDelaRespuesta->itsOK = false;              
       
    //     $vector = $request->getParsedBody();
    //     $vId = $vector['id_comanda'];         

    //     $var = comanda::TraerUna($vId);      
           
    //     if($var != null){            
             
    //         $objDelaRespuesta->laComanda = new comanda();
    //         $objDelaRespuesta->itsOK = true;
    //         $objDelaRespuesta->laComanda = $var[0]; 
    //         $objDelaRespuesta->token = AutentificadorJWT::CrearToken($var[0]);            
    //     }
    //     $newResponse = $response->withJson($objDelaRespuesta, 200);        
    //     return $newResponse;
    // }

     

    // public function ModificarComanda($request, $response,$args)
    // {
    //     $emp = new comanda();
    //     $vector = $request->getParams('id_comanda','id_mesa','id_mozo','id_estado_pedido','fecha_estipulada','fecha_entrega','total');
       
    //     $com->id_comanda = $vector['id_comanda'];
    //     $com->id_mesa = $vector['id_mesa'];
    //     $com->id_mozo = $vector['id_mozo'];
    //     $com->fecha_entrega = $vector['fecha_alta'];
    //     $com->id_estado_pedido = $vector['id_estado_pedido'];        
    //     $com->fecha_estipulada = $vector['fecha_estipulada'];
    //     $com->fecha_entrega = $vector['fecha_entrega'];
    //     $com->total = $vector['total'];   
        
	//    	$resultado =$emp->ModificarUna();
	//   	$responseObj= new stdclass();
	//     $responseObj->resultado=$resultado;
    //     $responseObj->tarea="modificar";
	//     return $response->withJson($responseObj, 200);	
    // }


    // public function BorrarComanda($request, $response, $args) {
        
    //         $com = new comanda();
    //         $vId = $args['id'];
        
    //         $var = Comanda::TraerUna($vId);
            
    //         if($var != null){
                   
    //             $com = $var[0];       
               
    //             $cantidadDeBorrados= $com->BorrarUna(); 
    
    //             $objDelaRespuesta= new stdclass();
    //             $objDelaRespuesta->cantidad=$cantidadDeBorrados;
    
    //             if($cantidadDeBorrados == 1)$objDelaRespuesta->resultado="Se borró un elemento!!!";
                
    //             elseif($cantidadDeBorrados > 1) $objDelaRespuesta->resultado="Se borró más de un elemento!!!";
                
    //             elseif($cantidadDeBorrados < 1) $objDelaRespuesta->resultado="No se borró ningún elemento!!!";
                
    //             $newResponse = $response->withJson($objDelaRespuesta, 200);  
    //             return $newResponse; 
    //         }
    //         else{                
    //             return "No existe ninguna comanda con ese código";
    //         }
    //     }


}



?>