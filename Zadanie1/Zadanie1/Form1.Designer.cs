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
            buttonTranslate = new Button();
            textBoxOutput = new TextBox();
            buttonFixOne = new Button();
            buttonSave = new Button();
            buttonLoad = new Button();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(7, 7);
            textBoxInput.Margin = new Padding(2);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(175, 248);
            textBoxInput.TabIndex = 0;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // buttonTranslate
            // 
            buttonTranslate.Location = new Point(186, 7);
            buttonTranslate.Margin = new Padding(2);
            buttonTranslate.Name = "buttonTranslate";
            buttonTranslate.Size = new Size(180, 41);
            buttonTranslate.TabIndex = 1;
            buttonTranslate.Text = "translate";
            buttonTranslate.UseVisualStyleBackColor = true;
            buttonTranslate.Click += button1_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(370, 7);
            textBoxOutput.Margin = new Padding(2);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(175, 248);
            textBoxOutput.TabIndex = 2;
            // 
            // buttonFixOne
            // 
            buttonFixOne.Location = new Point(186, 52);
            buttonFixOne.Margin = new Padding(2);
            buttonFixOne.Name = "buttonFixOne";
            buttonFixOne.Size = new Size(180, 41);
            buttonFixOne.TabIndex = 4;
            buttonFixOne.Text = "fix one";
            buttonFixOne.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(186, 97);
            buttonSave.Margin = new Padding(2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(180, 41);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click_1;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(186, 142);
            buttonLoad.Margin = new Padding(2);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(180, 41);
            buttonLoad.TabIndex = 7;
            buttonLoad.Text = "load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(buttonFixOne);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonTranslate);
            Controls.Add(textBoxInput);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Button buttonTranslate;
        private TextBox textBoxOutput;
        private TextBox programOutput;
        private Button buttonFixOne;
        private Button buttonSave;
        private Button buttonLoad;
    }
}