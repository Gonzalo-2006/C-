double PagoDiario, CantidadDeDias = 30,salario, Pension, Salud; 

PagoDiario = 43330; 
Console.WriteLine("Pago de dia de trabajo: " + PagoDiario); 

salario = PagoDiario * CantidadDeDias; 
Console.WriteLine("Salario mensual: " + salario);

Pension = (salario*10)/100; 
Salud = (salario*15)/100; 

double Arl = Pension + Salud;
double SalarioTotal = salario - Arl; 

Console.WriteLine("Valor de la pension: "+ Pension);
Console.WriteLine("Valor de salud: " + Salud);
Console.WriteLine("Salario: "+ SalarioTotal); 


