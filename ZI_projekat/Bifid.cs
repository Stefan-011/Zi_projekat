using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_projekat
{
    internal class Bifid
    {
        private char[,] key_square;
        private int block_size;
        private char[] key;

        public void Set_block_size(int size)
        {
            if (size > 0)
                this.block_size = size;
        }

        public void Set_key(string newkey)
        {
            if (newkey.Length == 25)
                this.key = newkey.ToArray();
        }

        public Bifid()
        {
            this.key_square = new char[5, 5];
            this.block_size = 5; // Default
        }

        public void GenerateKey()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    key_square[i, j] = key[i*5 + j];
                }
            }
        }


        public string Encrypt(string text)
        {

            List<int> Row = new List<int>();
            List<int> Column = new List<int>();
            List<int> Cipher = new List<int>();
               


            foreach (char letter in text.ToLower())
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (key_square[i, j] == letter)
                        {
                            Row.Add(i);
                            Column.Add(j);
                        }                 
                    }
                }
            }
            int n = 0;

           while(Cipher.Count() != Row.Count() + Column.Count())
            {
              for (int i = 0+n; i < block_size + n; i++)
              {
                   if( i < Row.Count())
                      Cipher.Add(Row[i]);

                }

              for (int j = 0+n; j < block_size + n; j++)
              {
                    if (j < Column.Count())
                        Cipher.Add(Column[j]);
              }
                n += block_size;
            }

            foreach (var item in Cipher)
            {
                Console.WriteLine(item);
            }
            return " ";
        }
    }
}
