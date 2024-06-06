int numero1; 
Console.WriteLine("Ingrese su numero"); 
numero1 = int.Parse(Console.ReadLine()); 

if(numero1 > 0){
    Console.WriteLine("El numero es positivo"); 
}else if(numero1 == 0){
    Console.WriteLine("El numero ingresado es cero"); 
}else{
    Console.WriteLine("El numero es negativo"); 
}
Console.WriteLine(); 