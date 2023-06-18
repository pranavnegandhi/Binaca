namespace Notadesigner.Binaca
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
            ButtonClearAll = new Button();
            ButtonDigitOne = new Button();
            textBox1 = new TextBox();
            ButtonDigitZero = new Button();
            ButtonOperatorAdd = new Button();
            ButtonOperatorEquals = new Button();
            SuspendLayout();
            // 
            // ButtonClearAll
            // 
            ButtonClearAll.Location = new Point(12, 42);
            ButtonClearAll.Name = "ButtonClearAll";
            ButtonClearAll.Size = new Size(75, 23);
            ButtonClearAll.TabIndex = 0;
            ButtonClearAll.Text = "C";
            ButtonClearAll.UseVisualStyleBackColor = true;
            // 
            // ButtonDigitOne
            // 
            ButtonDigitOne.Location = new Point(93, 42);
            ButtonDigitOne.Name = "ButtonDigitOne";
            ButtonDigitOne.Size = new Size(75, 23);
            ButtonDigitOne.TabIndex = 11;
            ButtonDigitOne.Text = "1";
            ButtonDigitOne.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 23);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // ButtonDigitZero
            // 
            ButtonDigitZero.Location = new Point(93, 71);
            ButtonDigitZero.Name = "ButtonDigitZero";
            ButtonDigitZero.Size = new Size(75, 23);
            ButtonDigitZero.TabIndex = 12;
            ButtonDigitZero.Text = "0";
            ButtonDigitZero.UseVisualStyleBackColor = true;
            // 
            // ButtonOperatorAdd
            // 
            ButtonOperatorAdd.Location = new Point(174, 42);
            ButtonOperatorAdd.Name = "ButtonOperatorAdd";
            ButtonOperatorAdd.Size = new Size(75, 23);
            ButtonOperatorAdd.TabIndex = 21;
            ButtonOperatorAdd.Text = "+";
            ButtonOperatorAdd.UseVisualStyleBackColor = true;
            // 
            // ButtonOperatorEquals
            // 
            ButtonOperatorEquals.Location = new Point(174, 71);
            ButtonOperatorEquals.Name = "ButtonOperatorEquals";
            ButtonOperatorEquals.Size = new Size(75, 23);
            ButtonOperatorEquals.TabIndex = 22;
            ButtonOperatorEquals.Text = "=";
            ButtonOperatorEquals.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonOperatorEquals);
            Controls.Add(ButtonOperatorAdd);
            Controls.Add(ButtonDigitZero);
            Controls.Add(textBox1);
            Controls.Add(ButtonDigitOne);
            Controls.Add(ButtonClearAll);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button ButtonClearAll;
        public Button ButtonDigitOne;
        public TextBox textBox1;
        public Button ButtonDigitZero;
        public Button ButtonOperatorAdd;
        public Button ButtonOperatorEquals;
    }
}