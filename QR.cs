using Gma.QrCodeNet.Encoding.Windows.Render;
using Gma.QrCodeNet.Encoding;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesoCC
{
    internal class QR
    {
        public QR() { }

        public Image RandQR()
        {
            StringBuilder buff = new StringBuilder();
            buff.Append(IntRand(0, DateTime.Now.Year));
            buff.Append(IntRand(10, 99));
            buff.Append(IntRand(100, 99));
            buff.Append(IntRand(1000, 999));
            return GenerarQR(buff.ToString());
        }

        private int IntRand(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max + 1);
        }

        public Image GenerarQR(string code)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();

            qrEncoder.TryEncode(code, out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();

            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);

            var imageTemporal = new Bitmap(ms);
            var image = new Bitmap(imageTemporal, new Size(200, 200));
            return image;
        }
    }
}
