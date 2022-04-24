using System.ComponentModel;

namespace SSTattoo
{
    partial class AddReceptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(23, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 18);
            this.label.TabIndex = 0;
            this.label.Text = "Дата:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Клиент:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(23, 155);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(225, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(284, 177);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(225, 21);
            this.comboBox3.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(284, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Рабочий:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "0";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(284, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Цена:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(283, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Тату:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Время:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {"9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00"});
            this.comboBox4.Location = new System.Drawing.Point(23, 100);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(80, 21);
            this.comboBox4.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(283, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 20);
            this.textBox2.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(23, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 11);
            this.label6.TabIndex = 23;
            this.label6.Text = "Телефон:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button3.Location = new System.Drawing.Point(284, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 49);
            this.button3.TabIndex = 24;
            this.button3.Text = "Оформить заказ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 271);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label);
            this.Name = "AddReceptionForm";
            this.Text = "Добавить заказ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddReceptionForm_FormClosed);
            this.Load += new System.EventHandler(this.AddReceptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ComboBox comboBox2;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}