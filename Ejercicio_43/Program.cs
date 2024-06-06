Console.WriteLine("Determinamos cuantas veces se repite el N numero");

Console.WriteLine("Ingrese el numero a buscar"); 
int num1 = int.Parse(Console.ReadLine()); 

Console.WriteLine("Cuantos numeros  desea ingresar"); 
int cantidadDeNum = int.Parse(Console.ReadLine()); 

int sumaTotal = 0;
int i = 0; 

while(i < cantidadDeNum){
    Console.WriteLine($"Ingrese el dato N°{i + 1}:"); 
    int num2 = int.Parse(Console.ReadLine()); 

    if(num2 == num1){
        sumaTotal ++; 
    }

    i++; 
}
if(contador <= 1){
    Console.WriteLine($"El numero a buscar {num1} aparece {contador} vez");
}else{
    Console.WriteLine($"El numero a buscar {num1} aparece {contador} veces");
}