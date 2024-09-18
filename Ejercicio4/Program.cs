// See https://aka.ms/new-console-template for more information
using Ejercicio4.Interfaces;
using Ejercicio4.Servicios;
//Console.WriteLine("Hello, World!");

Mensajeria mensajePorSMS = new Mensajeria(new SmsMensaje());
Mensajeria mensajePorEmail = new Mensajeria(new EmailMensaje());

Console.WriteLine(mensajePorSMS.EnviarMensaje());
Console.WriteLine(mensajePorEmail.EnviarMensaje());