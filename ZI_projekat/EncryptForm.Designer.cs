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
            this.open_file_btn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label_loaded_file = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input_textbox
            // 
            this.Input_textbox.Font = new System.Drawing.Font("Lexend Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_textbox.Location = new System.Drawing.Point(474, 34);
            this.Input_textbox.Name = "Input_textbox";
            this.Input_textbox.Size = new System.Drawing.Size(255, 120);
            this.Input_textbox.TabIndex = 0;
            this.Input_textbox.Text = "";
            // 
            // Output_textbox
            // 
            this.Output_textbox.Font = new System.Drawing.Font("Lexend Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.Output_textbox.Location = new System.Drawing.Point(474, 197);
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
            "CTR",
            "Bitmap (+PC6)"});
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
            // open_file_btn
            // 
            this.open_file_btn.Font = new System.Drawing.Font("Lexend SemiBold", 12.25F, System.Drawing.FontStyle.Bold);
            this.open_file_btn.Location = new System.Drawing.Point(48, 387);
            this.open_file_btn.Name = "open_file_btn";
            this.open_file_btn.Size = new System.Drawing.Size(140, 35);
            this.open_file_btn.TabIndex = 5;
            this.open_file_btn.Text = "Load file";
            this.open_file_btn.UseVisualStyleBackColor = true;
            this.open_file_btn.Click += new System.EventHandler(this.open_file_btn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label_loaded_file
            // 
            this.label_loaded_file.AutoSize = true;
            this.label_loaded_file.Font = new System.Drawing.Font("Lexend Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loaded_file.Location = new System.Drawing.Point(44, 352);
            this.label_loaded_file.Name = "label_loaded_file";
            this.label_loaded_file.Size = new System.Drawing.Size(56, 21);
            this.label_loaded_file.TabIndex = 6;
            this.label_loaded_file.Text = "Empty";
            // 
            // EncryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_loaded_file);
            this.Controls.Add(this.open_file_btn);
            this.Controls.Add(this.Decrypt_btn);
            this.Controls.Add(this.Encrypt_btn);
            this.Controls.Add(this.Alg_cmbox);
            this.Controls.Add(this.Output_textbox);
            this.Controls.Add(this.Input_textbox);
            this.Name = "EncryptForm";
            this.Text = "EncryptForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Input_textbox;
        private System.Windows.Forms.RichTextBox Output_textbox;
        private System.Windows.Forms.ComboBox Alg_cmbox;
        private System.Windows.Forms.Button Encrypt_btn;
        private System.Windows.Forms.Button Decrypt_btn;
        private System.Windows.Forms.Button open_file_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label_loaded_file;
    }
}