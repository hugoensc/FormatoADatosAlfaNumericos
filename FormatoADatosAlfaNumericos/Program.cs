using System;

namespace FormatoADatosAlfaNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";
            string result = string.Format("{0} {1}!", first, second);
            Console.WriteLine(result);

            // Esto es un formato compuesto
            Console.WriteLine("{1} {0}!", first, second);
            Console.WriteLine("{0} {0} {0}!", first, second);
            Console.WriteLine($"{0} {0} {0}!", first, second);

            // Uso de la directiva $
            // Esto es una interpolación de cadenas
            Console.WriteLine($"{first} {second}!");
            Console.WriteLine($"{second} {first}!");
            Console.WriteLine($"{first} {first} {first}!");

            decimal price = 123.25m;
            int discount = 50;
            Console.WriteLine($"Price: {price:C} (Save {discount:C})");

            // N es un especificador de formato
            // Hay Muchos especificadores de formato
            decimal measurement = 123456.78912m;
            Console.WriteLine($"Measurement: {measurement:N} units");
            Console.WriteLine($"Measurement: {measurement:N4} units");

            decimal tax = 0.36785m;
            Console.WriteLine($"Tax rate: {tax:P2}");


            int invoiceNumber = 1201;
            decimal productMeasurement = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal taxPercentage = .15825m;
            decimal total = 3185.19m;

            Console.WriteLine($"Invoice Number: {invoiceNumber}");
            Console.WriteLine($"    Measurement: {productMeasurement:N3} mg");
            Console.WriteLine($"        Sub Total: {subtotal:C}");
            Console.WriteLine($"            Tax: {taxPercentage:P2}");
            Console.WriteLine($"        Total Due: {total:C}");

            string input = "Pad this";
            Console.WriteLine(input.PadLeft(12));
            Console.WriteLine(input.PadRight(12));

            // Métodos sobrecargados de PAdLeft y Pad Rigth
            Console.WriteLine(input.PadLeft(12, '-'));
            Console.WriteLine(input.PadRight(12, '-'));

            // Ejercicio
            string paymentId = "769";
            string payeeName = "Mr. Stephen Ortega";
            string paymentAmount = "$5,000.00";

            var formattedLine = paymentId.PadRight(6);
            formattedLine += payeeName.PadRight(24);
            formattedLine += paymentAmount.PadLeft(10);

            Console.WriteLine("1234567890123456789012345678901234567890");
            Console.WriteLine(formattedLine);
        }
    }
}
