using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace PruebaPDFFree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PdfDocument pdf = new PdfDocument();
            //pdf.Info.Title = "My First PDF";
            //PdfPage pdfPage = pdf.AddPage();
            //XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            //XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            //graph.DrawString("This is my first PDF document", font, XBrushes.Black, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center);
            //string pdfFilename = "firstpage.pdf";
            //pdf.Save(pdfFilename);
            //Process.Start(pdfFilename);


            string html = File.ReadAllText("C:\\Users\\k697344\\Documents\\Comex PPG\\Documentacion\\Ejemplo.html");
            PdfDocument pdf = PdfGenerator.GeneratePdf(html, PageSize.Letter);
            pdf.Save("document.pdf");
            //PdfDocument pdf = PdfGenerator.GeneratePdf("<p><h1>Hello World</h1>This is html rendered text</p>", PageSize.A4);
            //pdf.Save("document.pdf");
        }
    }
}
