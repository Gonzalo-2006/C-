double edad=0, estatura=0, peso=0;

Console.WriteLine("programa para determinar si un deportista es aceptado en el equipo");

Console.WriteLine("por favor digite su edad");
edad=double.Parse(Console.ReadLine());

Console.WriteLine("por favor digite su estatura");
estatura=double.Parse(Console.ReadLine());

Console.WriteLine("por favor digite su peso");
peso=double.Parse(Console.ReadLine());

if( edad <=18 & peso<=80 & estatura >180){

    Console.WriteLine("usted aprobo");
}

else {
    Console.WriteLine("usted no aprobo");
}
