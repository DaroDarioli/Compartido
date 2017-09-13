<?php
include_once "Persona.php";

class Aula
{
	public $alumnos;
	public $profesor;

	public function __construct($profesor, $alumnos=[])
	{
		$this->alumnos = $alumnos;
		$this->profesor = $profesor;
	}

	public function altaAlumno($alumno)
	{
		array_push($this->alumnos, $alumno);
	}

	public function altaProfesor($profesor)
	{
		$this->profesor = $profesor;
	}

	public function mostrarAlumnos()
	{
		foreach($this->alumnos as $alum)
		{
			echo $alum->mostrarDatos();
			echo "<br>";
		}
		//print_r($this->alumnos);
		echo "<br>";
		echo $this->profesor->mostrarDatos();
	}

	public function buscarAlumno($nombre, $apellido="", $sexo='')
	{
		$retorno = false;
		foreach($this->alumnos, $alum)
		{
			if($apellido != "")
			{
				if($sexo != "")
				{
					if($alum->nombre==$nombre && $alum->apellido==$apellido && $alum->sexo==$sexo)
					{
						$retorno = true;
						break;
					}
				}
				else
				{
					if($alum->nombre==$nombre && $alum->apellido==$apellido)
					{
						$retorno = true;
						break;
					}
				}

			}
			if($alum)
			{
				$retorno = true;
				break;
			}
		}
		return $retorno;
	}
}

// Se necesita tener el listado diez aulas, con los alumnos y el profesor a cargo,
// Para buscar por nombre y/o apellido y/o sexo  :
// Un alumno en todas las aulas.
// Un alumno en un aula.
// Un profesor en las aulas.
// Cantidad de veces que aparece un alumno en las aulas.   
// Una persona en las alulas.
// Cantidad y listado de personas con el mismo apellido y/o nombre y/o sexo.

// Se debe crear la jerarquía de clases, sabiendo que una de las clases es abstracta. 
// 

?>