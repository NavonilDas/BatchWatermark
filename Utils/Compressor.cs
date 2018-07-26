using System;
using System.Drawing.Imaging;
using System.Drawing;

namespace BatchWatermark
{
    class Compressor
    {
        public static void SaveImage(string loc,Image img,int q)
        {
            if (q < 0 || q > 100)
                throw new ArgumentOutOfRangeException("Quality Should be between 0 to 100");
            EncoderParameter qualityParam = new EncoderParameter(Encoder.Quality, q);
            ImageCodecInfo jpegCodec = GetEncoder("image/jpeg");
            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;
            img.Save(loc, jpegCodec, encoderParams);
        }

        private static ImageCodecInfo GetEncoder(string mimeType)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType == mimeType)
                    return codecs[i];

            return null;
        }
    }
}
