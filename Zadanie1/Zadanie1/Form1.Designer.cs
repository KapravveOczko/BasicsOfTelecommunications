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
            textBoxTranslated = new TextBox();
            buttonFixOne = new Button();
            buttonSave = new Button();
            buttonLoad = new Button();
            buttonFixTwo = new Button();
            textBoxOutput = new TextBox();
            buttonTranslateToOne = new Button();
            buttonTranslateToTwo = new Button();
            pictureBox1 = new PictureBox();
            labelText = new Label();
            labelTranslate = new Label();
            LabelOutput = new Label();
            labelImage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(11, 44);
            textBoxInput.Margin = new Padding(2);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(192, 246);
            textBoxInput.TabIndex = 0;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // buttonTranslate
            // 
            buttonTranslate.Location = new Point(11, 294);
            buttonTranslate.Margin = new Padding(2);
            buttonTranslate.Name = "buttonTranslate";
            buttonTranslate.Size = new Size(192, 41);
            buttonTranslate.TabIndex = 1;
            buttonTranslate.Text = "translate";
            buttonTranslate.UseVisualStyleBackColor = true;
            buttonTranslate.Click += button1_Click;
            // 
            // textBoxTranslated
            // 
            textBoxTranslated.Location = new Point(222, 44);
            textBoxTranslated.Margin = new Padding(2);
            textBoxTranslated.Multiline = true;
            textBoxTranslated.Name = "textBoxTranslated";
            textBoxTranslated.Size = new Size(192, 246);
            textBoxTranslated.TabIndex = 2;
            // 
            // buttonFixOne
            // 
            buttonFixOne.Location = new Point(430, 294);
            buttonFixOne.Margin = new Padding(2);
            buttonFixOne.Name = "buttonFixOne";
            buttonFixOne.Size = new Size(192, 41);
            buttonFixOne.TabIndex = 4;
            buttonFixOne.Text = "fix one";
            buttonFixOne.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(222, 294);
            buttonSave.Margin = new Padding(2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(192, 41);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click_1;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(222, 339);
            buttonLoad.Margin = new Padding(2);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(192, 41);
            buttonLoad.TabIndex = 7;
            buttonLoad.Text = "load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonFixTwo
            // 
            buttonFixTwo.Location = new Point(430, 339);
            buttonFixTwo.Margin = new Padding(2);
            buttonFixTwo.Name = "buttonFixTwo";
            buttonFixTwo.Size = new Size(192, 41);
            buttonFixTwo.TabIndex = 8;
            buttonFixTwo.Text = "fix two";
            buttonFixTwo.UseVisualStyleBackColor = true;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(430, 44);
            textBoxOutput.Margin = new Padding(2);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(192, 246);
            textBoxOutput.TabIndex = 9;
            EventHandler textBoxOutput_TextChanged = null; //i added it only for not fucking tje program up purposes
            textBoxOutput.TextChanged += textBoxOutput_TextChanged;
            // 
            // buttonTranslateToOne
            // 
            buttonTranslateToOne.Location = new Point(11, 339);
            buttonTranslateToOne.Margin = new Padding(2);
            buttonTranslateToOne.Name = "buttonTranslateToOne";
            buttonTranslateToOne.Size = new Size(192, 41);
            buttonTranslateToOne.TabIndex = 10;
            buttonTranslateToOne.Text = "translate to one";
            buttonTranslateToOne.UseVisualStyleBackColor = true;
            // 
            // buttonTranslateToTwo
            // 
            buttonTranslateToTwo.Location = new Point(11, 384);
            buttonTranslateToTwo.Margin = new Padding(2);
            buttonTranslateToTwo.Name = "buttonTranslateToTwo";
            buttonTranslateToTwo.Size = new Size(192, 41);
            buttonTranslateToTwo.TabIndex = 11;
            buttonTranslateToTwo.Text = "translate to two";
            buttonTranslateToTwo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(627, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 380);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelText.Location = new Point(48, 18);
            labelText.Name = "labelText";
            labelText.Size = new Size(117, 21);
            labelText.TabIndex = 13;
            labelText.Text = "text to translate";
            // 
            // labelTranslate
            // 
            labelTranslate.AutoSize = true;
            labelTranslate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTranslate.Location = new Point(264, 18);
            labelTranslate.Name = "labelTranslate";
            labelTranslate.Size = new Size(108, 21);
            labelTranslate.TabIndex = 14;
            labelTranslate.Text = "text translated";
            // 
            // LabelOutput
            // 
            LabelOutput.AutoSize = true;
            LabelOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelOutput.Location = new Point(463, 18);
            LabelOutput.Name = "LabelOutput";
            LabelOutput.Size = new Size(128, 21);
            LabelOutput.TabIndex = 15;
            LabelOutput.Text = "text re-translated";
            // 
            // labelImage
            // 
            labelImage.AutoSize = true;
            labelImage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelImage.Location = new Point(725, 18);
            labelImage.Name = "labelImage";
            labelImage.Size = new Size(126, 21);
            labelImage.TabIndex = 16;
            labelImage.Text = "a really nice tank";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 434);
            Controls.Add(labelImage);
            Controls.Add(LabelOutput);
            Controls.Add(labelTranslate);
            Controls.Add(labelText);
            Controls.Add(pictureBox1);
            Controls.Add(buttonTranslateToTwo);
            Controls.Add(buttonTranslateToOne);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonFixTwo);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(buttonFixOne);
            Controls.Add(textBoxTranslated);
            Controls.Add(buttonTranslate);
            Controls.Add(textBoxInput);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Button buttonTranslate;
        private TextBox textBoxTranslated;
        private TextBox programOutput;
        private Button buttonFixOne;
        private Button buttonSave;
        private Button buttonLoad;
        private Button buttonFixTwo;
        private TextBox textBoxOutput;
        private Button buttonTranslateToOne;
        private Button buttonTranslateToTwo;
        private PictureBox pictureBox1;
        private Label labelText;
        private Label labelTranslate;
        private Label LabelOutput;
        private Label labelImage;
    }
}