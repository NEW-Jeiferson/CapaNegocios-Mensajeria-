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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DGVgmail = new DataGridView();
            BTNeliminar = new Button();
            TPLeliminar = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)DGVgmail).BeginInit();
            SuspendLayout();
            // 
            // DGVgmail
            // 
            DGVgmail.BackgroundColor = Color.AliceBlue;
            DGVgmail.BorderStyle = BorderStyle.None;
            DGVgmail.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVgmail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(4, 106, 56);
            dataGridViewCellStyle4.Font = new Font("Perpetua", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(4, 106, 56);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVgmail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVgmail.ColumnHeadersHeight = 40;
            DGVgmail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGVgmail.Cursor = Cursors.Hand;
            DGVgmail.EnableHeadersVisualStyles = false;
            DGVgmail.GridColor = Color.Black;
            DGVgmail.Location = new Point(152, 127);
            DGVgmail.Margin = new Padding(3, 2, 3, 2);
            DGVgmail.Name = "DGVgmail";
            DGVgmail.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(218, 41, 28);
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(4, 106, 56);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DGVgmail.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DGVgmail.RowHeadersVisible = false;
            DGVgmail.RowHeadersWidth = 40;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(4, 106, 56);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            DGVgmail.RowsDefaultCellStyle = dataGridViewCellStyle6;
            DGVgmail.Size = new Size(500, 320);
            DGVgmail.TabIndex = 0;
            // 
            // BTNeliminar
            // 
            BTNeliminar.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNeliminar.Location = new Point(348, 467);
            BTNeliminar.Name = "BTNeliminar";
            BTNeliminar.Size = new Size(105, 23);
            BTNeliminar.TabIndex = 1;
            BTNeliminar.Text = "Eliminar Mensaje";
            TPLeliminar.SetToolTip(BTNeliminar, "Click para eliminar el mensaje de la base de datos");
            BTNeliminar.UseVisualStyleBackColor = true;
            // 
            // FormHistorialGmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(804, 573);
            Controls.Add(BTNeliminar);
            Controls.Add(DGVgmail);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormHistorialGmail";
            StartPosition = FormStartPosition.Manual;
            Text = "FormGmail";
            Load += FormGmail_Load;
            ((System.ComponentModel.ISupportInitialize)DGVgmail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVgmail;
        private Button BTNeliminar;
        private ToolTip TPLeliminar;
    }
}