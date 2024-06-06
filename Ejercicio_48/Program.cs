Console.WriteLine("----Menu de operaciones----");

int op, valor1 = 0, valor2 = 0, suma,resta,multiplicar,dividir;

do{
    Console.WriteLine(" 1: Ingresar dos numeros\n 2: Sumar\n 3: Restar\n 4: Multiplicar\n 5: Dividir\n 6: Salir\n Ingrese su opcion:"); 
    op = int.Parse(Console.ReadLine()); 

switch(op){
    case 1: 
    Console.WriteLine("Ingrese el primer digito: "); 
    valor1=int.Parse(Console.ReadLine()); 

    Console.WriteLine("Ingrese el segundo digito: ");
    valor2=int.Parse(Console.ReadLine());
    break; 

    case 2: 
    suma = valor1 + valor2; 
    Console.WriteLine($"---El resultado de su suma es: {suma}---\n");
    Console.ReadKey();
    break;

    case 3: 
    resta = valor1 - valor2;
    Console.WriteLine($"---El resultado de su resta es: {resta}---\n");
    Console.ReadKey();
    break;

    case 4: 
    multiplicar = valor1 * valor2; 
    Console.WriteLine($"---El resultado de su multiplicacion es: {multiplicar}---\n");
    Console.ReadKey();
    break;

    case 5: 
    dividir = valor1 / valor2; 
    Console.WriteLine($"---El resultado de su divicion es: {dividir}---\n"); 
    Console.ReadKey();
    break;

}
}while (op != 6);
