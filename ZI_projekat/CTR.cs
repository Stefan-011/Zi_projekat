using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ZI_projekat
{
    // reference:
    // https://www.youtube.com/watch?v=_QLU1CdgSE4 
    // https://cryptobook.nakov.com/symmetric-key-ciphers/cipher-block-modes

    internal class CTR
    {
        private int 
            Nonce, 
            Counter;

        private RC6 AES;
        private string key;
        private byte[] LoadedData;
        private byte[] CryptedData;

        public CTR()
        {
            Nonce = 55;
            Counter = 0;
            AES = new RC6();
            key = "aaaaccccbbbbeeee";
        }

        public void SetLoadedData(string data)
        {
            this.LoadedData = Encoding.ASCII.GetBytes(data);
        }

        public string GetCryptedData()
        {
            return Encoding.ASCII.GetString(CryptedData);
        }

        public void SetKey(string NewKey)
        {
            if(NewKey.Length != 0)
            this.key = NewKey;
        }

        public void Encrypt()
        {
            byte[] plainBytes = LoadedData;
            int BrojBlokova = GetBlockNumber(LoadedData.Length);
            byte[] SumBytes = BitConverter.GetBytes(this.Counter + this.Nonce);
            List<byte> plainByteExit = new List<byte>();
            AES.GenerateKey(Encoding.ASCII.GetBytes(key));
            while (BrojBlokova >  Counter)
            {
                byte[] Result = AES.Encrypt(SumBytes.ToString());

                for (int i = Counter  * 16,j = 0; i < (Counter + 1) * 16; i++,j++)
                {
                    if( i < plainBytes.Count())
                        plainByteExit.Add((byte)(Result[j] ^ plainBytes[i]));
                    else
                        plainByteExit.Add(Result[j]);
                }

                Counter++;
                SumBytes = BitConverter.GetBytes(this.Counter + this.Nonce);
            }

            Console.WriteLine(plainByteExit.Count);
            CryptedData = plainByteExit.ToArray();
            this.Decrypt();

        }

        public void Decrypt()
        {

            int BrojBlokova = GetBlockNumber(LoadedData.Length);

            this.Counter = 0;
            byte[] SumBytes = BitConverter.GetBytes(this.Counter + this.Nonce);

            List<byte> plainByteExit = new List<byte>();
            List<byte> exit = new List<byte>();
            AES.GenerateKey(Encoding.ASCII.GetBytes(key));

            while (BrojBlokova > Counter)
            {
                byte[] Result = AES.Encrypt(SumBytes.ToString());

                for (int i = Counter * 16, j = 0; i < (Counter + 1) * 16; i++, j++)
                {
                    if (i < LoadedData.Count())
                        plainByteExit.Add((byte)(Result[j] ^ LoadedData[i]));
                    else
                        plainByteExit.Add(Result[j]);
                }

                Counter++;
                SumBytes = BitConverter.GetBytes(this.Counter + this.Nonce);
            }

            foreach (var item in plainByteExit)
            {
                if(item !=0 )
                    exit.Add(item);
            }

            CryptedData = exit.ToArray();
            Console.WriteLine(Encoding.ASCII.GetString(exit.ToArray()));


        }

        public int GetBlockNumber(int bytes_count)
        {
            Console.WriteLine(bytes_count);
            int BlockNumber = 0;
            while(BlockNumber * 16  < bytes_count)
            {
                BlockNumber++;
            }
            return BlockNumber;
            
        }

        public void LoadFile(string filepath)
        {
            Byte[] buffer = null;

            var fileName = filepath;
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                long numBytes = new FileInfo(fileName).Length;
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

        public void SaveFile(string filename)
        {
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite);
                BinaryWriter bw = new BinaryWriter(fs);

                for (int i = 0; i < CryptedData.Length; i++)
                    bw.Write(CryptedData[i]);

                bw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
