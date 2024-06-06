string Estudiante, Materia;
float nota1, nota2, nota3; 
int CodigoEstudiante; 

Console.WriteLine("Ingrese su nombre: "); 
Estudiante = Console.ReadLine(); 

Console.WriteLine("Ingrese el nombre de la materia: "); 
Materia = Console.ReadLine(); 

Console.WriteLine("Ingrese el codigo de estudiante: "); 
CodigoEstudiante = int.Parse(Console.ReadLine()); 


Console.WriteLine("Ingrese la calificacion N° 1");
nota1 = float.Parse(Console.ReadLine()); 
Console.WriteLine("Ingrese la calificacion N° 2");
nota2 = float.Parse(Console.ReadLine()); 
Console.WriteLine("Ingrese la calificacion N° 3");
nota3 = float.Parse(Console.ReadLine()); 

float promedio = (nota1 + nota2 + nota3)/3; 

if(promedio >= 4.0){
    Console.WriteLine("El estudiante "+Estudiante+" Con Codigo de identificacion: "+CodigoEstudiante+" apueba la materia "+Materia+" Con una nota de: "+promedio);
}else{
        Console.WriteLine("El estudiante "+Estudiante+" Con Codigo de identificacion: "+CodigoEstudiante+" No apueba la materia "+Materia+" Con una nota de: "+promedio);
}

