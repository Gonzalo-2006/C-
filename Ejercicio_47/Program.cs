Console.WriteLine("Determinar la estatura mayor de un grupo de N estudiantes...\n");

Console.WriteLine("Ingrese la cantidad de estudiantes a evluar"); 
double cantidadDeEstudiantes = double.Parse(Console.ReadLine()); 

double contador = 1; 

double mayor = double.MinValue; 
double menor = double.MaxValue;

while(contador <= cantidadDeEstudiantes){
    Console.Write($"Ingrese la altura del estudiante {contador}: ");
    double estatura = double.Parse(Console.ReadLine()); 

    if(estatura < menor){
        menor = estatura; 
    } 
    if (estatura > mayor) {
        mayor = estatura;
    }

    contador++;
}
Console.WriteLine($"La estatura mas alta es: {mayor}"); 

