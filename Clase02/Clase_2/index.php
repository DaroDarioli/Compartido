<?php

	include_once "Alumno.php";
	include_once "Profesor.php";
	include_once "Persona.php";
	include_once "Aula.php";

	$alumno1 = new Alumno("Juan", "Perez", 'm');
	$alumno2 = new Alumno("Emiliano", "Bustos", 'm');
	$alumno3 = new Alumno("Juana", "Fernandez");
	$profesor = new Profesor("Pablo", "Garcia", 'm');



	$aula1 = new Aula($profesor);
	$aula1->altaAlumno($alumno1);
	$aula1->altaAlumno($alumno2);
	$aula1->altaAlumno($alumno3);
	$aula1->mostrarAlumnos();

	// $aula2 = new Aula();
	// $aula3 = new Aula();
	// $aula4 = new Aula();
	// $aula5 = new Aula();
	// $aula6 = new Aula();
	// $aula7 = new Aula();
	// $aula8 = new Aula();
	// $aula9 = new Aula();
	// $aula10 = new Aula();


	// $aulas =[];
	// array_push($aulas, $aula1, $aula2, $aula3, $aula4, $aula5, $aula6, $aula7, $aula8, $aula9, $aula10);
	
	//$alumno->nombre = "Pedro";
	//$profesor->nombre = "Pablo";

	// echo "Hola " . $profesor->nombre . " " . $profesor->apellido;
	// echo "<br>";
	// echo "Hola " . $alumno->nombre . " " . $alumno->apellido;
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