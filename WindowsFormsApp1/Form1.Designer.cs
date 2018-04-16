namespace WindowsFormsApp1
{
    partial class Form1
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
            this.start_button = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.url_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.word_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.exec_button = new System.Windows.Forms.Button();
            this.cln_button = new System.Windows.Forms.Button();
            this.deserial = new System.Windows.Forms.Button();
            this.serial_button = new System.Windows.Forms.Button();
            this.Task_name_textbox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.weatherbtt = new System.Windows.Forms.Button();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(23, 236);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(123, 52);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Dodaj zadanie";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // url_textbox
            // 
            this.url_textbox.Location = new System.Drawing.Point(48, 70);
            this.url_textbox.Name = "url_textbox";
            this.url_textbox.Size = new System.Drawing.Size(320, 20);
            this.url_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // word_textbox
            // 
            this.word_textbox.Location = new System.Drawing.Point(48, 97);
            this.word_textbox.Name = "word_textbox";
            this.word_textbox.Size = new System.Drawing.Size(320, 20);
            this.word_textbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jeżeli to:";
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(432, 73);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(175, 20);
            this.email_textbox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wyślij na adres email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "to wykonaj to:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(375, 122);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(394, 108);
            this.listBox1.TabIndex = 13;
            // 
            // exec_button
            // 
            this.exec_button.Location = new System.Drawing.Point(435, 253);
            this.exec_button.Name = "exec_button";
            this.exec_button.Size = new System.Drawing.Size(105, 54);
            this.exec_button.TabIndex = 14;
            this.exec_button.Text = "Wykonaj";
            this.exec_button.UseVisualStyleBackColor = true;
            this.exec_button.Click += new System.EventHandler(this.exec_button_Click);
            // 
            // cln_button
            // 
            this.cln_button.Location = new System.Drawing.Point(565, 253);
            this.cln_button.Name = "cln_button";
            this.cln_button.Size = new System.Drawing.Size(96, 54);
            this.cln_button.TabIndex = 15;
            this.cln_button.Text = "Czyść";
            this.cln_button.UseVisualStyleBackColor = true;
            this.cln_button.Click += new System.EventHandler(this.cln_button_Click);
            // 
            // deserial
            // 
            this.deserial.Location = new System.Drawing.Point(686, 253);
            this.deserial.Name = "deserial";
            this.deserial.Size = new System.Drawing.Size(75, 25);
            this.deserial.TabIndex = 16;
            this.deserial.Text = "Deserialize";
            this.deserial.UseVisualStyleBackColor = true;
            this.deserial.Click += new System.EventHandler(this.deserial_Click);
            // 
            // serial_button
            // 
            this.serial_button.Location = new System.Drawing.Point(686, 284);
            this.serial_button.Name = "serial_button";
            this.serial_button.Size = new System.Drawing.Size(75, 23);
            this.serial_button.TabIndex = 17;
            this.serial_button.Text = "Serialize";
            this.serial_button.UseVisualStyleBackColor = true;
            this.serial_button.Click += new System.EventHandler(this.serial_button_Click);
            // 
            // Task_name_textbox
            // 
            this.Task_name_textbox.Location = new System.Drawing.Point(197, 247);
            this.Task_name_textbox.Name = "Task_name_textbox";
            this.Task_name_textbox.Size = new System.Drawing.Size(100, 20);
            this.Task_name_textbox.TabIndex = 18;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(822, 341);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.serial_button);
            this.tabPage1.Controls.Add(this.Task_name_textbox);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.email_textbox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.deserial);
            this.tabPage1.Controls.Add(this.start_button);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.url_textbox);
            this.tabPage1.Controls.Add(this.exec_button);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cln_button);
            this.tabPage1.Controls.Add(this.word_textbox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(814, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Obrazki";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cityInput);
            this.tabPage2.Controls.Add(this.weatherbtt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(814, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pogoda";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // weatherbtt
            // 
            this.weatherbtt.Location = new System.Drawing.Point(371, 85);
            this.weatherbtt.Name = "weatherbtt";
            this.weatherbtt.Size = new System.Drawing.Size(75, 44);
            this.weatherbtt.TabIndex = 0;
            this.weatherbtt.Text = "sprawdź pogodę";
            this.weatherbtt.UseVisualStyleBackColor = true;
            this.weatherbtt.Click += new System.EventHandler(this.weatherbtt_Click);
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(360, 45);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(100, 20);
            this.cityInput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 374);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TextBox url_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox word_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button exec_button;
        private System.Windows.Forms.Button cln_button;
        private System.Windows.Forms.Button deserial;
        private System.Windows.Forms.Button serial_button;
        private System.Windows.Forms.TextBox Task_name_textbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Button weatherbtt;
    }
}

