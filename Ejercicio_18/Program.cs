double Productos,CostoDeProductos; 


Console.WriteLine("Ingrese la cantidad de productos"); 
Productos = double.Parse(Console.ReadLine()); 

Console.WriteLine("Ingrese el costo del prducto"); 
CostoDeProductos = double.Parse(Console.ReadLine()); 

double valorAPagar = Productos * CostoDeProductos; 
Console.WriteLine("se debe pagar: "+valorAPagar);

if(valorAPagar > 100000){
    Console.WriteLine("Se le ofrece un descuento del 20%");
    double descuento = (valorAPagar*20)/100; 
    Console.WriteLine("Valor unitario: "+CostoDeProductos);
    Console.WriteLine("En total paga: "+descuento);
}else{
    Console.WriteLine("Valor unitario: "+CostoDeProductos);
    Console.WriteLine("No se aplica descuento");
}


