
Console.WriteLine("Determinar cuanros estuadiantes son mayores de edad");
 int edad,mayor=0;
for(int i=1; i <= 20;i++){
    
    Console.WriteLine("Estudiante N°" +i+"\nIngrese su edad:"); 
    edad = int.Parse(Console.ReadLine()); 

    if(edad >=18){
        mayor++;
    }
}
 Console.WriteLine("La cantidad de estudiantes mayores de edad es:"+mayor);

