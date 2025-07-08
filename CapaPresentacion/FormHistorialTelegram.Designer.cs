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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DGVtelegram = new DataGridView();
            BTNeliminarTelegram = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVtelegram).BeginInit();
            SuspendLayout();
            // 
            // DGVtelegram
            // 
            DGVtelegram.BackgroundColor = Color.LavenderBlush;
            DGVtelegram.BorderStyle = BorderStyle.None;
            DGVtelegram.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVtelegram.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(218, 41, 28);
            dataGridViewCellStyle1.Font = new Font("Perpetua", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(218, 41, 28);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVtelegram.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVtelegram.ColumnHeadersHeight = 30;
            DGVtelegram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGVtelegram.Cursor = Cursors.Hand;
            DGVtelegram.EnableHeadersVisualStyles = false;
            DGVtelegram.GridColor = Color.Black;
            DGVtelegram.Location = new Point(130, 124);
            DGVtelegram.Name = "DGVtelegram";
            DGVtelegram.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(4, 106, 56);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(218, 41, 28);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVtelegram.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVtelegram.RowHeadersVisible = false;
            DGVtelegram.RowHeadersWidth = 40;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(218, 41, 28);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DGVtelegram.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DGVtelegram.Size = new Size(550, 320);
            DGVtelegram.TabIndex = 0;
            // 
            // BTNeliminarTelegram
            // 
            BTNeliminarTelegram.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNeliminarTelegram.Location = new Point(362, 472);
            BTNeliminarTelegram.Name = "BTNeliminarTelegram";
            BTNeliminarTelegram.Size = new Size(112, 23);
            BTNeliminarTelegram.TabIndex = 1;
            BTNeliminarTelegram.Text = "Eliminar Mensaje";
            BTNeliminarTelegram.UseVisualStyleBackColor = true;
            BTNeliminarTelegram.Click += BTNeliminarTelegram_Click;
            // 
            // FormHistorialTelegram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(804, 573);
            Controls.Add(BTNeliminarTelegram);
            Controls.Add(DGVtelegram);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHistorialTelegram";
            StartPosition = FormStartPosition.Manual;
            Text = "Historial Telegram";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)DGVtelegram).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVtelegram;
        private Button BTNeliminarTelegram;
    }
}