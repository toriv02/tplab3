namespace lab2task2
{
    partial class MainForm
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
            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.FirstinputTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.SecondinputTextBox = new System.Windows.Forms.TextBox();
            this.firstTypeComboBox = new System.Windows.Forms.ComboBox();
            this.secondTypeComboBox = new System.Windows.Forms.ComboBox();
            this.anserTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // operationComboBox
            // 
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "ср."});
            this.operationComboBox.Location = new System.Drawing.Point(19, 29);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(46, 23);
            this.operationComboBox.TabIndex = 0;
            this.operationComboBox.SelectedIndexChanged += new System.EventHandler(this.valueChanged);
            // 
            // FirstinputTextBox
            // 
            this.FirstinputTextBox.Location = new System.Drawing.Point(71, 12);
            this.FirstinputTextBox.Name = "FirstinputTextBox";
            this.FirstinputTextBox.Size = new System.Drawing.Size(154, 23);
            this.FirstinputTextBox.TabIndex = 1;
            this.FirstinputTextBox.TextChanged += new System.EventHandler(this.valueChanged);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(19, 70);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(206, 23);
            this.OutputTextBox.TabIndex = 2;
            this.OutputTextBox.TextChanged += new System.EventHandler(this.valueChanged);
            // 
            // SecondinputTextBox
            // 
            this.SecondinputTextBox.Location = new System.Drawing.Point(71, 41);
            this.SecondinputTextBox.Name = "SecondinputTextBox";
            this.SecondinputTextBox.Size = new System.Drawing.Size(154, 23);
            this.SecondinputTextBox.TabIndex = 3;
            this.SecondinputTextBox.TextChanged += new System.EventHandler(this.valueChanged);
            // 
            // firstTypeComboBox
            // 
            this.firstTypeComboBox.FormattingEnabled = true;
            this.firstTypeComboBox.Location = new System.Drawing.Point(231, 12);
            this.firstTypeComboBox.Name = "firstTypeComboBox";
            this.firstTypeComboBox.Size = new System.Drawing.Size(43, 23);
            this.firstTypeComboBox.TabIndex = 4;
            this.firstTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.valueChanged);
            // 
            // secondTypeComboBox
            // 
            this.secondTypeComboBox.FormattingEnabled = true;
            this.secondTypeComboBox.Location = new System.Drawing.Point(231, 41);
            this.secondTypeComboBox.Name = "secondTypeComboBox";
            this.secondTypeComboBox.Size = new System.Drawing.Size(43, 23);
            this.secondTypeComboBox.TabIndex = 5;
            this.secondTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.valueChanged);
            // 
            // anserTypeComboBox
            // 
            this.anserTypeComboBox.FormattingEnabled = true;
            this.anserTypeComboBox.Location = new System.Drawing.Point(231, 70);
            this.anserTypeComboBox.Name = "anserTypeComboBox";
            this.anserTypeComboBox.Size = new System.Drawing.Size(43, 23);
            this.anserTypeComboBox.TabIndex = 6;
            this.anserTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.valueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 109);
            this.Controls.Add(this.anserTypeComboBox);
            this.Controls.Add(this.secondTypeComboBox);
            this.Controls.Add(this.firstTypeComboBox);
            this.Controls.Add(this.SecondinputTextBox);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.FirstinputTextBox);
            this.Controls.Add(this.operationComboBox);
            this.Name = "MainForm";
            this.Text = "Tempeture calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox operationComboBox;
        private TextBox FirstinputTextBox;
        private TextBox OutputTextBox;
        private TextBox SecondinputTextBox;
        private ComboBox firstTypeComboBox;
        private ComboBox secondTypeComboBox;
        private ComboBox anserTypeComboBox;
    }
}