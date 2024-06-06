Console.WriteLine("programa que reciba N calificaiones de una materia ");

Console.WriteLine("Ingrese la materia a calcular");
string materia = Console.ReadLine();

Console.WriteLine("Ingrese la cantidad de calificaciones a evaluar"); 
int cantidadDeNotas = int.Parse(Console.ReadLine()); 

int i = 1; 
int sumaDeNotas = 0; 

int mayor = int.MinValue; 
int menor = int.MaxValue;

while(i <= cantidadDeNotas){
    Console.Write($"Ingrese su calificacion N° {i}: ");
    int nota = int.Parse(Console.ReadLine());

    if(nota < menor){
        menor = nota; 
    } 
    if (nota > mayor) {
        mayor = nota;
    }
    sumaDeNotas += nota;
    i++;
}
Console.WriteLine("Promedio "+sumaDeNotas);
int promedio = (sumaDeNotas / cantidadDeNotas); 
if(promedio >= 40){
    Console.WriteLine($"El promedio de la materia {materia} es de {promedio} lo cual significa que usted aprueba"); 
    Console.WriteLine($"La nota mas alta fue: {mayor}"); 
}else{
    Console.WriteLine($"El promedio de la materia {materia} es de {promedio} lo cual significa que usted no aprueba"); 
    Console.WriteLine($"La nota mas alta fue: {mayor}"); 
}



