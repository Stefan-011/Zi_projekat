using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI_projekat
{
    public partial class MainForm : Form
    {
  
        private Form currentChildForm;

        public MainForm()
        {
            InitializeComponent();           
        }
     

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Close();

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Desktop_panel.Controls.Add(childForm);
            Desktop_panel.Tag = childForm;
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void max_btn_Click(object sender, EventArgs e)
        {
            if(WindowState != FormWindowState.Maximized)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ChatForm_btn_Click(object sender, EventArgs e)
        {          
            ChatForm NewForm = new ChatForm();
            OpenChildForm(NewForm);
            FormName_panel.BackColor = Color.FromArgb(90, 142, 247);
            ChatForm_btn.BackColor = Color.FromArgb(90, 142, 247);
            LogoPanel.BackColor = Color.FromArgb(84, 133, 232); 
            EncryptForm_btn.BackColor = Color.FromArgb(22, 37, 70);
            FormName_label.Text = "Chat";

        }

        private void EncryptForm_btn_Click(object sender, EventArgs e)
        {
            EncryptForm NewForm = new EncryptForm();
            OpenChildForm(NewForm);
            EncryptForm_btn.BackColor = Color.FromArgb(0, 125, 87);
            ChatForm_btn.BackColor = Color.FromArgb(22, 37, 70);
            LogoPanel.BackColor = Color.FromArgb(2, 118, 86);
            FormName_panel.BackColor = Color.FromArgb(0, 125, 87);
            FormName_label.Text = "Encrypt";
        }
    }
}
