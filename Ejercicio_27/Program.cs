Console.WriteLine("Menu");

Console.WriteLine("Si desea saber si pasa o no la materi periona 1\nSi desea saber si es mayor de edad presiona 2"); 
int opc = int.Parse(Console.ReadLine()); 

switch (opc){
    case 1: 
    double sumaDeNotas = 0; 
    for(int i=1; i<=3;i++){
        Console.WriteLine("Ingrese la nota N°"+i); 
        double nota = double.Parse(Console.ReadLine()); 
        sumaDeNotas += nota; 
    }
    double promedio = sumaDeNotas/3; 
    Console.WriteLine("El Promedio es "+promedio.ToString("F1"));
    break;

    case 2: 
    Console.WriteLine("Ingrese la fecha actual");
    int fechaActual = int.Parse(Console.ReadLine()); 

    Console.WriteLine("Ingrese la fecha de nacimiento");
    int fechaDeNacimiento = int.Parse(Console.ReadLine()); 

    int edad = fechaActual - fechaDeNacimiento; 
    if(edad <= 18){
        Console.WriteLine("Es menor de edad");
    }else{
        Console.WriteLine("Es mayor de edad");
    }
    break;

}
