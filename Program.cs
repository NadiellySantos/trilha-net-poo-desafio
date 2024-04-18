using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone(feito)

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"20202020",modelo:"Modelo nokia",imei:"11111111",memoria:30);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");


Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"303030303",modelo:"Modelo Iphone",imei:"22222222",memoria:1000);
iphone.Ligar();
iphone.InstalarAplicativo("Intagram");