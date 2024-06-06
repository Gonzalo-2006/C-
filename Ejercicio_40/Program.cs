/*
Console.WriteLine("Calcular la suma de los N numeros");


Console.WriteLine("Ingrese la cantidad de numeros a sumar: "); 
int cantidad = int.Parse(Console.ReadLine()); 

int sumaTotal = 0; 
int contador = 0; 

while(contador < cantidad){
    Console.Write($"Ingrese el dato N°{contador +1}: ");
    int num = int.Parse(Console.ReadLine()); 

    sumaTotal += num; 
    contador++;
}
Console.WriteLine($"El resultado de la suma es: {sumaTotal}"); 
*/ 

Console.WriteLine("Ingrese el N numero: "); 
int num = int.Parse(Console.ReadLine()); 

int resultado = 0; 
int contador = 0; 

while(contador <= num){
    resultado += contador;
    contador++; 
}
Console.WriteLine($"La sumatoria hasta el N es: {resultado}");