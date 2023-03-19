namespace Zadanie1
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
            textBoxInput = new TextBox();
            button1 = new Button();
            textBoxOutput = new TextBox();
            programOutput = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(8, 7);
            textBoxInput.Margin = new Padding(2, 2, 2, 2);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(175, 111);
            textBoxInput.TabIndex = 0;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(186, 7);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(180, 41);
            button1.TabIndex = 1;
            button1.Text = "przetłumacz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(370, 7);
            textBoxOutput.Margin = new Padding(2, 2, 2, 2);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(175, 248);
            textBoxOutput.TabIndex = 2;
            // 
            // programOutput
            // 
            programOutput.Location = new Point(8, 145);
            programOutput.Margin = new Padding(2, 2, 2, 2);
            programOutput.Multiline = true;
            programOutput.Name = "programOutput";
            programOutput.Size = new Size(175, 110);
            programOutput.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(187, 58);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(81, 41);
            button2.TabIndex = 4;
            button2.Text = "popraw 1 błąd";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(284, 58);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 41);
            button3.TabIndex = 5;
            button3.Text = "popraw 2 błędy";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(programOutput);
            Controls.Add(textBoxOutput);
            Controls.Add(button1);
            Controls.Add(textBoxInput);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Button button1;
        private TextBox textBoxOutput;
        private TextBox programOutput;
        private Button button2;
        private Button button3;
    }
}