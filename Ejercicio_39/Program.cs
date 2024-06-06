Console.WriteLine("Encontrar el resultado de la potencia");

Console.WriteLine("Ingrese la base"); 
int Base = int.Parse(Console.ReadLine()); 

Console.WriteLine("Ingrese el exponente"); 
int exponente = int.Parse(Console.ReadLine()); 

int resultado = 1; 
int contador = 1; 
while (contador <= exponente){
    resultado *= Base; 
    contador++;
}
Console.WriteLine($"El resultado de la potencia es: {resultado}"); 