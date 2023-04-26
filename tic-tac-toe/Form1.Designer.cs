namespace tic_tac_toe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(135, 135);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(153, 12);
            button2.Name = "button2";
            button2.Size = new Size(135, 135);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(294, 12);
            button3.Name = "button3";
            button3.Size = new Size(135, 135);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(12, 153);
            button4.Name = "button4";
            button4.Size = new Size(135, 135);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(153, 153);
            button5.Name = "button5";
            button5.Size = new Size(135, 135);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(294, 153);
            button6.Name = "button6";
            button6.Size = new Size(135, 135);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button1_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(12, 294);
            button7.Name = "button7";
            button7.Size = new Size(135, 135);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button1_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(153, 294);
            button8.Name = "button8";
            button8.Size = new Size(135, 135);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button1_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(294, 294);
            button9.Name = "button9";
            button9.Size = new Size(135, 135);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button1_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.White;
            button10.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(435, 12);
            button10.Name = "button10";
            button10.Size = new Size(160, 58);
            button10.TabIndex = 9;
            button10.Text = "Start a new game";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Zeros", "Crosses" });
            comboBox1.Location = new Point(494, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(101, 29);
            comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(430, 80);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 11;
            label1.Text = "Motion:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(603, 441);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private ComboBox comboBox1;
        private Label label1;
    }
}