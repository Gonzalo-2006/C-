Console.WriteLine("Ingrese la cantidad de dias: "); 
int dias = int.Parse(Console.ReadLine()); 

int contadorMes = 0; 
int contadorDias = 0; 
int contadorAño = 0; 


contadorAño = dias / 365; 
dias %= 365;

contadorMes = dias / 30; 
dias %= 30;

contadorDias = dias; 
Console.WriteLine($"Los dias son iguales a: {contadorAño} Año, {contadorMes} Meses, {contadorDias} Dias");