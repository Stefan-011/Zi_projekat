using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace ZI_projekat
{
    // referenca https://www.youtube.com/watch?v=1oKwQK_8OF8
    internal class RC6
    {
        private const int W = 32;
        private const int R = 16;
        private const uint P32 = 0xB7E15163;
        private const uint Q32 = 0x9E3779B9;
        private static uint[] Key = new uint[2 * R + 4];
        private byte[] LoadedData;
        private byte[] ChangedData;
        private Bitmap LoadedBitmap;
        //private Bitmap ChangedBitmap;


        public byte[] GetLoadedData()
        {
           return LoadedData;
        }

        public byte[] GetChangedData()
        {
            return ChangedData;
        }

        private UInt32 RightShift(UInt32 vrednost, int pomeraj) 
        {
            return (vrednost >> pomeraj) | (vrednost << (W - pomeraj));
        }


        private UInt32 LeftShift(UInt32 vrednost, int pomeraj) 
        {
            return (vrednost << pomeraj) | (vrednost >> (W - pomeraj));
        }


        private byte[] ConvertFromUInt32ToByteArray(UInt32[] Niz)
        {
            byte[] arrayBytes = new byte[Niz.Length * 4];

            for (int i = 0; i < Niz.Length; i++)
            {
                if(Niz[i]!= 0x00)
                {
                    byte[] converted = BitConverter.GetBytes(Niz[i]);
                    converted.CopyTo(arrayBytes, i * 4);
                }
            }
            return arrayBytes;
        }


        public void GenerateKey(byte[] Kljuc)
        {
            int c = 4,
                i,
                j;

            uint[] L = new uint[c];

            for (i = 0; i < c; i++)
            {
                L[i] = BitConverter.ToUInt32(Kljuc, i * c);
            }

            Key[0] = P32;

            for (i = 1; i < 2 * R + 4; i++)
                Key[i] = Key[i - 1] + Q32;

            uint A, B;
            A = B = 0;
            i = j = 0;

            int V = 3 * Math.Max(c, 2 * R + 4);
            for (int s = 1; s <= V; s++)
            {
                A = Key[i] = LeftShift((Key[i] + A + B), 3);
                B = L[j] = LeftShift((L[j] + A + B), (int)(A + B));
                i = (i + 1) % (2 * R + 4);
                j = (j + 1) % c;

            }
        }


        public byte[] Encrypt(string InputText)
        {
            uint A, B, C, D;
            
            byte[] byteText = Encoding.UTF8.GetBytes(InputText);
            int i = byteText.Length;

            while (i % 16 != 0)
                i++;
           
            byte[] text = new byte[i];
            
            byteText.CopyTo(text, 0);
            byte[] cipherText = new byte[i];

            for (i = 0; i < text.Length; i = i + 16)
            {
                
                A = BitConverter.ToUInt32(text, i);
                B = BitConverter.ToUInt32(text, i + 4);
                C = BitConverter.ToUInt32(text, i + 8);
                D = BitConverter.ToUInt32(text, i + 12);
               
                B = B + Key[0];
                D = D + Key[1];

                for (int j = 1; j <= R; j++)
                {
                    uint t = LeftShift((B * (2 * B + 1)), (int)(Math.Log(W, 2)));
                    uint u = LeftShift((D * (2 * D + 1)), (int)(Math.Log(W, 2)));

                    A = (LeftShift((A ^ t), (int)u)) + Key[j * 2];
                    C = (LeftShift((C ^ u), (int)t)) + Key[j * 2 + 1];

                    uint temp = A;
                    A = B;
                    B = C;
                    C = D;
                    D = temp;
                }
                A = A + Key[2 * R + 2];
                C = C + Key[2 * R + 3];
                
                uint[] tempWords = new uint[4] { A, B, C, D };

                byte[] block = ConvertFromUInt32ToByteArray(tempWords);
               
                block.CopyTo(cipherText, i);
            }
            return cipherText;
        }


        public byte[] Decrypt(byte[] cipherText)
        {
            uint A, B, C, D;
            int i;
            byte[] plainText = new byte[cipherText.Length];
            Console.WriteLine(cipherText.Length);
            for (i = 0; i < cipherText.Length; i = i + 16)
            {

                    A = BitConverter.ToUInt32(cipherText, i);
                    B = BitConverter.ToUInt32(cipherText, i + 4);
                    C = BitConverter.ToUInt32(cipherText, i + 8);
                    if (i+12 < cipherText.Length)
                    D = BitConverter.ToUInt32(cipherText, i + 12);
                    else
                    D = BitConverter.ToUInt32(cipherText, i);



                C = C - Key[2 * R + 3];
                A = A - Key[2 * R + 2];

                for (int j = R; j >= 1; j--)
                {
                    uint temp = D;
                    D = C;
                    C = B;
                    B = A;
                    A = temp;

                    uint u = LeftShift((D * (2 * D + 1)), (int)Math.Log(W, 2));
                    uint t = LeftShift((B * (2 * B + 1)), (int)Math.Log(W, 2));

                    C = RightShift((C - Key[2 * j + 1]), (int)t) ^ u;
                    A = RightShift((A - Key[2 * j]), (int)u) ^ t;
                }
                D = D - Key[1];
                B = B - Key[0];
               
                uint[] tempWords = new uint[4] { A, B, C, D };
                byte[] block = ConvertFromUInt32ToByteArray(tempWords);
                
                block.CopyTo(plainText, i);
            }
            return plainText;
        }

        public void ReadFile(string filename)
        {
            Byte[] buffer = null;
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                long numBytes = new FileInfo(filename).Length;
                buffer = br.ReadBytes((int)numBytes);

                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            LoadedData = buffer;
        }

        public void EncryptFile()
        {
            
            if (LoadedData != null)
                ChangedData = Encrypt((Encoding.UTF8.GetString(LoadedData)));        
        }

        public void DecryptFile()
        {             
            if (LoadedData != null)
                ChangedData = Decrypt(LoadedData);
        }

        public void SaveFile(string filename)
        {
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite);
                BinaryWriter bw = new BinaryWriter(fs);

                for (int i = 0; i < ChangedData.Length; i++)
                    bw.Write(ChangedData[i]);

                bw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private byte[] EncryptBITMAP(Bitmap bmp)
        {
            uint A, B, C, D;
            ImageConverter converter = new ImageConverter();
            byte[] byteText = (byte[])converter.ConvertTo(bmp, typeof(byte[]));
            var header = byteText.Take(54).ToArray();
            byteText = byteText.Skip(54).ToArray();

            int i = byteText.Length;

            while (i % 16 != 0)
                i++;

            byte[] text = new byte[i];

            byteText.CopyTo(text, 0);
            byte[] cipherText = new byte[i];

            for (i = 0; i < text.Length; i = i + 16)
            {

                A = BitConverter.ToUInt32(text, i);
                B = BitConverter.ToUInt32(text, i + 4);
                C = BitConverter.ToUInt32(text, i + 8);
                D = BitConverter.ToUInt32(text, i + 12);

                B = B + Key[0];
                D = D + Key[1];

                for (int j = 1; j <= R; j++)
                {
                    uint t = LeftShift((B * (2 * B + 1)), (int)(Math.Log(W, 2)));
                    uint u = LeftShift((D * (2 * D + 1)), (int)(Math.Log(W, 2)));

                    A = (LeftShift((A ^ t), (int)u)) + Key[j * 2];
                    C = (LeftShift((C ^ u), (int)t)) + Key[j * 2 + 1];

                    uint temp = A;
                    A = B;
                    B = C;
                    C = D;
                    D = temp;
                }
                A = A + Key[2 * R + 2];
                C = C + Key[2 * R + 3];

                uint[] tempWords = new uint[4] { A, B, C, D };

                byte[] block = ConvertFromUInt32ToByteArray(tempWords);

                block.CopyTo(cipherText, i);
            }
             cipherText = Combine(header, cipherText);
            return cipherText;
        }

        private byte[] DecryptBitmap(Bitmap bmp)
        {
            ImageConverter converter = new ImageConverter();
            byte[] byteText = (byte[])converter.ConvertTo(bmp, typeof(byte[]));
            var header = byteText.Take(54).ToArray();
            byte[] retval;
            byteText = byteText.Skip(54).ToArray();
            retval = Combine(header,Decrypt(byteText));
            return retval;
        }
        public static byte[] Combine(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }

        public void EcryptAndSaveBitmap(string filename)
        {
            byte[] EcryptedBitmap = EncryptBITMAP(LoadedBitmap);
            File.WriteAllBytes(filename, EcryptedBitmap);
        }

        public void ReadBitmap(string filename)
        {
            LoadedBitmap = (Bitmap)Image.FromFile(filename);
        }

        public void DecryptAndSaveBitmap(string filename)
        {
            byte[] EcryptedBitmap = DecryptBitmap(LoadedBitmap);
            File.WriteAllBytes(filename, EcryptedBitmap);
        }
    }
}