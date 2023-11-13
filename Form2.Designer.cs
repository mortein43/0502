using System;

namespace _0502
{
    partial class Form2
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            KeyPress = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // KeyPress
            // 
            KeyPress.BorderStyle = BorderStyle.Fixed3D;
            KeyPress.Location = new Point(753, 63);
            KeyPress.Name = "KeyPress";
            KeyPress.Size = new Size(239, 468);
            KeyPress.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(753, 37);
            label1.Name = "label1";
            label1.Size = new Size(214, 26);
            label1.TabIndex = 1;
            label1.Text = "Клавіші, які нажимає користувач:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(220, 23);
            button1.TabIndex = 2;
            button1.Text = "Повернутись до налаштувань";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(249, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Звіт";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 540);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(KeyPress);
            Name = "Form2";
            Text = "Відстеження";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label KeyPress;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}