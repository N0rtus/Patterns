using System;
using SimpleFactor.AirLineFlights;
using SimpleFactor.ReportSystem;

namespace SimpleFactor
{
    class Program
    {
        static void Main(string[] args)
        {
//            ReporterSystem();

            AirlineSystem();

            Console.ReadKey();
        }

        public static void AirlineSystem()
        {
            var mahanAirLine = AirLineFactory.Create(AirlineType.Mahan);

            var flights = mahanAirLine.GetFlights();

            foreach (var flight in flights)
            {
                Console.WriteLine(flight);
            }
        }

        public static void ReporterSystem()
        {
            var pdfReporter = ReporterFactory.Create(ReportFormat.Pdf);

            var xmlReporter = ReporterFactory.Create(ReportFormat.Xml);

            var jsonReporter = ReporterFactory.Create(ReportFormat.Json);

            var xmlReport = xmlReporter.Report();

            var jsonReport = jsonReporter.Report();

            var pdfReport = pdfReporter.Report();

            Console.WriteLine(xmlReport);
            Console.WriteLine(jsonReport);
            Console.WriteLine(pdfReport);
        }
    }
}
