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
            textBoxInput.Location = new Point(16, 73);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(273, 407);
            textBoxInput.TabIndex = 0;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // buttonTranslate
            // 
            buttonTranslate.Location = new Point(16, 490);
            buttonTranslate.Name = "buttonTranslate";
            buttonTranslate.Size = new Size(274, 68);
            buttonTranslate.TabIndex = 1;
            buttonTranslate.Text = "translate";
            buttonTranslate.UseVisualStyleBackColor = true;
            buttonTranslate.Click += button1_Click;
            // 
            // textBoxTranslated
            // 
            textBoxTranslated.Location = new Point(317, 73);
            textBoxTranslated.Multiline = true;
            textBoxTranslated.Name = "textBoxTranslated";
            textBoxTranslated.Size = new Size(273, 407);
            textBoxTranslated.TabIndex = 2;
            // 
            // buttonFixOne
            // 
            buttonFixOne.Location = new Point(614, 490);
            buttonFixOne.Name = "buttonFixOne";
            buttonFixOne.Size = new Size(274, 68);
            buttonFixOne.TabIndex = 4;
            buttonFixOne.Text = "fix one";
            buttonFixOne.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(317, 490);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(274, 68);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click_1;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(317, 565);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(274, 68);
            buttonLoad.TabIndex = 7;
            buttonLoad.Text = "load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonFixTwo
            // 
            buttonFixTwo.Location = new Point(614, 565);
            buttonFixTwo.Name = "buttonFixTwo";
            buttonFixTwo.Size = new Size(274, 68);
            buttonFixTwo.TabIndex = 8;
            buttonFixTwo.Text = "fix two";
            buttonFixTwo.UseVisualStyleBackColor = true;
            // 
            // buttonTranslateToOne
            // 
            buttonTranslateToOne.Location = new Point(16, 565);
            buttonTranslateToOne.Name = "buttonTranslateToOne";
            buttonTranslateToOne.Size = new Size(274, 68);
            buttonTranslateToOne.TabIndex = 10;
            buttonTranslateToOne.Text = "translate to one";
            buttonTranslateToOne.UseVisualStyleBackColor = true;
            buttonTranslateToOne.Click += buttonTranslateToOne_Click;
            // 
            // buttonTranslateToTwo
            // 
            buttonTranslateToTwo.Location = new Point(16, 640);
            buttonTranslateToTwo.Name = "buttonTranslateToTwo";
            buttonTranslateToTwo.Size = new Size(274, 68);
            buttonTranslateToTwo.TabIndex = 11;
            buttonTranslateToTwo.Text = "translate to two";
            buttonTranslateToTwo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(896, 75);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 633);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelText.Location = new Point(69, 30);
            labelText.Margin = new Padding(4, 0, 4, 0);
            labelText.Name = "labelText";
            labelText.Size = new Size(181, 32);
            labelText.TabIndex = 13;
            labelText.Text = "text to translate";
            // 
            // labelTranslate
            // 
            labelTranslate.AutoSize = true;
            labelTranslate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTranslate.Location = new Point(377, 30);
            labelTranslate.Margin = new Padding(4, 0, 4, 0);
            labelTranslate.Name = "labelTranslate";
            labelTranslate.Size = new Size(166, 32);
            labelTranslate.TabIndex = 14;
            labelTranslate.Text = "text translated";
            // 
            // LabelOutput
            // 
            LabelOutput.AutoSize = true;
            LabelOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelOutput.Location = new Point(661, 30);
            LabelOutput.Margin = new Padding(4, 0, 4, 0);
            LabelOutput.Name = "LabelOutput";
            LabelOutput.Size = new Size(197, 32);
            LabelOutput.TabIndex = 15;
            LabelOutput.Text = "text re-translated";
            // 
            // labelImage
            // 
            labelImage.AutoSize = true;
            labelImage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelImage.Location = new Point(1036, 30);
            labelImage.Margin = new Padding(4, 0, 4, 0);
            labelImage.Name = "labelImage";
            labelImage.Size = new Size(194, 32);
            labelImage.TabIndex = 16;
            labelImage.Text = "a really nice tank";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 723);
            Controls.Add(labelImage);
            Controls.Add(LabelOutput);
            Controls.Add(labelTranslate);
            Controls.Add(labelText);
            Controls.Add(pictureBox1);
            Controls.Add(buttonTranslateToTwo);
            Controls.Add(buttonTranslateToOne);
            Controls.Add(buttonFixTwo);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(buttonFixOne);
            Controls.Add(textBoxTranslated);
            Controls.Add(buttonTranslate);
            Controls.Add(textBoxInput);
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
        private Button buttonTranslateToOne;
        private Button buttonTranslateToTwo;
        private PictureBox pictureBox1;
        private Label labelText;
        private Label labelTranslate;
        private Label LabelOutput;
        private Label labelImage;
    }
}