namespace BilgisayarMimarisi
{
    partial class BitForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bitBox = new ComboBox();
            selectButton = new Button();
            label = new Label();
            SuspendLayout();
            // 
            // bitBox
            // 
            bitBox.FormattingEnabled = true;
            bitBox.Items.AddRange(new object[] { "4", "8", "16" });
            bitBox.Location = new Point(12, 43);
            bitBox.Name = "bitBox";
            bitBox.Size = new Size(151, 28);
            bitBox.TabIndex = 0;
            // 
            // selectButton
            // 
            selectButton.Location = new Point(212, 42);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(94, 29);
            selectButton.TabIndex = 1;
            selectButton.Text = "Seç";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 9);
            label.Name = "label";
            label.Size = new Size(171, 20);
            label.TabIndex = 2;
            label.Text = "Kaç bit olacağını seçiniz:";
            // 
            // BitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 90);
            Controls.Add(label);
            Controls.Add(selectButton);
            Controls.Add(bitBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bit Form";
            TopMost = true;
            FormClosing += BitForm_FormClosing;
            FormClosed += BitForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox bitBox;
        private Button selectButton;
        private Label label;
    }
}