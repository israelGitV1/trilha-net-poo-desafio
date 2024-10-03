using System.Reflection.Metadata;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone i = new Iphone(numero:"998583540",modelo:"S13",imei:"User@gmail.com",memoria:64);
Nokia n = new Nokia(numero:"988405091",modelo:"N34",imei:"User2@gamil.com",memoria:8);

System.Console.WriteLine("\n----------------------Iphone---------------------------");
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("Youtube");
System.Console.WriteLine("\n-----------------------Nokia--------------------------");
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("Youtube");
