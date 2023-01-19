using DesafioPOO.Models;

Console.WriteLine($"Smartphone Iphone: ");
Iphone iphone = new Iphone(numero: "70707070", modelo: "SE", imei: "00524", memoria: 6);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Linkedin");

Console.WriteLine("------------------------------------------------------------");

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia(numero: "606060", modelo: "KA", imei: "05529", memoria: 7);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Amazon");

Console.WriteLine("------------------------------------------------------------");