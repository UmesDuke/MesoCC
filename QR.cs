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

        private string randText;
        private Image randImage;

        public string RandText { get => randText; }
        public Image RandImage { get => randImage; }

        public QR() { }

        public void RandQR()
        {
            StringBuilder buff = new StringBuilder();
            buff.Append(IntRand(0, DateTime.Now.Year));
            buff.Append(IntRand(0, 9));
            buff.Append(IntRand(0, 100));
            buff.Append(IntRand(0, 99));

            this.randText = buff.ToString();
            this.randImage = GenerarQR(buff.ToString());
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
