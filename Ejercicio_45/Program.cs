Console.WriteLine("Calcular el factorial de un numero...\n");

Console.WriteLine("Ingrese el N numero: "); 
int num = int.Parse(Console.ReadLine()); 

int resultado = 1; 
int contador = 1; 

while(contador <= num){
    resultado *= contador;
    contador++; 
}
Console.WriteLine($"El factorial de el N numero es: {resultado}");
