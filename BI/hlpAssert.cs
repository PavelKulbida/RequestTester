using System;
using System.Drawing;
using System.IO;

namespace BI
{
    public static class hlpAssert
    {
        /// <summary>
        /// Compare Streams
        /// </summary>
        public static void AreEqual(Stream stream1, Stream stream2)
        {
            const int bufferSize = 2048 * 2;
            var buffer1 = new byte[bufferSize];
            var buffer2 = new byte[bufferSize];

            stream1.Position = 0;
            stream2.Position = 0;

            while (true)
            {
                int count1 = stream1.Read(buffer1, 0, bufferSize);
                int count2 = stream2.Read(buffer2, 0, bufferSize);

                if (count1 != count2)
                {
                    throw new Exception("Stream is different size");
                }

                if (count1 == 0)
                {
                    break;
                }

                int iterations = (int)Math.Ceiling((double)count1 / sizeof(Int64));
                for (int i = 0; i < iterations; i++)
                {
                    if (BitConverter.ToInt64(buffer1, i * sizeof(Int64)) != BitConverter.ToInt64(buffer2, i * sizeof(Int64)))
                    {
                        throw new Exception("Stream is different content");
                    }
                }
            }
        }

        /// <summary>
        /// Compare Images
        /// </summary>
        private static void AreEqual(Bitmap img1, Bitmap img2)
        {
            bool testEqual = true;

            try
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    for (int x = 0; x < img1.Width; x++)
                    {
                        // Если цвета пикселей в одной точке координат не совпадают
                        Color c1 = img1.GetPixel(x, y);
                        Color c2 = img2.GetPixel(x, y);

                        if (c1 != c2)
                        {
                            testEqual = false;
                            break;
                        }
                    }

                    if (!testEqual)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error from comparing images", ex);
            }

            if (!testEqual)
            {
                throw new Exception("Images is different");
            }
        }


        public static void IsNotNullOrEmpty(string param)
        {
            if (string.IsNullOrEmpty(param))
            {
                throw new ArgumentException("param is null or empty");
            }
        }

        public static void IsNotNull(object param)
        {
            if (null == param)
            {
                throw new ArgumentException("param is null");
            }
        }

    }
}
