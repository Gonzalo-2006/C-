int numero=0,op;
Console.WriteLine("programa que permita ingresar aun numero cualquiera ");

Console.WriteLine("ingrese numero");
numero=int.Parse(Console.ReadLine());

Console.WriteLine("presione 1 para determinar si el numero es positivo o negativo \npresione 2 para determinar si el numero es par o impar");
Console.WriteLine("ingrese numero de opcion");
op = int.Parse( Console.ReadLine());


switch(op){
case 1:
if (numero<0){

    Console.WriteLine("el numero es negativo");
}
else
Console.WriteLine("el numero es positivo");
break;

case 2:
if (numero%2==0){

    Console.WriteLine(" el numero es par");
}
else 
Console.WriteLine("el numero es impar");    
break;
}