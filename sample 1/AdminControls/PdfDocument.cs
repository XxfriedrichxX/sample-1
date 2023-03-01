using System;
using System.Drawing.Printing;

namespace sample_1.AdminControls
{
    internal class PdfDocument
    {
        private iTextSharp.text.pdf.PdfReader reader;

        public PdfDocument(iTextSharp.text.pdf.PdfReader reader)
        {
            this.reader = reader;
        }

        internal PrintDocument CreatePrintDocument()
        {
            throw new NotImplementedException();
        }

        internal static PdfDocument Load(string filePath)
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}