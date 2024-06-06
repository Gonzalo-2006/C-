Console.WriteLine("Caja registradora...\n ");

Console.WriteLine("Ingrese la cantidad de productos a pagar"); 
int cantidad = int.Parse(Console.ReadLine()); 

int contador = 1; 
int sumaDePago = 0;  
while(contador <= cantidad){
    Console.WriteLine("Ingrese el precio de su producto"); 
    int precio = int.Parse(Console.ReadLine()); 
    sumaDePago += precio; 

    contador++;

}

Console.WriteLine($"El monto a pagar es de: {sumaDePago}"); 

