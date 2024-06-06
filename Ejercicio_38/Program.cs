Console.WriteLine("Determinar si un estudiante aprueba o no la materia...");

float notasTotales=0, promedio; 

for(int i=1; i<= 15; i++){
    Console.WriteLine("Ingrese la calificacion N°"+i);
    float notas = float.Parse(Console.ReadLine());
    notasTotales += notas; 
}

promedio = notasTotales/15; 

Console.WriteLine("Suma de notas: "+notasTotales.ToString("F1")); 
Console.WriteLine("El promedio de motas es: "+promedio.ToString("F1")); 

if(promedio >= 4.0){
    Console.WriteLine("El estudiante aprueba con un promedio de: "+promedio.ToString("F1"));
}else{
    Console.WriteLine("El estudiante no aprueba por su promedio de: "+promedio.ToString("F1"));
}

