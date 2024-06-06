int velocidad, tiempo,Distancia; 
Console.WriteLine("Formula de movimiento rectilineo");
Console.WriteLine("D=V*T");

Console.WriteLine("Ingrese la Velocidad:");
velocidad = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tiempo:");
tiempo = int.Parse(Console.ReadLine());

Distancia =velocidad*tiempo;
Console.WriteLine("La distanci recorrida es: "+Distancia);
