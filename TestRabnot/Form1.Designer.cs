namespace TestRabnot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            comboBox3 = new ComboBox();
            label3 = new Label();
            comboBox4 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "שישי" });
            comboBox1.Location = new Point(613, 208);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(87, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(629, 162);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            comboBox2.Location = new Point(483, 208);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(87, 23);
            comboBox2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(499, 162);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "היום בחודש";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.ImeMode = ImeMode.Disable;
            comboBox3.Items.AddRange(new object[] { "תשרי", "חשוון", "כסליו", "טבת", "שבט", "אדר א", "אדר ב", "ניסן", "איי", "סיוון", "תמוז", "אב", "אלול" });
            comboBox3.Location = new Point(354, 208);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(87, 23);
            comboBox3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 162);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 1;
            label3.Text = "חודש";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג" });
            comboBox4.Location = new Point(226, 208);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(87, 23);
            comboBox4.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 162);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 1;
            label4.Text = "שנה";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(364, 94);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 1;
            label5.Text = "כתיבת תאריך";
            // 
            // button1
            // 
            button1.Location = new Point(98, 186);
            button1.Name = "button1";
            button1.Size = new Size(92, 64);
            button1.TabIndex = 2;
            button1.Text = "הוספת תאריך";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_ClickAddDate;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(613, 162);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 1;
            label6.Text = "יום";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox3;
        private Label label3;
        private ComboBox comboBox4;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
    }
}
