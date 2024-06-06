Console.WriteLine("Determinamos el dato mayo y el menor de la lista");

Console.WriteLine("Cuantos datos desea ingresar: "); 
int cantidad = int.Parse(Console.ReadLine()); 



int mayor = int.MinValue; 
int menor = int.MaxValue; 

int contador = 1; 
while(contador <= cantidad){
    Console.Write("Ingrese el dato: ");
    int num = int.Parse(Console.ReadLine());

    if(num < menor){
        menor = num; 
    } 
    if (num > mayor) {
        mayor=num;
    }
    contador++;
}
Console.WriteLine($"El dato mayo es: {mayor}"); 
Console.WriteLine($"El dato menor es: {menor}");