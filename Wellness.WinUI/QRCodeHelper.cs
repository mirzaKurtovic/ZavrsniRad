using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.Common;
using ZXing;
using ZXing.QrCode;
using System.Drawing;
using System.IO;

namespace Wellness.WinUI
{
    class QRCodeHelper
    {

        public QRCodeHelper()
        {

        }

        //https://www.codeproject.com/Articles/1005081/Basic-with-QR-Code-using-Zxing-Library
        public  byte[] GenerateQRCode(string text="")
        {
            QrCodeEncodingOptions options;
            options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 250,
                Height = 250,
            };

            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;

            if (String.IsNullOrWhiteSpace(text) || String.IsNullOrEmpty(text))
            {
                return null;
            }
            else
            {
                var qr = new ZXing.BarcodeWriter();
                qr.Options = options;
                qr.Format = ZXing.BarcodeFormat.QR_CODE;
                var result = new Bitmap(qr.Write(text.Trim()));
                var resultBit = ImageToByte2(result);
                return resultBit;
            }
        }
        public string DecodeQRCode(Image img)
        {
            BarcodeReader Reader = new BarcodeReader() { AutoRotate = true, TryInverted = true };
            Bitmap bitmap = new Bitmap(img);
            Result result = Reader.Decode(bitmap);

            try
            {
                string decode = result.ToString();
                return decode;
            }
            catch(Exception ex)
            {
                return string.Empty;
            }


        }


        //https://stackoverflow.com/questions/7350679/convert-a-bitmap-into-a-byte-array
        public static byte[] ImageToByte2(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        //https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings
        public string GenerateRandomString(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);


            return finalString;
        }



    }
}
