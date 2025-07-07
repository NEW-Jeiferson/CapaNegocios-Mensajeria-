namespace CapaPresentacion
{
    partial class FormGmail
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
            DGVGMAIL = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVGMAIL).BeginInit();
            SuspendLayout();
            // 
            // DGVGMAIL
            // 
            DGVGMAIL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVGMAIL.Location = new Point(175, 89);
            DGVGMAIL.Name = "DGVGMAIL";
            DGVGMAIL.RowHeadersWidth = 51;
            DGVGMAIL.Size = new Size(537, 314);
            DGVGMAIL.TabIndex = 0;
            // 
            // FormGmail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 717);
            Controls.Add(DGVGMAIL);
            Name = "FormGmail";
            Text = "FormGmail";
            Load += FormGmail_Load;
            ((System.ComponentModel.ISupportInitialize)DGVGMAIL).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVGMAIL;
    }
}