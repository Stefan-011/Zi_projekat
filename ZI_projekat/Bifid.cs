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
            this.block_size = 100; // Default
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


        public char[] Encrypt(string text)
        {

            List<int> Row = new List<int>();
            List<int> Column = new List<int>();
            List<int> Cipher = new List<int>();
            List<char> StringCipher = new List<char>();


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

            /*    Console.WriteLine("U enkode row:\n");
                foreach (var item in Row)
                {
                    Console.WriteLine(item);
                }

                 Console.WriteLine("colunm:\n");
                 foreach (var item in Column)
                 {
                     Console.WriteLine(item);
                 }*/

            while (Cipher.Count() != Row.Count() + Column.Count())
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

            

            for (int i = 0; i < Cipher.Count(); i+=2)
            {
                StringCipher.Add(key_square[Cipher[i], Cipher[i + 1]]);
            }


            

            return StringCipher.ToArray();
        }

        public char[] Decrypt(string text)
        {
            List<int> Row = new List<int>();
            List<int> Column = new List<int>();
            List<int> Cipher = new List<int>();
            List<char> StringCipher = new List<char>();

            foreach (char letter in text.ToLower())
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (key_square[i, j] == letter)
                        {
                            Cipher.Add(i);
                            Cipher.Add(j);
                        }
                    }
                }
            }
           

            int n = 0 ,itr = 0;
            while (Cipher.Count() != Row.Count() + Column.Count())
            {
                int NewBlockSize = 0;
                if ( 2 * block_size > Cipher.Count() - Row.Count() - Column.Count())
                {
                    NewBlockSize = (Cipher.Count() - Row.Count() - Column.Count()) / 2;
                }

                if (NewBlockSize == 0)
                    n++;
                for (int i = itr; i < block_size * n + NewBlockSize; i++, itr++)
                {
                    if (i < Cipher.Count())
                        Row.Add(Cipher[i]);

                }
                if (NewBlockSize == 0)
                    n++;
               
                for (int j = itr; j < block_size * n +2 * NewBlockSize; j++, itr++)
                {
                    if (j < Cipher.Count())
                        Column.Add(Cipher[j]);
                }
                if(NewBlockSize != 0)
                    n++;

            }

            /*   Console.WriteLine("U dekocde row:\n");
               foreach (var item in Row)
               {
                   Console.WriteLine(item);
               }

               Console.WriteLine("colunm:\n");
               foreach (var item in Column)
               {
                   Console.WriteLine(item);
               }*/

            for (int i = 0; i < Row.Count(); i++)
            {
                StringCipher.Add(key_square[Row[i], Column[i]]);
            }


            return StringCipher.ToArray();
        }
    }
}
