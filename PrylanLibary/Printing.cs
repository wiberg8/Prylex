using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeLib.Barcode;
using PrylanLibary.Models;

namespace PrylanLibary
{
    public static class Printing
    {
        public static string Exception { get; set; }

        public static void PrintSerieNrLabel(string serieNr, string printer)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (object sender, PrintPageEventArgs e) =>
            {
                Graphics g = e.Graphics;
                Font font = new Font("Arial", 10);
                SolidBrush brush = new SolidBrush(System.Drawing.Color.Black);

                try
                {
                    PDF417 PDF417 = new PDF417
                    {
                        Data = serieNr,
                        UOM = UnitOfMeasure.CM,
                        BackgroundColor = Color.White,
                        ModuleColor = Color.Black,
                        ImageFormat = System.Drawing.Imaging.ImageFormat.Png,
                        ImageWidth = 3
                    };
                    PDF417.drawBarcode("barcode.jpg");
                    g.DrawImage(Image.FromFile("barcode.jpg", true), new Point(3, 39));
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                }
            };
            printDocument.DefaultPageSettings.Landscape = true;
            printDocument.PrinterSettings.PrinterName = printer;
            printDocument.Print();
        }


        public static void PrintLabel(Artikel artikel, Person person, string printer)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (object sender, PrintPageEventArgs e) =>
            {
                Graphics g = e.Graphics;
                Font font = new Font("Arial", 10, FontStyle.Bold);
                SolidBrush brush = new SolidBrush(System.Drawing.Color.Black);

                g.DrawString("Stenhamraskolan", font, brush, new Rectangle(3, 5, 200, 100));
                g.DrawString($"{artikel.DatorNamn} / {person.Tillhorighet}", font, brush, new Rectangle(3, 25, 200, 100));
                g.DrawString($"{person.Fornamn} {person.Efternamn}", font, brush, new Rectangle(3, 43, 300, 100));

                try
                {
                    PDF417 PDF417 = new PDF417
                    {
                        Data = artikel.SerieNr,
                        UOM = UnitOfMeasure.CM,
                        BackgroundColor = Color.White,
                        ModuleColor = Color.Black,
                        ImageFormat = System.Drawing.Imaging.ImageFormat.Png,
                        ImageWidth = 3
                    };
                    PDF417.drawBarcode("barcode.jpg");
                    g.DrawImage(Image.FromFile("barcode.jpg", true), new Point(3, 63));
                }
                catch(Exception ex)
                {
                    Logger.Log(ex);
                }
            };
            printDocument.DefaultPageSettings.Landscape = true;
            printDocument.PrinterSettings.PrinterName = printer;
            printDocument.Print();
        }

        public static IEnumerable<string> GetPrinters()
        {
            return PrinterSettings.InstalledPrinters.Cast<string>();
        }
    }
}
