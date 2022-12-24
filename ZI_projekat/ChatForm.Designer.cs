namespace ZI_projekat
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button Start_btn;
            System.Windows.Forms.Button Connect_btn;
            this.IP_srv_text = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Port_srv_text = new System.Windows.Forms.TextBox();
            this.IP_cli_text = new System.Windows.Forms.TextBox();
            this.Port_cli_text = new System.Windows.Forms.TextBox();
            this.IP_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChatScreenBox = new System.Windows.Forms.RichTextBox();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.Send_btn = new System.Windows.Forms.Button();
            this.Alg_cmbox = new System.Windows.Forms.ComboBox();
            this.Code = new System.Windows.Forms.Label();
            this.Key_text = new System.Windows.Forms.TextBox();
            this.Key = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            Start_btn = new System.Windows.Forms.Button();
            Connect_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IP_srv_text
            // 
            this.IP_srv_text.Font = new System.Drawing.Font("Lexend", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_srv_text.Location = new System.Drawing.Point(55, 49);
            this.IP_srv_text.Name = "IP_srv_text";
            this.IP_srv_text.Size = new System.Drawing.Size(179, 24);
            this.IP_srv_text.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Port_srv_text
            // 
            this.Port_srv_text.Font = new System.Drawing.Font("Lexend", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port_srv_text.Location = new System.Drawing.Point(55, 108);
            this.Port_srv_text.Name = "Port_srv_text";
            this.Port_srv_text.Size = new System.Drawing.Size(179, 24);
            this.Port_srv_text.TabIndex = 2;
            // 
            // IP_cli_text
            // 
            this.IP_cli_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IP_cli_text.Font = new System.Drawing.Font("Lexend", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_cli_text.Location = new System.Drawing.Point(586, 38);
            this.IP_cli_text.Name = "IP_cli_text";
            this.IP_cli_text.Size = new System.Drawing.Size(179, 24);
            this.IP_cli_text.TabIndex = 3;
            // 
            // Port_cli_text
            // 
            this.Port_cli_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Port_cli_text.Font = new System.Drawing.Font("Lexend", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port_cli_text.Location = new System.Drawing.Point(586, 107);
            this.Port_cli_text.Name = "Port_cli_text";
            this.Port_cli_text.Size = new System.Drawing.Size(179, 24);
            this.Port_cli_text.TabIndex = 4;
            // 
            // IP_lbl
            // 
            this.IP_lbl.AutoSize = true;
            this.IP_lbl.Font = new System.Drawing.Font("Lexend", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_lbl.Location = new System.Drawing.Point(12, 40);
            this.IP_lbl.Name = "IP_lbl";
            this.IP_lbl.Size = new System.Drawing.Size(26, 24);
            this.IP_lbl.TabIndex = 5;
            this.IP_lbl.Text = "IP";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lexend", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP";
            // 
            // portlbl
            // 
            this.portlbl.AutoSize = true;
            this.portlbl.Font = new System.Drawing.Font("Lexend", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portlbl.Location = new System.Drawing.Point(0, 108);
            this.portlbl.Name = "portlbl";
            this.portlbl.Size = new System.Drawing.Size(49, 24);
            this.portlbl.TabIndex = 8;
            this.portlbl.Text = "PORT";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lexend", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lexend", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Server";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lexend", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(647, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Client";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // ChatScreenBox
            // 
            this.ChatScreenBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatScreenBox.Font = new System.Drawing.Font("Lexend", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatScreenBox.Location = new System.Drawing.Point(55, 182);
            this.ChatScreenBox.Name = "ChatScreenBox";
            this.ChatScreenBox.Size = new System.Drawing.Size(710, 211);
            this.ChatScreenBox.TabIndex = 13;
            this.ChatScreenBox.Text = "";
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessagetextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.MessagetextBox.Font = new System.Drawing.Font("Lexend", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessagetextBox.Location = new System.Drawing.Point(55, 412);
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.Size = new System.Drawing.Size(618, 26);
            this.MessagetextBox.TabIndex = 14;
            // 
            // Send_btn
            // 
            this.Send_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Send_btn.Font = new System.Drawing.Font("Lexend", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_btn.Location = new System.Drawing.Point(683, 399);
            this.Send_btn.Name = "Send_btn";
            this.Send_btn.Size = new System.Drawing.Size(82, 39);
            this.Send_btn.TabIndex = 15;
            this.Send_btn.Text = "Send";
            this.Send_btn.UseVisualStyleBackColor = true;
            this.Send_btn.Click += new System.EventHandler(this.Send_btn_Click);
            // 
            // Alg_cmbox
            // 
            this.Alg_cmbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Alg_cmbox.Font = new System.Drawing.Font("Lexend Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alg_cmbox.FormattingEnabled = true;
            this.Alg_cmbox.Items.AddRange(new object[] {
            "RC6",
            "Bifid",
            "Knapsack",
            "CTR (+ RC6)",
            "Bitmap (+RC6)",
            "Tiger hash"});
            this.Alg_cmbox.Location = new System.Drawing.Point(307, 41);
            this.Alg_cmbox.Name = "Alg_cmbox";
            this.Alg_cmbox.Size = new System.Drawing.Size(170, 32);
            this.Alg_cmbox.TabIndex = 16;
            // 
            // Code
            // 
            this.Code.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Code.AutoSize = true;
            this.Code.Font = new System.Drawing.Font("Lexend", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code.Location = new System.Drawing.Point(363, 9);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(46, 24);
            this.Code.TabIndex = 18;
            this.Code.Text = "Code";
            // 
            // Key_text
            // 
            this.Key_text.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Key_text.Cursor = System.Windows.Forms.Cursors.Default;
            this.Key_text.Font = new System.Drawing.Font("Lexend", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Key_text.Location = new System.Drawing.Point(307, 108);
            this.Key_text.Name = "Key_text";
            this.Key_text.Size = new System.Drawing.Size(170, 26);
            this.Key_text.TabIndex = 19;
            // 
            // Key
            // 
            this.Key.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Key.AutoSize = true;
            this.Key.Font = new System.Drawing.Font("Lexend", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Key.Location = new System.Drawing.Point(363, 81);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(36, 24);
            this.Key.TabIndex = 21;
            this.Key.Text = "Key";
            // 
            // Start_btn
            // 
            Start_btn.Font = new System.Drawing.Font("Lexend", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Start_btn.Location = new System.Drawing.Point(98, 137);
            Start_btn.Name = "Start_btn";
            Start_btn.Size = new System.Drawing.Size(82, 39);
            Start_btn.TabIndex = 23;
            Start_btn.Text = "Start";
            Start_btn.UseVisualStyleBackColor = true;
            Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Connect_btn
            // 
            Connect_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            Connect_btn.Font = new System.Drawing.Font("Lexend", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Connect_btn.Location = new System.Drawing.Point(633, 137);
            Connect_btn.Name = "Connect_btn";
            Connect_btn.Size = new System.Drawing.Size(82, 39);
            Connect_btn.TabIndex = 24;
            Connect_btn.Text = "Connect";
            Connect_btn.UseVisualStyleBackColor = true;
            Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(Connect_btn);
            this.Controls.Add(Start_btn);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.Key_text);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.Alg_cmbox);
            this.Controls.Add(this.Send_btn);
            this.Controls.Add(this.MessagetextBox);
            this.Controls.Add(this.ChatScreenBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IP_lbl);
            this.Controls.Add(this.Port_cli_text);
            this.Controls.Add(this.IP_cli_text);
            this.Controls.Add(this.Port_srv_text);
            this.Controls.Add(this.IP_srv_text);
            this.Name = "ChatForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IP_srv_text;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Port_srv_text;
        private System.Windows.Forms.TextBox IP_cli_text;
        private System.Windows.Forms.TextBox Port_cli_text;
        private System.Windows.Forms.Label IP_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label portlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.RichTextBox ChatScreenBox;
        private System.Windows.Forms.TextBox MessagetextBox;
        private System.Windows.Forms.Button Send_btn;
        private System.Windows.Forms.ComboBox Alg_cmbox;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.TextBox Key_text;
        private System.Windows.Forms.Label Key;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}