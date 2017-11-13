<?php
use \Psr\Http\Message\ServerRequestInterface as Request;
use \Psr\Http\Message\ResponseInterface as Response;

require_once __DIR__ .'/../composer/vendor/autoload.php';

require_once './clases/AccesoDatos.php';
require_once './clases/auto.php';
require_once './clases/autoApi.php';
require_once './clases/empleado.php';
require_once './clases/empleadoApi.php';

require_once './clases/AutentificadorMW.php';
require_once './clases/AutentificadorJWT.php';
require_once './clases/MWparaCORS.php';

$config['displayErrorDetails'] = true;
$config['addContentLengthHeader'] = false;

$app = new \Slim\App(["settings" => $config]);

$app->get('/crearToken/', function (Request $request, Response $response) {
  
      $datos = $request->getParams('mail','clave','perfil');
      $vMail = $datos['mail'];
      $var = empleado::TraerUno($vMail);      
      
      if($var != null){

          $token= AutentificadorJWT::CrearToken($datos); 
          $newResponse = $response->withJson($token, 200); 
          return $newResponse;
      }
      else{

          return "No se puede crar token a empleado inexistente";
      }
 });
 

//_____________________________________Empleado____________//

$app->group('/empleado', function () {
  
   $this->get('/login',\empleadoApi::class . ':TraerEmpleados')->add(\MWparaCORS::class . ':HabilitarCORSTodos'); 

   $this->get('/login/{mail}',\empleadoApi::class . ':TraerUnEmpleado');

   $this->post('/login',\empleadoApi::class . ':CargarEmpleado'); 

   $this->put('/login',\empleadoApi::class . ':ModificarEmpleado'); 

   $this->delete('/login/{mail}', \empleadoApi::class . ':BorrarEmpleado')->add(\MWparaCORS::class . ':HabilitarCORSTodos'); 
 
     
})->add(\AutentificadorMW::class . ':VerificarUsuario')->add(\MWparaCORS::class . ':HabilitarCORS8080');


//_____________________________________Auto____________//

$app->group('/auto', function () {   
  
   $this->get('/', \autoApi::class . ':TraerAutos')->add(\MWparaCORS::class . ':HabilitarCORSTodos');  
   
   $this->get('/{patente}', \autoApi::class . ':TraerUnAuto')->add(\MWparaCORS::class . ':HabilitarCORSTodos');  

   $this->post('/{mail}',\autoApi::class .':CargarAuto');

   $this->put('/{patente}',\autoApi::class .':ModificarAuto');

   $this->delete('/{patente}', \autoApi::class . ':BorrarAuto');
  
  
  })->add(\MWparaCORS::class . ':HabilitarCORS8080');


/*_______________________________________________________________________*/

$app->run();