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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DGVtelegram = new DataGridView();
            BTNeliminarTelegram = new Button();
            TLeliminar = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)DGVtelegram).BeginInit();
            SuspendLayout();
            // 
            // DGVtelegram
            // 
            DGVtelegram.BackgroundColor = Color.WhiteSmoke;
            DGVtelegram.BorderStyle = BorderStyle.None;
            DGVtelegram.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVtelegram.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(218, 41, 28);
            dataGridViewCellStyle4.Font = new Font("Perpetua", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(218, 41, 28);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVtelegram.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVtelegram.ColumnHeadersHeight = 30;
            DGVtelegram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGVtelegram.Cursor = Cursors.Hand;
            DGVtelegram.EnableHeadersVisualStyles = false;
            DGVtelegram.GridColor = Color.Black;
            DGVtelegram.Location = new Point(135, 146);
            DGVtelegram.Name = "DGVtelegram";
            DGVtelegram.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(4, 106, 56);
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(218, 41, 28);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DGVtelegram.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DGVtelegram.RowHeadersVisible = false;
            DGVtelegram.RowHeadersWidth = 40;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(218, 41, 28);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            DGVtelegram.RowsDefaultCellStyle = dataGridViewCellStyle6;
            DGVtelegram.Size = new Size(550, 320);
            DGVtelegram.TabIndex = 0;
            // 
            // BTNeliminarTelegram
            // 
            BTNeliminarTelegram.Cursor = Cursors.Hand;
            BTNeliminarTelegram.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNeliminarTelegram.Location = new Point(377, 472);
            BTNeliminarTelegram.Name = "BTNeliminarTelegram";
            BTNeliminarTelegram.Size = new Size(112, 23);
            BTNeliminarTelegram.TabIndex = 1;
            BTNeliminarTelegram.Text = "Eliminar Mensaje";
            TLeliminar.SetToolTip(BTNeliminarTelegram, "Click para eliminar el mensaje de la base de datos y de telegram\r\n\r\n");
            BTNeliminarTelegram.UseVisualStyleBackColor = true;
            BTNeliminarTelegram.Click += BTNeliminarTelegram_Click;
            // 
            // FormHistorialTelegram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(820, 612);
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
        private ToolTip TLeliminar;
    }
}