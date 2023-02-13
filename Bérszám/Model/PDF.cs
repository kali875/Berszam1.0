using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;

namespace Bérszám.Model
{
    internal class PDF
    {
        PdfDocument document;
        PdfPage page;
        XGraphics gfx;
        XFont font;
        public  PDF()
        {

            document = new PdfDocument();
            page = document.AddPage();
            gfx = XGraphics.FromPdfPage(page);
            font = new XFont("Verdana", 20, XFontStyle.Bold);
            gfx.DrawString("My First PD", font, XBrushes.Black,new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
            string filename = "FirstPDFDocument.pdf";
            document.Save(filename);
            //Process.Start(filename);
        }

        private void createpdf() 
        {

        }
    }
}
