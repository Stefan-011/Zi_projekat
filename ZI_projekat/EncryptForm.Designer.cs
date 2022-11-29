namespace ZI_projekat
{
    partial class EncryptForm
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
            this.Input_textbox = new System.Windows.Forms.RichTextBox();
            this.Output_textbox = new System.Windows.Forms.RichTextBox();
            this.Alg_cmbox = new System.Windows.Forms.ComboBox();
            this.Encrypt_btn = new System.Windows.Forms.Button();
            this.Decrypt_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input_textbox
            // 
            this.Input_textbox.Font = new System.Drawing.Font("Lexend Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_textbox.Location = new System.Drawing.Point(278, 43);
            this.Input_textbox.Name = "Input_textbox";
            this.Input_textbox.Size = new System.Drawing.Size(255, 120);
            this.Input_textbox.TabIndex = 0;
            this.Input_textbox.Text = "";
            // 
            // Output_textbox
            // 
            this.Output_textbox.Font = new System.Drawing.Font("Lexend Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.Output_textbox.Location = new System.Drawing.Point(278, 268);
            this.Output_textbox.Name = "Output_textbox";
            this.Output_textbox.Size = new System.Drawing.Size(255, 120);
            this.Output_textbox.TabIndex = 1;
            this.Output_textbox.Text = "";
            // 
            // Alg_cmbox
            // 
            this.Alg_cmbox.Font = new System.Drawing.Font("Lexend Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alg_cmbox.FormattingEnabled = true;
            this.Alg_cmbox.Items.AddRange(new object[] {
            "RC6",
            "Bifid",
            "Knapsack",
            "CTR"});
            this.Alg_cmbox.Location = new System.Drawing.Point(38, 43);
            this.Alg_cmbox.Name = "Alg_cmbox";
            this.Alg_cmbox.Size = new System.Drawing.Size(170, 32);
            this.Alg_cmbox.TabIndex = 2;
            // 
            // Encrypt_btn
            // 
            this.Encrypt_btn.Font = new System.Drawing.Font("Lexend SemiBold", 12.25F, System.Drawing.FontStyle.Bold);
            this.Encrypt_btn.Location = new System.Drawing.Point(38, 123);
            this.Encrypt_btn.Name = "Encrypt_btn";
            this.Encrypt_btn.Size = new System.Drawing.Size(160, 40);
            this.Encrypt_btn.TabIndex = 3;
            this.Encrypt_btn.Text = "Encrypt";
            this.Encrypt_btn.UseVisualStyleBackColor = true;
            this.Encrypt_btn.Click += new System.EventHandler(this.Encrypt_btn_Click);
            // 
            // Decrypt_btn
            // 
            this.Decrypt_btn.Font = new System.Drawing.Font("Lexend SemiBold", 12.25F, System.Drawing.FontStyle.Bold);
            this.Decrypt_btn.Location = new System.Drawing.Point(38, 197);
            this.Decrypt_btn.Name = "Decrypt_btn";
            this.Decrypt_btn.Size = new System.Drawing.Size(160, 40);
            this.Decrypt_btn.TabIndex = 4;
            this.Decrypt_btn.Text = "Decrypt";
            this.Decrypt_btn.UseVisualStyleBackColor = true;
            this.Decrypt_btn.Click += new System.EventHandler(this.Decrypt_btn_Click);
            // 
            // EncryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Decrypt_btn);
            this.Controls.Add(this.Encrypt_btn);
            this.Controls.Add(this.Alg_cmbox);
            this.Controls.Add(this.Output_textbox);
            this.Controls.Add(this.Input_textbox);
            this.Name = "EncryptForm";
            this.Text = "EncryptForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Input_textbox;
        private System.Windows.Forms.RichTextBox Output_textbox;
        private System.Windows.Forms.ComboBox Alg_cmbox;
        private System.Windows.Forms.Button Encrypt_btn;
        private System.Windows.Forms.Button Decrypt_btn;
    }
}