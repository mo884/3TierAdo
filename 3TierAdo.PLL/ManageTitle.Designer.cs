namespace _3TierAdo.PLL
{
    partial class ManageTitle
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
            listBox1 = new ListBox();
            textBox7 = new TextBox();
            update = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(537, 10);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(251, 424);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(70, 12);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(417, 32);
            textBox7.TabIndex = 7;
            // 
            // update
            // 
            update.BackColor = Color.IndianRed;
            update.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update.ForeColor = SystemColors.ButtonHighlight;
            update.Location = new Point(153, 386);
            update.Name = "update";
            update.Size = new Size(137, 48);
            update.TabIndex = 8;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 261);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(417, 32);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(70, 183);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(417, 32);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(70, 133);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(417, 32);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(70, 69);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(417, 32);
            textBox4.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(70, 329);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(417, 23);
            comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 15);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 14;
            label1.Text = "title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 72);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 15;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 136);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 16;
            label3.Text = "Advance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 186);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 17;
            label4.Text = "Royality";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 264);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 18;
            label5.Text = "ytdSales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 332);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 19;
            label6.Text = "Publisher";
            // 
            // ManageTitle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(update);
            Controls.Add(textBox7);
            Controls.Add(listBox1);
            Name = "ManageTitle";
            Text = "ManageTitle";
            Load += ManageTitle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private TextBox textBox7;
        private Button update;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}