using System;

namespace SimpleFactor.ReportSystem
{
    public class ReporterFactory
    {
        public static IReporter Create(ReportFormat format)
        {
            if (format == ReportFormat.Json)
            {
                return new JsonReporter();
            }

            if (format == ReportFormat.Xml)
            {
                return new XmlReporter();
            }

            if (format == ReportFormat.Pdf)
            {
                return new PdfReporter();
            }

            throw new NotSupportedException("The file format doesn't support");
        }
    }
}