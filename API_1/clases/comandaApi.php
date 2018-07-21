<?php

require_once 'AccesoDatos.php';
require_once 'comanda.php';

class comandaApi extends comanda
{    

    public function CargarComanda($request, $response,$args){
    
        $com = new comanda();
        $vector = $request->getParsedBody();
        
        $vHora = new DateTime();      
       
        $com->id_comanda = $vector['id_comanda'];
        $com->id_mesa = $vector['id_mesa'];
        $com->id_mozo = $vector['id_mozo'];
        $com->id_estado_pedido = 1;                
        $com->total = $vector['total'];   
        $com->fecha_alta = date_format($vHora,"Y/m/d H:i:s");
        $vHoraEstipulada = $vHora;
        date_add($vHoraEstipulada, date_interval_create_from_date_string('30 minutes'));
        $com->fecha_estipulada = date_format($vHoraEstipulada,"Y/m/d H:i:s");
        
        if($vector['fecha_entrega'] = ""){
            $com->fecha_entrega = '0000-00-00';
        }            
        else{
            $com->fecha_entrega = $vector['fecha_entrega'];
        }       


        $destino= './Fotos/';
        $archivos = $request->getUploadedFiles();
        $nombreAnterior=$archivos['foto']->getClientFilename();
        $nombre = $com->id_comanda.$com->id_mesa;
        $extension = explode(".",$nombreAnterior);
        $extension = array_reverse($extension);

        $archivos['foto']->moveTo($destino.$nombre.".".$extension[0]);
        $camino = $destino.$nombre.".".$extension[0];
        
        return $com->Insertar();   
    }

    public function TraerUnaComanda($request, $response, $args) {   
        
        $objDelaRespuesta = new stdclass();  
        $objDelaRespuesta->itsOK = false;              
       
        $vector = $request->getParsedBody();
        $vId = $vector['id_comanda'];         

        $var = comanda::TraerUna($vId);      
           
        if($var != null){            
             
            $objDelaRespuesta->laComanda = new comanda();
            $objDelaRespuesta->itsOK = true;
            $objDelaRespuesta->laComanda = $var[0]; 
            $objDelaRespuesta->token = AutentificadorJWT::CrearToken($var[0]);            
        }
        $newResponse = $response->withJson($objDelaRespuesta, 200);        
        return $newResponse;
    }

    public function TraerComandas($request, $response, $args) {
        
        $Comandas = comanda::TraerTodasLasComandas();        
        $newResponse = $response->withJson($Comandas, 200);  
        return $newResponse;
    }  
    
     

    public function ModificarComanda($request, $response,$args)
    {
        $emp = new comanda();
        $vector = $request->getParams('id_comanda','id_mesa','id_mozo','id_estado_pedido','fecha_estipulada','fecha_entrega','total');
       
        $com->id_comanda = $vector['id_comanda'];
        $com->id_mesa = $vector['id_mesa'];
        $com->id_mozo = $vector['id_mozo'];
        $com->fecha_entrega = $vector['fecha_alta'];
        $com->id_estado_pedido = $vector['id_estado_pedido'];        
        $com->fecha_estipulada = $vector['fecha_estipulada'];
        $com->fecha_entrega = $vector['fecha_entrega'];
        $com->total = $vector['total'];   
        
	   	$resultado =$emp->ModificarUna();
	  	$responseObj= new stdclass();
	    $responseObj->resultado=$resultado;
        $responseObj->tarea="modificar";
	    return $response->withJson($responseObj, 200);	
    }


    public function BorrarComanda($request, $response, $args) {
        
            $com = new comanda();
            $vId = $args['id'];
        
            $var = Comanda::TraerUna($vId);
            
            if($var != null){
                   
                $com = $var[0];       
               
                $cantidadDeBorrados= $com->BorrarUna(); 
    
                $objDelaRespuesta= new stdclass();
                $objDelaRespuesta->cantidad=$cantidadDeBorrados;
    
                if($cantidadDeBorrados == 1)$objDelaRespuesta->resultado="Se borró un elemento!!!";
                
                elseif($cantidadDeBorrados > 1) $objDelaRespuesta->resultado="Se borró más de un elemento!!!";
                
                elseif($cantidadDeBorrados < 1) $objDelaRespuesta->resultado="No se borró ningún elemento!!!";
                
                $newResponse = $response->withJson($objDelaRespuesta, 200);  
                return $newResponse; 
            }
            else{                
                return "No existe ninguna comanda con ese código";
            }
        }

            // public function MarcaDeAgua($request, $response,$args){

    //     $estampa = imagecreatefrompng(dirname(__FILE__).'/estampa.png');
    //     $im = imagecreatefrompng(dirname(__FILE__).'/foto.png');

    //     // Establecer los márgenes para la estampa y obtener el alto/ancho de la imagen de la estampa
    //     $margen_dcho = 10;
    //     $margen_inf = 10;
    //     $sx = imagesx($estampa);
    //     $sy = imagesy($estampa);

    //     // Copiar la imagen de la estampa sobre nuestra foto usando los índices de márgen y el
    //     // ancho de la foto para calcular la posición de la estampa. 
    //     imagecopy($im, $estampa, imagesx($im) - $sx - $margen_dcho, imagesy($im) - $sy - $margen_inf, 0, 0, imagesx($estampa), imagesy($estampa));

    //   // Imprimir y liberar memoria
    //     header('Content-type: image/png');
    //     imagepng($im);
    //     imagedestroy($im);


    // }


}



?>