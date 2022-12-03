using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_projekat
{
    internal class Knapsack
    {
        private int
            n,
            m;
        private int[] public_key;
        private int[] private_key;

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

        public int[] Encrypt(string PlainText)
        {
            byte[] RawBytes = Encoding.ASCII.GetBytes(PlainText);
            
            int 
                size = private_key.Length,
                n = 0;
            List<int> Sums = new List<int>();
            List<byte> clearbytes = new List<byte>();
            foreach(byte b in RawBytes)
            {
                if(b == 48 || b == 49)
                    clearbytes.Add(b);
            }


            /*  while (n + size < byteText.Length)
              {
                  int Mini_sum = 0;
                  for (int i = 0 + n; i < size + n; i++)
                  {
                      Mini_sum += byteText[i] * public_key[i - n];
                  }
                  Sums.Add(Mini_sum);
                  n += size;
              }*/
            /*   Console.WriteLine("enc\n");
               foreach (var item in byteText)
               {
                   Console.WriteLine(item);
               }*/
            while (n + size <= clearbytes.Count())
            {
                int Mini_sum = 0;
                for (int i = 0 + n; i < size + n; i++)
                {
                    if(clearbytes[i] == 49)
                    Mini_sum += 1 * public_key[i - n];
                }
                Sums.Add(Mini_sum);
                n += size;
            }

            

            return Sums.ToArray();
        }

        public int[] Decrypt(string PlainText)
        {
            int InverseModuo = FindInverseModuo(n, m);
            
          string[] itez =  PlainText.Split(' ');
          List<int> Array = new List<int>();
          List<string> byteList = new List<string>();
            List<int[]> nesto = new List<int[]>();
            foreach (var item in itez)
            {
                Array.Add(int.Parse(item));
            }

            for (int i = 0; i < Array.Count(); i++)
            {
                Array[i]= (Array[i] * InverseModuo) % m;
                nesto.Add(test(Array[i]));
                // Console.WriteLine(Array[i]);
                //{1, 2, 4, 10, 20, 40}. 
            }
            string str = "";
            for (int i = 0; i < nesto.Count(); i++)
            {
                for (int j = 0; j < private_key.Length; j++)
                {
                    if (DoesContain(private_key[j], nesto[i].ToArray()) == true)
                    {
                        str += "1";
                    }
                    else
                        str += "0";
                }
                str += " ";
            }
            Console.WriteLine(str);


            Console.WriteLine("dec\n");
            foreach(var item in byteList)
            {
                Console.WriteLine(item);
            }
            
            return new int[2];
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

        private int[] test(int broj)
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
            {
                if (find == item)
                    return true;
            }

            return false;
        }
   
    }
}
