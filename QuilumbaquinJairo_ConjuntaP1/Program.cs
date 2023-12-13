using QuilumbaquinJairo_ConjuntaP1;

//Pregunta1
Pregunta1 pregunta1 = new Pregunta1(2,3);
pregunta1.Suma();

//Pregunta2

Pregunta2 pregunta2 = new Pregunta2(19);
pregunta2.VerificarEdad();

//Pregunta3

Estudiante estudiante = new Estudiante();
estudiante.Nombre="Jairo";
estudiante.Edad=23;
estudiante.Calificacion = 15.56f;

Console.WriteLine(estudiante.Nombre);
Console.WriteLine(estudiante.Edad);
Console.WriteLine(estudiante.Calificacion);

//Pregunta 4

estudiante.MostrarInformacion();

//Pregunta 5

EstudianteGraduado graduado = new EstudianteGraduado();
graduado.Nombre = "Luis";
graduado.Edad = 24;
graduado.Calificacion = 17.5f;
graduado.Titulo = "Ingeniero de Software";

graduado.MostrarInformacion();


