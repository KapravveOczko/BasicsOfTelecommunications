namespace Zadanie1Podejscie2
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
            buttonTranslate = new Button();
            button4Parrity = new Button();
            textBoxInput = new TextBox();
            textBoxTranslate = new TextBox();
            button8Parrity = new Button();
            textBoxOutput = new TextBox();
            button4Decode = new Button();
            button8Decode = new Button();
            buttonDecode = new Button();
            SuspendLayout();
            // 
            // buttonTranslate
            // 
            buttonTranslate.Location = new Point(71, 305);
            buttonTranslate.Name = "buttonTranslate";
            buttonTranslate.Size = new Size(112, 34);
            buttonTranslate.TabIndex = 0;
            buttonTranslate.Text = "Translate";
            buttonTranslate.UseVisualStyleBackColor = true;
            buttonTranslate.Click += buttonTranslate_Click;
            // 
            // button4Parrity
            // 
            button4Parrity.Location = new Point(71, 345);
            button4Parrity.Name = "button4Parrity";
            button4Parrity.Size = new Size(112, 34);
            button4Parrity.TabIndex = 1;
            button4Parrity.Text = "4 Parrity";
            button4Parrity.UseVisualStyleBackColor = true;
            button4Parrity.Click += button4Parrity_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(22, 7);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(227, 292);
            textBoxInput.TabIndex = 2;
            // 
            // textBoxTranslate
            // 
            textBoxTranslate.Location = new Point(280, 7);
            textBoxTranslate.Multiline = true;
            textBoxTranslate.Name = "textBoxTranslate";
            textBoxTranslate.Size = new Size(227, 292);
            textBoxTranslate.TabIndex = 3;
            // 
            // button8Parrity
            // 
            button8Parrity.Location = new Point(71, 385);
            button8Parrity.Name = "button8Parrity";
            button8Parrity.Size = new Size(112, 34);
            button8Parrity.TabIndex = 4;
            button8Parrity.Text = "8 Parrity";
            button8Parrity.UseVisualStyleBackColor = true;
            button8Parrity.Click += button8Parrity_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(534, 7);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(227, 292);
            textBoxOutput.TabIndex = 5;
            // 
            // button4Decode
            // 
            button4Decode.Location = new Point(338, 345);
            button4Decode.Name = "button4Decode";
            button4Decode.Size = new Size(112, 34);
            button4Decode.TabIndex = 6;
            button4Decode.Text = "4 Decode";
            button4Decode.UseVisualStyleBackColor = true;
            button4Decode.Click += button4Decode_Click;
            // 
            // button8Decode
            // 
            button8Decode.Location = new Point(338, 385);
            button8Decode.Name = "button8Decode";
            button8Decode.Size = new Size(112, 34);
            button8Decode.TabIndex = 7;
            button8Decode.Text = "8 Decode";
            button8Decode.UseVisualStyleBackColor = true;
            button8Decode.Click += button8Decode_Click;
            // 
            // buttonDecode
            // 
            buttonDecode.Location = new Point(338, 305);
            buttonDecode.Name = "buttonDecode";
            buttonDecode.Size = new Size(112, 34);
            buttonDecode.TabIndex = 8;
            buttonDecode.Text = "Decode";
            buttonDecode.UseVisualStyleBackColor = true;
            buttonDecode.Click += buttonDecode_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDecode);
            Controls.Add(button8Decode);
            Controls.Add(button4Decode);
            Controls.Add(textBoxOutput);
            Controls.Add(button8Parrity);
            Controls.Add(textBoxTranslate);
            Controls.Add(textBoxInput);
            Controls.Add(button4Parrity);
            Controls.Add(buttonTranslate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTranslate;
        private Button button4Parrity;
        private TextBox textBoxInput;
        private TextBox textBoxTranslate;
        private Button button8Parrity;
        private TextBox textBoxOutput;
        private Button button4Decode;
        private Button button8Decode;
        private Button buttonDecode;
    }
}