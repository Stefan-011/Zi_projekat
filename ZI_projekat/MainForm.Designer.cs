namespace ZI_projekat
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.EncryptForm_btn = new System.Windows.Forms.Button();
            this.ChatForm_btn = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.FormName_panel = new System.Windows.Forms.Panel();
            this.FormName_label = new System.Windows.Forms.Label();
            this.Desktop_panel = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            this.FormName_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.MenuPanel.Controls.Add(this.EncryptForm_btn);
            this.MenuPanel.Controls.Add(this.ChatForm_btn);
            this.MenuPanel.Controls.Add(this.LogoPanel);
            this.MenuPanel.Location = new System.Drawing.Point(-3, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(224, 874);
            this.MenuPanel.TabIndex = 0;
            // 
            // EncryptForm_btn
            // 
            this.EncryptForm_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EncryptForm_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptForm_btn.FlatAppearance.BorderSize = 0;
            this.EncryptForm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptForm_btn.Font = new System.Drawing.Font("Lexend SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.EncryptForm_btn.ForeColor = System.Drawing.Color.White;
            this.EncryptForm_btn.Image = ((System.Drawing.Image)(resources.GetObject("EncryptForm_btn.Image")));
            this.EncryptForm_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EncryptForm_btn.Location = new System.Drawing.Point(0, 305);
            this.EncryptForm_btn.Margin = new System.Windows.Forms.Padding(75, 77, 75, 77);
            this.EncryptForm_btn.Name = "EncryptForm_btn";
            this.EncryptForm_btn.Size = new System.Drawing.Size(225, 115);
            this.EncryptForm_btn.TabIndex = 2;
            this.EncryptForm_btn.Text = "Encrypt";
            this.EncryptForm_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EncryptForm_btn.UseVisualStyleBackColor = true;
            this.EncryptForm_btn.Click += new System.EventHandler(this.EncryptForm_btn_Click);
            // 
            // ChatForm_btn
            // 
            this.ChatForm_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.ChatForm_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChatForm_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChatForm_btn.FlatAppearance.BorderSize = 0;
            this.ChatForm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChatForm_btn.Font = new System.Drawing.Font("Lexend SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.ChatForm_btn.ForeColor = System.Drawing.Color.White;
            this.ChatForm_btn.Image = ((System.Drawing.Image)(resources.GetObject("ChatForm_btn.Image")));
            this.ChatForm_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChatForm_btn.Location = new System.Drawing.Point(0, 157);
            this.ChatForm_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChatForm_btn.Name = "ChatForm_btn";
            this.ChatForm_btn.Size = new System.Drawing.Size(225, 115);
            this.ChatForm_btn.TabIndex = 0;
            this.ChatForm_btn.Text = "Chat";
            this.ChatForm_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChatForm_btn.UseVisualStyleBackColor = false;
            this.ChatForm_btn.Click += new System.EventHandler(this.ChatForm_btn_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.LogoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoPanel.BackgroundImage")));
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogoPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(224, 123);
            this.LogoPanel.TabIndex = 1;
            // 
            // FormName_panel
            // 
            this.FormName_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormName_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.FormName_panel.Controls.Add(this.FormName_label);
            this.FormName_panel.Location = new System.Drawing.Point(220, 0);
            this.FormName_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FormName_panel.Name = "FormName_panel";
            this.FormName_panel.Size = new System.Drawing.Size(1160, 126);
            this.FormName_panel.TabIndex = 1;
            // 
            // FormName_label
            // 
            this.FormName_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FormName_label.AutoSize = true;
            this.FormName_label.Font = new System.Drawing.Font("Lexend", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormName_label.ForeColor = System.Drawing.Color.White;
            this.FormName_label.Location = new System.Drawing.Point(309, 0);
            this.FormName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormName_label.Name = "FormName_label";
            this.FormName_label.Size = new System.Drawing.Size(377, 114);
            this.FormName_label.TabIndex = 0;
            this.FormName_label.Text = "Welcome";
            // 
            // Desktop_panel
            // 
            this.Desktop_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Desktop_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(83)))), ((int)(((byte)(148)))));
            this.Desktop_panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Desktop_panel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Desktop_panel.Location = new System.Drawing.Point(220, 119);
            this.Desktop_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Desktop_panel.Name = "Desktop_panel";
            this.Desktop_panel.Size = new System.Drawing.Size(1366, 904);
            this.Desktop_panel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 872);
            this.Controls.Add(this.Desktop_panel);
            this.Controls.Add(this.FormName_panel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPanel.ResumeLayout(false);
            this.FormName_panel.ResumeLayout(false);
            this.FormName_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Button EncryptForm_btn;
        private System.Windows.Forms.Button ChatForm_btn;
        private System.Windows.Forms.Panel FormName_panel;
        private System.Windows.Forms.Label FormName_label;
        private System.Windows.Forms.Panel Desktop_panel;
    }
}

