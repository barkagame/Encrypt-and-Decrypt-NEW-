namespace EncryptAndDecrypt
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.textBox_txt = new System.Windows.Forms.TextBox();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_decryptPRO = new System.Windows.Forms.Button();
            this.button_encryptPRO = new System.Windows.Forms.Button();
            this.checkBox_NoGenerate = new System.Windows.Forms.CheckBox();
            this.textBox_qwe = new System.Windows.Forms.TextBox();
            this.checkBox_NoMassage = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(12, 12);
            this.textBox_key.Multiline = true;
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(248, 42);
            this.textBox_key.TabIndex = 0;
            this.textBox_key.Text = "Ключ";
            // 
            // button_encrypt
            // 
            this.button_encrypt.Location = new System.Drawing.Point(12, 131);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(172, 51);
            this.button_encrypt.TabIndex = 1;
            this.button_encrypt.Text = "Зашифровать";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // textBox_txt
            // 
            this.textBox_txt.Location = new System.Drawing.Point(266, 12);
            this.textBox_txt.Multiline = true;
            this.textBox_txt.Name = "textBox_txt";
            this.textBox_txt.Size = new System.Drawing.Size(216, 42);
            this.textBox_txt.TabIndex = 2;
            this.textBox_txt.Text = "Текст";
            // 
            // button_decrypt
            // 
            this.button_decrypt.Location = new System.Drawing.Point(266, 131);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(172, 51);
            this.button_decrypt.TabIndex = 3;
            this.button_decrypt.Text = "Расшифровать";
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(488, 12);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(216, 42);
            this.textBox_result.TabIndex = 4;
            this.textBox_result.Text = "Результат";
            // 
            // button_decryptPRO
            // 
            this.button_decryptPRO.Location = new System.Drawing.Point(266, 202);
            this.button_decryptPRO.Name = "button_decryptPRO";
            this.button_decryptPRO.Size = new System.Drawing.Size(172, 51);
            this.button_decryptPRO.TabIndex = 6;
            this.button_decryptPRO.Text = "Расшифровать";
            this.button_decryptPRO.UseVisualStyleBackColor = true;
            this.button_decryptPRO.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_encryptPRO
            // 
            this.button_encryptPRO.Location = new System.Drawing.Point(12, 202);
            this.button_encryptPRO.Name = "button_encryptPRO";
            this.button_encryptPRO.Size = new System.Drawing.Size(172, 51);
            this.button_encryptPRO.TabIndex = 5;
            this.button_encryptPRO.Text = "PROЗашифровать";
            this.button_encryptPRO.UseVisualStyleBackColor = true;
            this.button_encryptPRO.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox_NoGenerate
            // 
            this.checkBox_NoGenerate.AutoSize = true;
            this.checkBox_NoGenerate.Location = new System.Drawing.Point(444, 220);
            this.checkBox_NoGenerate.Name = "checkBox_NoGenerate";
            this.checkBox_NoGenerate.Size = new System.Drawing.Size(84, 17);
            this.checkBox_NoGenerate.TabIndex = 7;
            this.checkBox_NoGenerate.Text = "NoGenerate";
            this.checkBox_NoGenerate.UseVisualStyleBackColor = true;
            // 
            // textBox_qwe
            // 
            this.textBox_qwe.Location = new System.Drawing.Point(12, 60);
            this.textBox_qwe.Multiline = true;
            this.textBox_qwe.Name = "textBox_qwe";
            this.textBox_qwe.Size = new System.Drawing.Size(225, 42);
            this.textBox_qwe.TabIndex = 8;
            this.textBox_qwe.Text = "Ключ";
            // 
            // checkBox_NoMassage
            // 
            this.checkBox_NoMassage.AutoSize = true;
            this.checkBox_NoMassage.Location = new System.Drawing.Point(534, 220);
            this.checkBox_NoMassage.Name = "checkBox_NoMassage";
            this.checkBox_NoMassage.Size = new System.Drawing.Size(83, 17);
            this.checkBox_NoMassage.TabIndex = 9;
            this.checkBox_NoMassage.Text = "NoMassage";
            this.checkBox_NoMassage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "CompanyШИФР";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_NoMassage);
            this.Controls.Add(this.textBox_qwe);
            this.Controls.Add(this.checkBox_NoGenerate);
            this.Controls.Add(this.button_decryptPRO);
            this.Controls.Add(this.button_encryptPRO);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.textBox_txt);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.textBox_key);
            this.Name = "Form1";
            this.Text = "PROШИФР";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.TextBox textBox_txt;
        private System.Windows.Forms.Button button_decrypt;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_decryptPRO;
        private System.Windows.Forms.Button button_encryptPRO;
        private System.Windows.Forms.CheckBox checkBox_NoGenerate;
        private System.Windows.Forms.TextBox textBox_qwe;
        private System.Windows.Forms.CheckBox checkBox_NoMassage;
        private System.Windows.Forms.Button button1;
    }
}

