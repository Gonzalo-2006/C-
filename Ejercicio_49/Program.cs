Console.WriteLine("Menu de opciones");

int op;
int valor1 = 0, valor2 = 0, valor3 = 0, factorial = 0; 
do{
    Console.WriteLine("1: Factoria de el numero infresado: \n 2: Potencia \n 3: Salir \n");
    op = int.Parse(Console.ReadLine());
    switch(op){
        case 1: 
        Console.WriteLine("Ingrese un numero: ");
        valor1 = int.Parse(Console.ReadLine()); 
        // Proceso para factorial 
        for(int i = 1; i <= valor1; i++){
            valor1 *= i; 
        }
        factorial = valor1;
        Console.WriteLine($"El factorial de {valor1} es igual a: {factorial} ");
        break;
        case 2: 
        Console.WriteLine("Ingrese la base de su numero: "); 
        valor2 = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Ingrese el exponente de su numero: ");
        valor3 = int.Parse(Console.ReadLine()); 
        int a = 1;
        int potencia = 1; 
        while(a <= valor3){
            potencia *= valor2; 
            a++; 
        }
        Console.WriteLine($"El resultado de su potencia es: {potencia}");
        break; 
        default: Console.WriteLine("error");
        break;

    }
}while(op!=3);