Console.WriteLine("Calculamos la edad promedio de los estudiantes");

int edades = 0,promedio;
for(int i=1; i<=15;i++){
    Console.WriteLine("Estudiante N°"+i+"\nIngrese su edad:"); 
    int sumaDeEdades = 0; 
    sumaDeEdades = int.Parse(Console.ReadLine()); 
    edades += sumaDeEdades;
}

promedio = edades/15; 
Console.WriteLine("Total de edades: "+edades);
Console.WriteLine("La edad promedio es de: "+promedio);