int costo, cantidad, totalDePago;

Console.WriteLine("ingrese la cantidad de productos"); 
cantidad = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese el costo del producto");
costo = int.Parse(Console.ReadLine());

totalDePago = cantidad * costo; 
Console.WriteLine(totalDePago);

if(totalDePago < 20000){
    Console.WriteLine("el descuento es del 15%");
    int descuento = (totalDePago*15)/100; 
  
    Console.WriteLine(totalDePago);
    Console.WriteLine("Valor unitario por producto: "+costo);
    Console.WriteLine("el total a pagar es: "+ descuento); 
}else{
    Console.WriteLine("el descuento es del 35%");
    int descuento = (totalDePago*35)/100; 
    
    Console.WriteLine(totalDePago);
     Console.WriteLine("Valor unitario por producto: "+costo);
    Console.WriteLine("el total a pagar es: "+descuento); 
}
