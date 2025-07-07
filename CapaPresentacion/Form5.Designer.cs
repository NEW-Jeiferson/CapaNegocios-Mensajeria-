namespace CapaPresentacion
{
    partial class Form5
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
            DGVgmail = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVgmail).BeginInit();
            SuspendLayout();
            // 
            // DGVgmail
            // 
            DGVgmail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVgmail.Cursor = Cursors.Hand;
            DGVgmail.Location = new Point(83, 108);
            DGVgmail.Name = "DGVgmail";
            DGVgmail.Size = new Size(633, 314);
            DGVgmail.TabIndex = 0;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 612);
            Controls.Add(DGVgmail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historial Gmail";
            ((System.ComponentModel.ISupportInitialize)DGVgmail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVgmail;
    }
}