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
            ButtonClearExpression = new Button();
            ButtonOperatorSubtract = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonClearAll
            // 
            ButtonClearAll.Dock = DockStyle.Fill;
            ButtonClearAll.Location = new Point(3, 138);
            ButtonClearAll.Name = "ButtonClearAll";
            ButtonClearAll.Size = new Size(194, 151);
            ButtonClearAll.TabIndex = 0;
            ButtonClearAll.Text = "C";
            ButtonClearAll.UseVisualStyleBackColor = true;
            // 
            // ButtonDigitOne
            // 
            ButtonDigitOne.Dock = DockStyle.Fill;
            ButtonDigitOne.Location = new Point(203, 138);
            ButtonDigitOne.Name = "ButtonDigitOne";
            ButtonDigitOne.Size = new Size(194, 151);
            ButtonDigitOne.TabIndex = 11;
            ButtonDigitOne.Text = "1";
            ButtonDigitOne.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            tableLayoutPanel1.SetColumnSpan(textBox1, 4);
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(794, 23);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // ButtonDigitZero
            // 
            ButtonDigitZero.Dock = DockStyle.Fill;
            ButtonDigitZero.Location = new Point(203, 295);
            ButtonDigitZero.Name = "ButtonDigitZero";
            ButtonDigitZero.Size = new Size(194, 152);
            ButtonDigitZero.TabIndex = 12;
            ButtonDigitZero.Text = "0";
            ButtonDigitZero.UseVisualStyleBackColor = true;
            // 
            // ButtonOperatorAdd
            // 
            ButtonOperatorAdd.Dock = DockStyle.Fill;
            ButtonOperatorAdd.Location = new Point(403, 138);
            ButtonOperatorAdd.Name = "ButtonOperatorAdd";
            ButtonOperatorAdd.Size = new Size(194, 151);
            ButtonOperatorAdd.TabIndex = 21;
            ButtonOperatorAdd.Text = "+";
            ButtonOperatorAdd.UseVisualStyleBackColor = true;
            // 
            // ButtonOperatorEquals
            // 
            ButtonOperatorEquals.Dock = DockStyle.Fill;
            ButtonOperatorEquals.Location = new Point(603, 138);
            ButtonOperatorEquals.Name = "ButtonOperatorEquals";
            tableLayoutPanel1.SetRowSpan(ButtonOperatorEquals, 2);
            ButtonOperatorEquals.Size = new Size(194, 309);
            ButtonOperatorEquals.TabIndex = 23;
            ButtonOperatorEquals.Text = "=";
            ButtonOperatorEquals.UseVisualStyleBackColor = true;
            // 
            // ButtonClearExpression
            // 
            ButtonClearExpression.Dock = DockStyle.Fill;
            ButtonClearExpression.Location = new Point(3, 295);
            ButtonClearExpression.Name = "ButtonClearExpression";
            ButtonClearExpression.Size = new Size(194, 152);
            ButtonClearExpression.TabIndex = 1;
            ButtonClearExpression.Text = "CE";
            ButtonClearExpression.UseVisualStyleBackColor = true;
            // 
            // ButtonOperatorSubtract
            // 
            ButtonOperatorSubtract.Dock = DockStyle.Fill;
            ButtonOperatorSubtract.Location = new Point(403, 295);
            ButtonOperatorSubtract.Name = "ButtonOperatorSubtract";
            ButtonOperatorSubtract.Size = new Size(194, 152);
            ButtonOperatorSubtract.TabIndex = 22;
            ButtonOperatorSubtract.Text = "-";
            ButtonOperatorSubtract.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(ButtonOperatorSubtract, 2, 2);
            tableLayoutPanel1.Controls.Add(ButtonClearAll, 0, 1);
            tableLayoutPanel1.Controls.Add(ButtonDigitZero, 1, 2);
            tableLayoutPanel1.Controls.Add(ButtonClearExpression, 0, 2);
            tableLayoutPanel1.Controls.Add(ButtonDigitOne, 1, 1);
            tableLayoutPanel1.Controls.Add(ButtonOperatorEquals, 3, 1);
            tableLayoutPanel1.Controls.Add(ButtonOperatorAdd, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Button ButtonClearAll;
        public Button ButtonDigitOne;
        public TextBox textBox1;
        public Button ButtonDigitZero;
        public Button ButtonOperatorAdd;
        public Button ButtonOperatorEquals;
        public Button ButtonClearExpression;
        public Button ButtonOperatorSubtract;
        private TableLayoutPanel tableLayoutPanel1;
    }
}