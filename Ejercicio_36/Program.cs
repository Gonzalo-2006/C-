Console.WriteLine("Imprimir la tabla de multiplicar de un numero...");


Console.WriteLine("Ingrese su numero: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Tabla de multiplicar:");
for(int i=1; i <= 10; i++){
    
    Console.WriteLine(i*num);
}
