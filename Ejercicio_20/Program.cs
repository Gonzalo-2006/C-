int num; 
 Console.WriteLine("Ingrese su numero: "); 
 num = int.Parse(Console.ReadLine());

 int operacion = num % 2; 

 if(operacion == 0){
    Console.WriteLine("El numero es par");
 }else{
    Console.WriteLine("El numero es impar");
 }


