using System;

class Program
{
    static void Main()
    {
        DateTime horaActual = DateTime.Now;
        Console.WriteLine("La hora actual es: " + horaActual.ToString("HH:mm:ss"));
    }
}
