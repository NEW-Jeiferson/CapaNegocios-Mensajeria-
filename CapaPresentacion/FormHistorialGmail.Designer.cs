namespace CapaPresentacion
{
    partial class FormHistorialGmail
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
            DGVgmail.Location = new Point(116, 85);
            DGVgmail.Margin = new Padding(3, 2, 3, 2);
            DGVgmail.Name = "DGVgmail";
            DGVgmail.RowHeadersWidth = 51;
            DGVgmail.Size = new Size(576, 322);
            DGVgmail.TabIndex = 0;
            // 
            // FormHistorialGmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 573);
            Controls.Add(DGVgmail);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormHistorialGmail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGmail";
            Load += FormGmail_Load;
            ((System.ComponentModel.ISupportInitialize)DGVgmail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVgmail;
    }
}