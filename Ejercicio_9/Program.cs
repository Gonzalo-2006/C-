double Productos, Iva;
double CostoDeProductos; 
Console.WriteLine("Programa para saber el valor de varios productos de la misma referencia..."); 

Console.WriteLine("Ingrese la cantidad de productos"); 
Productos = double.Parse(Console.ReadLine()); 

Console.WriteLine("Ingrese el costo del prducto"); 
CostoDeProductos = double.Parse(Console.ReadLine()); 

double valorAPagar = Productos * CostoDeProductos; 
Iva= (valorAPagar*16)/100; 
double TotalAPagar = valorAPagar + Iva; 

Console.WriteLine("se debe pagar: "+valorAPagar);
Console.WriteLine("IVA a pagar: "+Iva);
Console.WriteLine("Total a pagar: "+TotalAPagar);