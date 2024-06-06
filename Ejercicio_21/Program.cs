int lunes,martes,miercoles,jueves,viernes,sabado,domingo;

Console.WriteLine("Ingrese la temperatura del dia lunes:");
lunes = int.Parse(Console.ReadLine()); 

Console.WriteLine("Ingrese la temperatura del dia Martes:"); 
martes = int.Parse(Console.ReadLine()); 

Console.WriteLine("Ingrese la temperatura del dia Miercoles:"); 
miercoles = int.Parse(Console.ReadLine()); 

Console.WriteLine("Ingrese la temperatura del dia Jueves:"); 
jueves = int.Parse(Console.ReadLine()); 

Console.WriteLine("Ingrese la temperatura del dia Viernes:"); 
viernes = int.Parse(Console.ReadLine()); 

Console.WriteLine("Ingrese la temperatura del dia Sabado:"); 
sabado = int.Parse(Console.ReadLine()); 

Console.WriteLine("Ingrese la temperatura del dia Domingo:"); 
domingo = int.Parse(Console.ReadLine()); 

int temperaturaPromedio = (lunes + martes + miercoles + jueves + viernes + sabado + domingo)/7;

if (temperaturaPromedio > 35){
    Console.WriteLine("Temperatura: "+temperaturaPromedio);
    Console.WriteLine ("Que semana tan calurosa");
}else if(temperaturaPromedio > 15 && temperaturaPromedio < 35){
    Console.WriteLine("Temperatura: "+temperaturaPromedio);
    Console.WriteLine ("Que clima tan delicioso");
}else{
    Console.WriteLine("Temperatura: "+temperaturaPromedio);
    Console.WriteLine ("Que clima tan frio");
}