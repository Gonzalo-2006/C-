int numero1, numero2;

Console.WriteLine("Ingrese el primer nuemero"); 
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segunfo nuemero"); 
numero2 = int.Parse(Console.ReadLine());

if(numero1 == numero2){
    int resultado = numero1 - numero2; 
    Console.WriteLine("El resultado es: "+resultado); 
}else {
    int resultado = numero1 + numero2; 
    Console.WriteLine("El resultado es: "+resultado); 
}
