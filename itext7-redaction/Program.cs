using System.Collections.ObjectModel;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.PdfCleanup;

var inFileName = @"../../../../pdfSweep-whitepaper.pdf";
var outFileName = @"../../../../pdfSweep-whitepaper-redacted.pdf";

PdfDocument pdf = new PdfDocument(new PdfReader(inFileName), new PdfWriter(outFileName));

IList<PdfCleanUpLocation> cleanUpLocations = new Collection<PdfCleanUpLocation>();
for (var i = 0; i < pdf.GetNumberOfPages(); i++)
{
    cleanUpLocations.Add(new PdfCleanUpLocation(i + 1, new Rectangle(200, 200, 200, 200), ColorConstants.BLACK));
}

PdfCleaner.CleanUp(pdf, cleanUpLocations);
pdf.Close();
