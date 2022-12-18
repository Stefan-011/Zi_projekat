using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_projekat
{
    // referenca https://www.geeksforgeeks.org/knapsack-encryption-algorithm-in-cryptography/

  
    internal class Knapsack
    {
        private int
            n,
            m;
        private int[] 
            public_key, 
            private_key, 
            CipherInt;   

        private byte[] ReadBinary;
        
        private string 
            ReadText, 
            CipherText;
        

        public string GetReadText()
        {
            return ReadText;
        }
        public byte[] GetReadBinary()
        {
            return ReadBinary;
        }
        public int[] GetCipherInt()
        {
            return CipherInt;
        }
        public string GetCipherText()
        {
            return CipherText;
        }

        public Knapsack()
        {
            n = 31; // default
            m = 110; // default
        }

        public void set_n_m(int _m, int _n)
        {
            if (m > private_key.Sum() && _m % _n != 0)
            { n = _n; 
              m = _m; }              
        }


        public void GenerateKeys(int input,int keysize)
        {
            public_key = new int[keysize];
            private_key = new int[keysize];

            private_key[0] = input;
            for (int i = 1; i < keysize; i++)
            {
                private_key[i] = private_key.Sum() + private_key.Sum();
            }

            for (int i = 0; i < keysize; i++)
            {
                public_key[i] = (private_key[i] * n) % m;
            }
        }

        public int[] Encrypt(byte[] PlainText)
        {
            //byte[] RawBytes = Encoding.ASCII.GetBytes(PlainText);
            byte[] RawBytes = PlainText;
            int 
                size = private_key.Length,
                blockJump = 0;

            List<int> Sums = new List<int>();
            List<byte> clearbytes = new List<byte>();
            foreach(byte b in RawBytes)
            {
                if(b == 48 || b == 49)
                    clearbytes.Add(b);
            }

            while (blockJump + size <= clearbytes.Count())
            {
                int Mini_sum = 0;
                for (int i = 0 + blockJump; i < size + blockJump; i++)
                {
                    if(clearbytes[i] == 49)
                    Mini_sum += 1 * public_key[i - blockJump];
                }
                Sums.Add(Mini_sum);
                blockJump += size;
            }
         
            return Sums.ToArray();
        }

        public string Decrypt(string PlainText)
        {
            int InverseModuo = FindInverseModuo(n, m);
            
          string[] Numbers =  PlainText.Split(' ');
          List<int> Array = new List<int>();
          List<string> byteList = new List<string>();
          List<int[]> Helper = new List<int[]>();
            foreach (var item in Numbers)
            {
                if(item != "")
                Array.Add(int.Parse(item));
            }

            for (int i = 0; i < Array.Count(); i++)
            {
                Array[i]= (Array[i] * InverseModuo) % m;
                Helper.Add(GetOnes(Array[i]));
            }
            string str = "";
            for (int i = 0; i < Helper.Count(); i++)
            {
                for (int j = 0; j < private_key.Length; j++)
                {
                    if (DoesContain(private_key[j], Helper[i].ToArray()) == true)
                    {
                        str += "1";
                    }
                    else
                        str += "0";
                }
                str += " ";
            }
            return str;
        }

        private int FindInverseModuo(int n,int m)
        {
            int im = 0 , res = 0;
            while( res != 1 )
            {
                im++;
                res = (n * im) % m;           
            }
            return  im;
        }

        private int[] GetOnes(int broj)
        {
            int sum = 0;
            List<int> list = new List<int>();
            for (int i = private_key.Length-1; i >= 0 ; i--)
            {
                if(private_key[i] <= broj && sum + private_key[i] <= broj)
                {
                    sum += private_key[i];
                    list.Add(private_key[i]);
                }
            }
            return list.ToArray();
        }
        
        private bool DoesContain(int find, int[] array)
        {
            foreach (var item in array)
                if (find == item)
                    return true;
            return false;
        }

        public void ReadFile(string filepath)
        {
            ReadBinary = File.ReadAllBytes(filepath);
            ReadText = Encoding.UTF8.GetString(ReadBinary);
        }

        public void EncryptFile()
        {
            CipherInt = Encrypt(ReadBinary);
            CipherText = null;
        }

        public void DecryptFile()
        {
            CipherText = Decrypt(ReadText);
            CipherInt = null;
        }

        public void SaveFile(string filepath)
        {
            string str = "";
            if(CipherInt != null)
                foreach (var item in CipherInt)
                {
                    str += item + " ";
                }
            else if (CipherText != null)
                foreach (var item in CipherText)
                {
                    str += item + "";
                }

            File.WriteAllText(filepath, str);
        }
   
    }
}
