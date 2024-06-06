int GradoDeEstudiante; 

Console.WriteLine("Porfavor ingrese su grado escolar: "); 
GradoDeEstudiante = int.Parse(Console.ReadLine()); 

if(GradoDeEstudiante == 0 && GradoDeEstudiante <= 6){
    Console.WriteLine("El estudiante requiere refrigerio"); 
}else if(GradoDeEstudiante < 0){
    Console.WriteLine("El estudiante no pertenece a la institucion");
}else{
    Console.WriteLine("El estudiante no requiere refrigerio"); 
}
