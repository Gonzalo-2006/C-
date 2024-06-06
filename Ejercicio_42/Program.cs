Console.WriteLine("Programa que permite obtener el cubo, la cuarta y la quinta potencia de un número.");

bool repetir = true;
while (repetir){

Console.WriteLine("Ingrese el número base: ");
 int Base = int.Parse(Console.ReadLine());

    int contador = 1;
    int resultado = 1;

for (int i = 3; i <= 5; i++){
    resultado = 1; 
    contador = 1; 

    while (contador <= i){
        resultado *= Base;
        contador++;
    }

Console.WriteLine($"El resultado del exponente {i} es igual a: {resultado}\n");
}

Console.WriteLine("¿Desea realizar otra operación? (s/n)");
   string respuesta = Console.ReadLine();
   repetir = respuesta.ToLower() == "s";
}
    



