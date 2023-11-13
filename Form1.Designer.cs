namespace _0502
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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (Global.needExit)
            {
                Environment.Exit(0);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            checkBoxPatriot = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(283, 336);
            button1.Name = "button1";
            button1.Size = new Size(227, 76);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(544, 39);
            label1.Name = "label1";
            label1.Size = new Size(220, 15);
            label1.TabIndex = 1;
            label1.Text = "Режими роботи програми для клавіш:";
            // 
            // checkBoxPatriot
            // 
            checkBoxPatriot.AutoSize = true;
            checkBoxPatriot.Location = new Point(550, 78);
            checkBoxPatriot.Name = "checkBoxPatriot";
            checkBoxPatriot.Size = new Size(103, 19);
            checkBoxPatriot.TabIndex = 2;
            checkBoxPatriot.Text = "Патріотичний";
            checkBoxPatriot.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(550, 118);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(170, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "З графічним інтерфейсом";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(550, 158);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(135, 19);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "Прихований режим";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(550, 225);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 142);
            textBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.Location = new Point(550, 190);
            label2.Name = "label2";
            label2.Size = new Size(237, 32);
            label2.TabIndex = 8;
            label2.Text = "Введіть список слів розділених пробілом для виходу із прихованого режиму:";
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Вихід";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 450);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBoxPatriot);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Налаштування";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private CheckBox checkBoxPatriot;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
    }
}