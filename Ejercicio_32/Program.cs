Console.WriteLine("Determinamos cuantos hombres y mujeres hay en un curso");

int contadorDeMujeres = 0, contadorDeHombres = 0;
int opcion;
bool validacion; 

for(int i=1; i <= 25;i++){
    Console.WriteLine("Si eres hombre presiona 1 y si eres mujer presiona 0");
  
    validacion = int.TryParse(Console.ReadLine(), out opcion);
    while (!validacion || (opcion != 1 && opcion != 0)) {
        Console.WriteLine("Entrada no válida. Por favor, intenta nuevamente: Si eres hombre presiona 1 y si eres mujer presiona 0");
        validacion = int.TryParse(Console.ReadLine(), out opcion);
    }

    if(opcion == 1){
        contadorDeHombres++;
    }else{
        contadorDeMujeres++;
    }
 
}
Console.WriteLine("Hay "+contadorDeHombres+" hombres en el curso"); 
Console.WriteLine("Hay "+contadorDeMujeres+" mujeres en el curso"); 