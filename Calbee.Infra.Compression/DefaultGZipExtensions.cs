using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace Calbee.Infra.Compression
{
    public static class DefaultGZipExtensions
    {

        public static byte[] CompressByGZip(this Stream instance, long dataLength)
        {
            if (instance == null)
                return null;

            byte[] gzipCompressedBytes = null;

            int bufferSize = 4096;
            long index = 0;

            byte[] bufferBytes = new byte[bufferSize];

            MemoryStream ms = new MemoryStream();

            using (GZipStream gzip = new GZipStream(ms, CompressionMode.Compress))
            {
                BinaryReader reader = new BinaryReader(instance);

                while (index < dataLength)
                {
                    bufferBytes = reader.ReadBytes(bufferSize);

                    gzip.Write(bufferBytes, 0, bufferBytes.Length);

                    index += bufferSize;
                }

                reader.Close();

                gzip.Flush();
                gzip.Close();
            }

            gzipCompressedBytes = ms.ToArray();

            ms.Close();
            ms.Dispose();


            instance.Close();
            instance.Dispose();


            return gzipCompressedBytes;
        }

        public static byte[] CompressByGZip(this byte[] instance)
        {
            if (instance == null)
                return null;

            byte[] gzipCompressedBytes = null;


            MemoryStream ms = new MemoryStream();

            using (GZipStream gzip = new GZipStream(ms, CompressionMode.Compress))
            {
                gzip.Write(instance, 0, instance.Length);

                gzip.Close();
            }

            gzipCompressedBytes = ms.ToArray();

            ms.Close();
            ms.Dispose();

            return gzipCompressedBytes;
        }

        public static byte[] DecompressByGZip(this byte[] instance)
        {
            if (instance == null)
                return null;

            MemoryStream ms = new MemoryStream(instance);
            MemoryStream msOut = new MemoryStream();
            int diff = 0;
            int bytesReadCount = 0;
            byte[] decompressBytes = null;

            //TODO: should optimize for memory buffer
            byte[] buffer = new byte[instance.Length];
            ms.Position = 0;

            using (GZipStream gzip = new GZipStream(ms, CompressionMode.Decompress, false))
            {
                bytesReadCount = gzip.Read(buffer, 0, buffer.Length);

                while (bytesReadCount > 0)
                {
                    diff = buffer.Length - bytesReadCount;
                    msOut.Write(buffer, 0, buffer.Length - diff);
                    bytesReadCount = gzip.Read(buffer, 0, buffer.Length);
                }
                gzip.Close();
            }

            decompressBytes = msOut.ToArray();

            msOut.Close();
            msOut.Dispose();

            return decompressBytes;
        }
    }
}
