using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI_projekat
{
    public partial class EncryptForm : Form
    {
       private string 
            LoadedFilePath,
            LoadedFileName,
            PathToSave,
            LoadedFilePath2,
            LoadedFileName2;


        public EncryptForm()
        {
            InitializeComponent();
            label_loaded_file2.Visible = false;
            open_file_btn2.Visible = false;
            Compare_btn.Visible = false;
            Enc_text_btn.Visible = false;
            Dec_text_btn.Visible = false;
            test();
        }
        public void test() //
        {
        //    CTR test = new CTR();
           // test.Encrypt();
           // test.LoadMainFile();

            
        }


       



        public byte[] citajbitar(string filenamez)
        {
            Byte[] buffer = null;
          
            var fileName = @"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\"+filenamez;
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

            return buffer;
        }

        public void pisibitar(Byte[] buffer,string fileNamez)
        {
            var fileName = @"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\"+fileNamez;
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                BinaryWriter bw = new BinaryWriter(fs);

                for (int i = 0; i < buffer.Length; i++)
                    bw.Write(buffer[i]);

                bw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            
            switch (Alg_cmbox.Text)
            {
                case "RC6":
                    RC6 Crypter = new RC6();
                    Crypter.GenerateKey(Encoding.ASCII.GetBytes("aaaaccccbbbbeeee"));
                    Crypter.ReadFile(LoadedFilePath);
                    Crypter.EncryptFile();                   
                    Crypter.SaveFile(@""+PathToSave+"EncodedRC6.txt");

                    break;
                case "Bifid":
                    Bifid BifidCrypter = new Bifid();
                    BifidCrypter.Set_key("arikspyvxnuhfcqzemgwdbtol");
                    BifidCrypter.GenerateKey();                
                    BifidCrypter.ReadFile(LoadedFilePath);
                    BifidCrypter.EncryptFile();
                    BifidCrypter.SaveFile(@"" + PathToSave + "EncodedBifid.txt");
                 
                    break;
                case "Knapsack":
                    Knapsack KnapsackCrypter = new Knapsack();
                    KnapsackCrypter.GenerateKeys(1, 5);
                    KnapsackCrypter.ReadFile(LoadedFilePath);
                    KnapsackCrypter.EncryptFile();
                    KnapsackCrypter.SaveFile(@"" + PathToSave + "EncodedKnapsack.txt");

                    string output = "";
                    foreach (var item in KnapsackCrypter.GetCipherInt())
                    {
                        output += item+" ";
                    }

                    break;
                case "Bitmap (+PC6)":
                    RC6 BitmapCrypter = new RC6();
                    BitmapCrypter.GenerateKey(Encoding.ASCII.GetBytes("aaaaccccbbbbeeee"));
                    BitmapCrypter.ReadBitmap(LoadedFilePath);
                    BitmapCrypter.EcryptAndSaveBitmap(@"" + PathToSave + "SuspiciousBitmap.bmp");
                    break;
                case "CTR (+ RC6)":                  
                    CTR CTRCrypter = new CTR();
                    CTRCrypter.LoadFile(LoadedFilePath);
                    CTRCrypter.Encrypt();
                    CTRCrypter.SaveFile(@"" + PathToSave + "EncodedCTR.txt");
                    break;
                default:
                    break;
            }
        }

        private void Alg_cmbox_TextChanged(object sender, EventArgs e)
        {
            if ( Alg_cmbox.Text == "Tiger hash")
            {
                label_loaded_file2.Visible = true;
                open_file_btn2.Visible = true;
                Decrypt_btn.Visible = false;
                Encrypt_btn.Visible = false;
                Compare_btn.Visible = true;
            }
            else
            {
                label_loaded_file2.Visible = false;
                open_file_btn2.Visible = false;
                Decrypt_btn.Visible = true;
                Encrypt_btn.Visible = true;
                Compare_btn.Visible = false;
            }
            if(Alg_cmbox.Text == "Bifid" || Alg_cmbox.Text == "Knapsack")
            {
                Enc_text_btn.Visible = true;
                Dec_text_btn.Visible = true;
            }
            else
            {
                Enc_text_btn.Visible = false;
                Dec_text_btn.Visible = false;
            }
        }

        private void Enc_text_btn_Click(object sender, EventArgs e)
        {
            switch (Alg_cmbox.Text)
            {
                case "Bifid":
                    Bifid BifidCrypter = new Bifid();
                    BifidCrypter.Set_key(Key_textBox.Text);
                    BifidCrypter.GenerateKey();
                    Output_textbox.Text = BifidCrypter.Encrypt(Input_textbox.Text).ToString();
                    break;
                case "Knapsack":
                    Knapsack KnapsackCrypter = new Knapsack();
                    string[] nums = Key_textBox.Text.Split(',');
                    KnapsackCrypter.GenerateKeys(Int32.Parse(nums[0]), Int32.Parse(nums[1]));
                    int[] Result = KnapsackCrypter.Encrypt(Encoding.ASCII.GetBytes(Input_textbox.Text));

                    string output = "";
                    foreach (var item in Result)
                    {
                        output += item + " ";
                    }
                    Output_textbox.Text = output;
                    break;
                default:
                    break;
            }
        }

        private void Dec_text_btn_Click(object sender, EventArgs e)
        {
            switch (Alg_cmbox.Text)
            {
                case "Bifid":
                    Bifid BifidCrypter = new Bifid();
                    BifidCrypter.Set_key(Key_textBox.Text);
                    BifidCrypter.GenerateKey();
                    char[] Result = BifidCrypter.Decrypt(Input_textbox.Text);
                    foreach (var item in Result)
                    {
                        Output_textbox.Text +=item;

                    }             
                    break;
                case "Knapsack":
                    Knapsack KnapsackCrypter = new Knapsack();
                    string[] nums = Key_textBox.Text.Split(',');
                    KnapsackCrypter.GenerateKeys(Int32.Parse(nums[0]), Int32.Parse(nums[1]));
                    Output_textbox.Text = KnapsackCrypter.Decrypt(Input_textbox.Text);
                    break;
                default:
                    break;
            }
        }

        private void Compare_btn_Click(object sender, EventArgs e)
        {
           
            if(LoadedFilePath2 != "" && LoadedFilePath != "" && LoadedFilePath2 != null && LoadedFilePath != null)
            {
                Tiger_hash HashObj = new Tiger_hash();
                HashObj.LoadMainFile(LoadedFilePath);
                HashObj.LoadFileToCompare(LoadedFilePath2);
                HashObj.HashLoadedFile();
                HashObj.HashToCompareFile();
                if (HashObj.CompareHashs())
                    MessageBox.Show("FILES ARE SAME");
                else
                    MessageBox.Show("FILES ARE NOT THE SAME");
            }

        }

     

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            switch (Alg_cmbox.Text)
            {
                case "RC6":
                    RC6 RC6Crypter = new RC6();
                    RC6Crypter.GenerateKey(Encoding.ASCII.GetBytes("aaaaccccbbbbeeee"));
                    RC6Crypter.ReadFile(LoadedFilePath);
                    RC6Crypter.DecryptFile();
                    RC6Crypter.SaveFile(@"" + PathToSave + "DecodedRC6.txt");

                    Input_textbox.Text = Encoding.UTF8.GetString(RC6Crypter.GetLoadedData());                   
                    Output_textbox.Text = Encoding.UTF8.GetString(RC6Crypter.GetChangedData());

                    break;
                case "Bifid":
                    Bifid BifidCrypter = new Bifid();
                    BifidCrypter.Set_key("arikspyvxnuhfcqzemgwdbtol");
                    BifidCrypter.GenerateKey();                
                    BifidCrypter.ReadFile(LoadedFilePath);                  
                    BifidCrypter.DecryptFile();
                    BifidCrypter.SaveFile(@"" + PathToSave + "DecodedBifid.txt");

                    Input_textbox.Text = (BifidCrypter.GetLoadedText());
                    Output_textbox.Text = (BifidCrypter.GetCipherText());
                    
                    break;
                case "Knapsack":
                    Knapsack KnapsackCrypter = new Knapsack();
                    KnapsackCrypter.GenerateKeys(1, 5);
                    KnapsackCrypter.ReadFile(LoadedFilePath);
                    KnapsackCrypter.DecryptFile();
                    KnapsackCrypter.SaveFile(@"" + PathToSave + "DecodedKnapsack.txt");

                    Input_textbox.Text = (KnapsackCrypter.GetReadText());
                    string output= "";
                    foreach (var item in KnapsackCrypter.GetCipherText())
                    {
                        output += item;
                    }
                    Output_textbox.Text = output;
                    break;
                case "Bitmap (+PC6)":
                    RC6 BitmapCrypter = new RC6();
                    BitmapCrypter.GenerateKey(Encoding.ASCII.GetBytes("aaaaccccbbbbeeee"));
                    BitmapCrypter.ReadBitmap(LoadedFilePath);
                    BitmapCrypter.DecryptAndSaveBitmap(@"" + PathToSave + "NewBitmap.bmp");
                    break;
                case "CTR (+ RC6)":
                    CTR CTRCrypter = new CTR();
                    CTRCrypter.LoadFile(LoadedFilePath);
                    CTRCrypter.Decrypt();
                    CTRCrypter.SaveFile(@"" + PathToSave + "DecodedCTR.txt");
                    break;
                default:
                    break;
            }
        }

       

        private void open_file_btn_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            LoadedFilePath = openFileDialog.FileName;

            if (LoadedFilePath == "openFileDialog")
                return;


            string[] list = LoadedFilePath.Split('\\');
            LoadedFileName = list[list.Length - 1];
            list[list.Length - 1] = "";
            label_loaded_file.Text = LoadedFileName;

            PathToSave  = "";
            foreach (var item in list)
            {
                if(item != "")
                PathToSave += item+"\\";
            }

            Console.WriteLine(LoadedFileName);
            Console.WriteLine(LoadedFilePath);
            Console.WriteLine(PathToSave);
        }

        private void open_file_btn2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            LoadedFilePath2 = openFileDialog1.FileName;

            if (LoadedFilePath2 == "openFileDialog")
                return;


            string[] list = LoadedFilePath2.Split('\\');
            LoadedFileName2 = list[list.Length - 1];
            list[list.Length - 1] = "";
            label_loaded_file2.Text = LoadedFileName2;

            PathToSave = "";
            foreach (var item in list)
            {
                if (item != "")
                    PathToSave += item + "\\";
            }

            Console.WriteLine(LoadedFileName2);
            Console.WriteLine(LoadedFilePath2);
        }
    }
   
}


