int totalDeCompra,costoDeProducto,cantidadDeProductos; 

Console.WriteLine("Ingrese la cantidad de productos"); 
cantidadDeProductos = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el costo de productos"); 
costoDeProducto = int.Parse(Console.ReadLine());

totalDeCompra = costoDeProducto * cantidadDeProductos; 

if(totalDeCompra > 10000 && totalDeCompra <= 20000){
    Console.WriteLine("Usted tiene un descuento del 10%");
    int descuento = (totalDeCompra*10)/100;
    Console.WriteLine("Total a pagar: "+descuento);
}else if(totalDeCompra > 20001 && totalDeCompra <= 50000){
    Console.WriteLine("Usted tiene un descuento del 30%");
    int descuento = (totalDeCompra*30)/100;
    Console.WriteLine("Total a pagar: "+descuento);
}else if(totalDeCompra > 50000){
    Console.WriteLine("Usted tiene un descuento del 50%");
    int descuento = (totalDeCompra*50)/100;
    Console.WriteLine("Total a pagar: "+descuento);
}else{
    Console.WriteLine("No se aplica ningun descuento");
     Console.WriteLine("Total a pagar: "+totalDeCompra);
}
