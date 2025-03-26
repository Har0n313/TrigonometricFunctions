namespace TrigonometricFunctions
{
    partial class HelpForm
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
            richTextBoxHelp = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxHelp
            // 
            richTextBoxHelp.Location = new Point(12, 12);
            richTextBoxHelp.Name = "richTextBoxHelp";
            richTextBoxHelp.Size = new Size(467, 310);
            richTextBoxHelp.TabIndex = 0;
            richTextBoxHelp.Text = "";
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 334);
            Controls.Add(richTextBoxHelp);
            Name = "HelpForm";
            Text = "Справочная Информация";
            Load += HelpForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxHelp;
    }
}