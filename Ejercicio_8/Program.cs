int valor1, valor2, valor3, valor4, valor5, resultado;
Console.WriteLine("programa para calcular el promedio");

Console.WriteLine("ingrese el valor 1");
valor1=int.Parse(Console.ReadLine());

Console.WriteLine("ingrese el valor 2");
valor2=int.Parse(Console.ReadLine());

Console.WriteLine("ingrese el valor 3");
valor3=int.Parse(Console.ReadLine());

Console.WriteLine("ingrese el valor 4");
valor4=int.Parse(Console.ReadLine());

Console.WriteLine("ingrese el valor 5");
valor5=int.Parse(Console.ReadLine());

int suma= valor1 + valor2 + valor3 + valor4 + valor5;
resultado = suma / 5;

Console.WriteLine("El promedio es: "+resultado);


