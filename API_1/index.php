<?php
use \Psr\Http\Message\ServerRequestInterface as Request;
use \Psr\Http\Message\ResponseInterface as Response;

require_once __DIR__ .'/../composer/vendor/autoload.php';

require_once './clases/AccesoDatos.php';
require_once './clases/producto.php';
require_once './clases/productoApi.php';
require_once './clases/empleado.php';
require_once './clases/empleadoApi.php';
require_once './clases/cliente.php';
require_once './clases/clienteApi.php';
require_once './clases/mesa.php';
require_once './clases/mesaApi.php';
require_once './clases/comanda.php';
require_once './clases/comandaApi.php';
require_once './clases/pedidoApi.php';
require_once './clases/pedido.php';

date_default_timezone_set('America/Argentina/Buenos_Aires');



require_once './clases/AutentificadorMW.php';
require_once './clases/AutentificadorJWT.php';
require_once './clases/MWparaCORS.php';

$config['displayErrorDetails'] = true;
$config['addContentLengthHeader'] = false;

$app = new \Slim\App(["settings" => $config]);

/*  
-validar todas las foreign keys
-crear alpha para id comanda
-agregar tiempo estipulado en milisegundos
-agregar foto y marca de agua
-que las mesas no tengan dos comandas abiertas


*/




$app->group('/comanda', function () {

   
   //===============================
    $this->get('/marcadeagua',\comandaApi::class . ':MarcaDeAgua'); 
   //===============================
   
    $this->post('/alta',\comandaApi::class . ':CargarComanda'); 

    $this->post('/consulta',\comandaApi::class . ':TraerUnaComanda');

    $this->get('/listado',\comandaApi::class . ':TraerComandas'); 

    $this->put('/modificar',\comandaApi::class . ':ModificarComanda'); 

    $this->delete('/borrar/{id}',\comandaApi::class . ':BorrarComanda')->add(\MWparaCORS::class . ':HabilitarCORSTodos'); 
            
});

$app->group('/pedido', function () {
     
    
     $this->post('/alta',\pedidoApi::class . ':CargarPedido'); 
 
     $this->post('/consulta',\pedidoApi::class . ':TraerUnPedido');
 
     $this->get('/listadoPendientes',\pedidoApi::class . ':TraerPendientes'); 

     $this->get('/listadoPendientesSector',\pedidoApi::class . ':TraerTodosLosPendientesSector');
 
     $this->put('/modificar',\pedidoApi::class . ':ModificarPedido'); 
 
             
 });
 

$app->group('/empleado', function () {
  
    //    $this->get('/login',\empleadoApi::class . ':TraerEmpleados')->add(\MWparaCORS::class . ':HabilitarCORSTodos'); 
    
    $this->post('/alta',\empleadoApi::class . ':CargarEmpleado'); 
    
    $this->post('/login',\empleadoApi::class . ':TraerUnEmpleado');

    $this->get('/listado',\empleadoApi::class . ':TraerEmpleados'); 
    
    $this->put('/modificar',\empleadoApi::class . ':ModificarEmpleado'); 
    
    $this->delete('/login/{id}',\empleadoApi::class . ':BorrarEmpleado')->add(\MWparaCORS::class . ':HabilitarCORSTodos'); 
     
         
})->add(\AutentificadorMW::class . ':VerificarAcceso')->add(\MWparaCORS::class . ':HabilitarCORSTodos');


$app->group('/producto', function () {

    //    $this->get('/login',\empleadoApi::class . ':TraerEmpleados')->add(\MWparaCORS::class . ':HabilitarCORSTodos'); 
    
        $this->post('/cargar',\productoApi::class . ':CargarProducto');

    //    $this->get('/listado',\empleadoApi::class . ':TraerEmpleados'); 
    
    //    $this->post('/alta',\empleadoApi::class . ':CargarEmpleado'); 
    
    //    $this->put('/login',\empleadoApi::class . ':ModificarEmpleado'); 
    
    //    $this->delete('/login/{mail}', \empleadoApi::class . ':BorrarEmpleado')->add(\MWparaCORS::class . ':HabilitarCORSTodos'); 
        
            
});


$app->group('/cliente', function () {

    //    $this->get('/login',\empleadoApi::class . ':TraerEmpleados')->add(\MWparaCORS::class . ':HabilitarCORSTodos'); 

    $this->post('/alta',\clienteApi::class . ':CargarElemento'); 

    $this->post('/login',\clienteApi::class . ':TraerUnElemento');

    $this->get('/listado',\clienteApi::class . ':TraerElementos'); 

    $this->put('/modificar',\clienteApi::class . ':ModificarElemento'); 

    $this->delete('/borrar/{id}',\clienteApi::class . ':BorrarElemento')->add(\MWparaCORS::class . ':HabilitarCORSTodos'); 
        
        
});

$app->group('/mesa', function () {

        $this->post('/alta',\mesaApi::class . ':CargarMesa'); 

        $this->post('/consulta',\mesaApi::class . ':TraerMesa');

        $this->get('/listado',\mesaApi::class . ':TraerMesas'); 

        $this->put('/modificar',\mesaApi::class . ':ModificarMesa'); 

        $this->delete('/borrar/{id_mesa}',\mesaApi::class . ':BorraMesa')->add(\MWparaCORS::class . ':HabilitarCORSTodos'); 

        
});

//localhost/resto/API/crearToken/?id_empleado=2&nombre_completo=Juan Gritz&id_rol=2&clave=1234

$app->get('/crearToken/', function (Request $request, Response $response) {
  
      $datos = $request->getParams('id_empleado','nombre_completo','id_rol','clave');
      $vId = $datos['id_empleado'];
      $var = empleado::TraerUnoId($vId);      
      
      if($var != null){

          $token= AutentificadorJWT::CrearToken($datos); 
          $newResponse = $response->withJson($token, 200); 
          return $newResponse;
      }
      else{

          return "No se puede crar token a empleado inexistente";
      }
 });
 
//  public $id_empleado;
//     public $nombre_completo;
//     public $id_rol;
//     public $clave;




//_____________________________________Empleado____________//


//->add(\AutentificadorMW::class . ':VerificarUsuario')->add(\MWparaCORS::class . ':HabilitarCORS8080');

//_____________________________________Auto____________//

$app->group('/auto', function () {   
  
  // $this->get('/', \autoApi::class . ':TraerAutos')->add(\MWparaCORS::class . ':HabilitarCORSTodos');  
   
   $this->get('/', \autoApi::class . ':TraerUnAuto');  

   $this->post('/',\autoApi::class .':CargarAuto');

   $this->put('/{patente}',\autoApi::class .':ModificarAuto');

   $this->delete('/', \autoApi::class . ':RetirarAuto');
  
  
  })->add(\AutentificadorMW::class . ':VerificarAcceso')->add(\MWparaCORS::class . ':HabilitarCORSTodos');


/*_______________________________________________________________________*/

$app->run();