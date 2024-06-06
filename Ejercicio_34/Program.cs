Console.WriteLine("Calculamos la estatura promedio en un grupo de estudiantes...");

int sumaDeEstatura=0, promedio; 

for(int i=1; i<=18;i++){
    Console.WriteLine("Estudiante N°"+i+"\nIngrese su estatura en cm:");
    int estatura = int.Parse(Console.ReadLine());
    sumaDeEstatura += estatura; 
}

promedio = sumaDeEstatura/18; 
Console.WriteLine("La estatura promedio es de: "+promedio+"cm");

if(promedio <= 140){
    Console.WriteLine("Estudiantes muy bajos");
}else if(promedio >= 140 && promedio <= 170){
    Console.WriteLine("Estudiantes de estatura normal");
}else{
    Console.WriteLine("Estudiantes muy altos");
}
