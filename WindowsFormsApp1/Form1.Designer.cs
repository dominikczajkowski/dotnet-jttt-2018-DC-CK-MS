﻿namespace WindowsFormsApp1
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
            this.condition_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.word_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.action_combobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(661, 156);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(123, 52);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // url_textbox
            // 
            this.url_textbox.Location = new System.Drawing.Point(52, 84);
            this.url_textbox.Name = "url_textbox";
            this.url_textbox.Size = new System.Drawing.Size(320, 20);
            this.url_textbox.TabIndex = 1;
            // 
            // condition_combobox
            // 
            this.condition_combobox.DisplayMember = "1";
            this.condition_combobox.FormattingEnabled = true;
            this.condition_combobox.Items.AddRange(new object[] {
            "Sprawdź opis obrazka na stronie"});
            this.condition_combobox.Location = new System.Drawing.Point(251, 33);
            this.condition_combobox.Name = "condition_combobox";
            this.condition_combobox.Size = new System.Drawing.Size(121, 21);
            this.condition_combobox.TabIndex = 2;
            this.condition_combobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // word_textbox
            // 
            this.word_textbox.Location = new System.Drawing.Point(52, 111);
            this.word_textbox.Name = "word_textbox";
            this.word_textbox.Size = new System.Drawing.Size(320, 20);
            this.word_textbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wybierz typ warunku:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jeżeli to:";
            // 
            // action_combobox
            // 
            this.action_combobox.FormattingEnabled = true;
            this.action_combobox.Items.AddRange(new object[] {
            "Wyślij obrazek na email"});
            this.action_combobox.Location = new System.Drawing.Point(251, 186);
            this.action_combobox.Name = "action_combobox";
            this.action_combobox.Size = new System.Drawing.Size(121, 21);
            this.action_combobox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Wybierz typ akcji:";
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(486, 110);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(175, 20);
            this.email_textbox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wyślij na adres email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "to wykonaj to:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 220);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.action_combobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.word_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.condition_combobox);
            this.Controls.Add(this.url_textbox);
            this.Controls.Add(this.start_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TextBox url_textbox;
        private System.Windows.Forms.ComboBox condition_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox word_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox action_combobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
