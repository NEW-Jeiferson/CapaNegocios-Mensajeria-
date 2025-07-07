namespace CapaPresentacion
{
    partial class FormHistorialTelegram
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
            DGVtelegram = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVtelegram).BeginInit();
            SuspendLayout();
            // 
            // DGVtelegram
            // 
            DGVtelegram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVtelegram.Location = new Point(190, 114);
            DGVtelegram.Name = "DGVtelegram";
            DGVtelegram.Size = new Size(442, 357);
            DGVtelegram.TabIndex = 0;
            // 
            // FormHistorialTelegram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(804, 573);
            Controls.Add(DGVtelegram);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHistorialTelegram";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historial Telegram";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)DGVtelegram).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVtelegram;
    }
}