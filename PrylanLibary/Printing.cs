using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrylanLibary.Models;
using MessagingToolkit.QRCode;

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
                    //Image barcode = IronBarCode.BarcodeWriter.CreateBarcode(serieNr, IronBarCode.BarcodeEncoding.PDF417, 300, 50).Image;
                    //g.DrawImage(barcode, new Point(3, 39));
                    //Image barcode = Image.FromFile("");
                    var encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                    encoder.QRCodeEncodeMode = MessagingToolkit.QRCode.Codec.QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
                    encoder.QRCodeScale = 3;
                    var bitMap = encoder.Encode(serieNr, Encoding.UTF8);
                    const string fileName = @"qrcode.bmp";
                    bitMap.Save(fileName);
                    g.DrawImageUnscaled(Image.FromFile(fileName), 65, 10);
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
                    //Image barcode = IronBarCode.BarcodeWriter.CreateBarcode(artikel.SerieNr, IronBarCode.BarcodeEncoding.PDF417, 300, 50).Image;
                    //g.DrawImage(barcode, new Point(3, 63));
                    var encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                    //Encoding unicode = Encoding.Unicode;
                    //encoder.CalQrcode(unicode.GetBytes(artikel.SerieNr));
                    encoder.QRCodeEncodeMode = MessagingToolkit.QRCode.Codec.QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
                    encoder.QRCodeScale = 1;
                    const string fileName = @"qrcode.bmp";
                    using (var bitMap = encoder.Encode(artikel.SerieNr, Encoding.UTF8))
                    {
                        bitMap.Save(fileName);
                    }
                    using (Image image = Image.FromFile(fileName))
                    {
                        g.DrawImageUnscaled(image, 3, 63);
                    }
                    g?.Dispose();
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
