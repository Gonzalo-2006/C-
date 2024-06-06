int numero1, numero2; 

Console.WriteLine("Ingrese el valo de numero uno"); 
numero1 = int.Parse(Console.ReadLine()); 
Console.WriteLine("Ingrese el valor de numero dos"); 
numero2 = int.Parse(Console.ReadLine()); 

if(numero1 > numero2){
    Console.WriteLine("El numero uno es mayor "); 
}else if(numero1 < numero2){
    Console.WriteLine("El numero dos es mayor"); 
}else{
    Console.WriteLine("Ambos numeros son iguales"); 
}
