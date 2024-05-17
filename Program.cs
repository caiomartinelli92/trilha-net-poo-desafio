using DesafioPOO.Models;

Nokia n1 = new Nokia("123456", "Tijolao", "111222333", 8);
Iphone i1 = new Iphone("7891011", "15 MAX PRO", "777888999", 16);

Console.WriteLine("Numero do Nokia é: " + n1.Numero);
Console.WriteLine("Numero do Nokia é: " + i1.Numero);

n1.InstalarAplicativo("Instagram");
i1.InstalarAplicativo("Uber");