<?php

require_once 'AccesoDatos.php';

class pedido
{
    public $id_comanda;
    public $id_producto;
    public $cantidad_producto;
    public $estado_pedido;
   


        public function __construct() {}  

        public function Insertar()
        {
            $objetoAccesoDato = AccesoDatos::dameUnObjetoAcceso(); 
            $consulta =$objetoAccesoDato->RetornarConsulta("INSERT into comanda_detalles 
            (id_comanda, id_producto, cantidad_producto, estado_pedido) values (:id_comanda,:id_producto,:cantidad_producto,:estado_pedido)");

            $consulta->bindValue(':id_comanda', $this->id_comanda, PDO::PARAM_STR);
            $consulta->bindValue(':id_producto', $this->id_producto, PDO::PARAM_STR);
            $consulta->bindValue(':cantidad_producto', $this->cantidad_producto, PDO::PARAM_STR);
            $consulta->bindValue(':estado_pedido', $this->estado_pedido, PDO::PARAM_STR);
            
            $consulta->execute();		
            return $objetoAccesoDato->RetornarUltimoIdInsertado();
        }


        public static function TraerTodosLosPedidosPendientes()
        {
            $objetoAccesoDato = AccesoDatos::dameUnObjetoAcceso(); 
            $consulta =$objetoAccesoDato->RetornarConsulta("SELECT * FROM `comanda_detalles` WHERE `estado_pedido`= 1");
            $consulta->execute();	
            $consulta->setFetchMode(PDO::FETCH_ASSOC);
            return $consulta->fetchAll();
        }

        public static function TraerTodosLosPedidosPendientesSector($pSector)
        {
            $objetoAccesoDato = AccesoDatos::dameUnObjetoAcceso(); 
            //$consulta =$objetoAccesoDato->RetornarConsulta("SELECT * FROM `comanda_detalles` INNER JOIN `productos` ON `comanda_detalles.id_producto` = `productos.id_producto`");
            $consulta =$objetoAccesoDato->RetornarConsulta("SELECT * FROM `comanda_detalles` INNER JOIN `productos` ON comanda_detalles.id_producto = productos.id_producto WHERE `id_cocina` = '$pSector'");
            //$consulta =$objetoAccesoDato->RetornarConsulta("SELECT * FROM `productos` WHERE `id_cocina` = '$pSector'"); funciona
            $consulta->execute();	
            $consulta->setFetchMode(PDO::FETCH_ASSOC);
            return $consulta->fetchAll();
        }


        // public static function TraerUna($vId){
        
        //     $objetoAccesoDato = AccesoDatos::dameUnObjetoAcceso(); 
        //     $consulta =$objetoAccesoDato->RetornarConsulta("SELECT * FROM `comandas` WHERE  `id_comanda` = '$vId'");
        //     $consulta->execute();      
        //     $consulta->setFetchMode(PDO::FETCH_CLASS,"comanda"); 
        //     return $consulta->fetchAll();

        // }
  
        // public function ModificarUna()
        // {
        //     $objetoAccesoDato = AccesoDatos::dameUnObjetoAcceso(); 
        //     $consulta =$objetoAccesoDato->RetornarConsulta("
        //         update comandas
        //         set                 
        //         id_mesa ='$this->id_mesa',
        //         id_mozo ='$this->id_mozo',
        //         id_estado_pedido ='$this->id_estado_pedido',
        //         fecha_alta ='$this->fecha_alta',
        //         fecha_estipulada ='$this->fecha_estipulada',                
        //         fecha_entrega ='$this->fecha_entrega',
        //         total = '$this->total'
        //         WHERE id_comanda = '$this->id_comanda'");
        //    return $consulta->execute();

        // }

        // public function BorrarUna()
        // {
        //     $objetoAccesoDato = AccesoDatos::dameUnObjetoAcceso(); 
        //     $consulta =$objetoAccesoDato->RetornarConsulta("
        //     delete 
        //     from comandas 				
        //     WHERE id_comanda =:id_comanda");	
        //     $consulta->bindValue(':id_comanda',$this->id_comanda, PDO::PARAM_INT);		
        //     $consulta->execute();
        //     return $consulta->rowCount();
        // }
}



?>