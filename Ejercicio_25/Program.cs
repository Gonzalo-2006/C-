int op;
Console.WriteLine("digite 1 para hallar la velocidad");
Console.WriteLine("digite 2 para hallar la distancia");
Console.WriteLine("digite 3 para hallar el tiempo");

Console.WriteLine("seleccione una opcion");
op=int.Parse(Console.ReadLine());
switch(op)
{
    case 1:
    int tiempo=0, distancia=0,velocidad=0;
    Console.Write("ingrese el tiempo");
    tiempo = int.Parse(Console.ReadLine());
    Console.Write("ingrese la distancia ");
    distancia = int.Parse(Console.ReadLine());
    velocidad=tiempo/distancia;
    Console.WriteLine("la velocidad es "+velocidad);
    break;
    case 2:
    Console.Write("opcion para hallar la distancia");
    Console.WriteLine("ingrese la velocidad");
    velocidad = int.Parse(Console.ReadLine());
    Console.Write("ingrese el tiempo");
    tiempo=int.Parse(Console.ReadLine());
    distancia=velocidad*tiempo;
    Console.WriteLine("La distancia recorrida es de " + distancia);
    break;
    case 3:
    Console.WriteLine("opcion para hallar el tiempo");
    Console.WriteLine("ingrese la velocidad");
    velocidad=int.Parse(Console.ReadLine());
    Console.Write("ingrese la distancia");
    distancia=int.Parse(Console.ReadLine()) ;
    tiempo=distancia/velocidad;
    Console.WriteLine("El tiempo  para recorrer la distancia es de" + tiempo);
    break;
    default:
    Console.WriteLine("no digito ninguna opcion valida");
    break;
    }
