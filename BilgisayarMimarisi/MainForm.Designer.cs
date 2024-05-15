namespace BilgisayarMimarisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ramBox = new GroupBox();
            tabControl = new TabControl();
            writeData = new TabPage();
            writeButton = new Button();
            writeTextBox = new TextBox();
            readData = new TabPage();
            hammingLabel = new Label();
            dataLabel = new Label();
            syndromeLabel = new Label();
            readButton = new Button();
            tabControl.SuspendLayout();
            writeData.SuspendLayout();
            readData.SuspendLayout();
            SuspendLayout();
            // 
            // ramBox
            // 
            ramBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ramBox.Location = new Point(12, 12);
            ramBox.Name = "ramBox";
            ramBox.Size = new Size(754, 66);
            ramBox.TabIndex = 0;
            ramBox.TabStop = false;
            ramBox.Text = "RAM";
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(writeData);
            tabControl.Controls.Add(readData);
            tabControl.Location = new Point(12, 84);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(754, 223);
            tabControl.TabIndex = 100;
            // 
            // writeData
            // 
            writeData.Controls.Add(writeButton);
            writeData.Controls.Add(writeTextBox);
            writeData.Location = new Point(4, 29);
            writeData.Name = "writeData";
            writeData.Padding = new Padding(3);
            writeData.Size = new Size(746, 190);
            writeData.TabIndex = 0;
            writeData.Text = "Write Data";
            writeData.UseVisualStyleBackColor = true;
            // 
            // writeButton
            // 
            writeButton.Location = new Point(463, 51);
            writeButton.Name = "writeButton";
            writeButton.Size = new Size(94, 29);
            writeButton.TabIndex = 102;
            writeButton.Text = "Write";
            writeButton.UseVisualStyleBackColor = true;
            writeButton.Click += writeButton_Click;
            // 
            // writeTextBox
            // 
            writeTextBox.Location = new Point(187, 52);
            writeTextBox.Name = "writeTextBox";
            writeTextBox.Size = new Size(270, 27);
            writeTextBox.TabIndex = 101;
            // 
            // readData
            // 
            readData.Controls.Add(hammingLabel);
            readData.Controls.Add(dataLabel);
            readData.Controls.Add(syndromeLabel);
            readData.Controls.Add(readButton);
            readData.Location = new Point(4, 29);
            readData.Name = "readData";
            readData.Padding = new Padding(3);
            readData.Size = new Size(746, 190);
            readData.TabIndex = 1;
            readData.Text = "Read Data";
            readData.UseVisualStyleBackColor = true;
            // 
            // hammingLabel
            // 
            hammingLabel.AutoSize = true;
            hammingLabel.Location = new Point(227, 133);
            hammingLabel.Name = "hammingLabel";
            hammingLabel.Size = new Size(86, 20);
            hammingLabel.TabIndex = 106;
            hammingLabel.Text = "Hamming : ";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new Point(227, 102);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new Size(52, 20);
            dataLabel.TabIndex = 105;
            dataLabel.Text = "Data : ";
            // 
            // syndromeLabel
            // 
            syndromeLabel.AutoSize = true;
            syndromeLabel.Location = new Point(227, 73);
            syndromeLabel.Name = "syndromeLabel";
            syndromeLabel.Size = new Size(87, 20);
            syndromeLabel.TabIndex = 104;
            syndromeLabel.Text = "Syndrome : ";
            // 
            // readButton
            // 
            readButton.Location = new Point(227, 29);
            readButton.Name = "readButton";
            readButton.Size = new Size(292, 29);
            readButton.TabIndex = 103;
            readButton.Text = "Read";
            readButton.UseVisualStyleBackColor = true;
            readButton.Click += readButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 319);
            Controls.Add(tabControl);
            Controls.Add(ramBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hamming Code by Eren GÜRELİ";
            tabControl.ResumeLayout(false);
            writeData.ResumeLayout(false);
            writeData.PerformLayout();
            readData.ResumeLayout(false);
            readData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ramBox;
        private TabControl tabControl;
        private TabPage writeData;
        private TabPage readData;
        private TextBox writeTextBox;
        private Button writeButton;
        private Label syndromeLabel;
        private Button readButton;
        private Label hammingLabel;
        private Label dataLabel;
    }
}
