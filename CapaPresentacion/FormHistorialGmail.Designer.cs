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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(4, 106, 56);
            dataGridViewCellStyle1.Font = new Font("Perpetua", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(4, 106, 56);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVgmail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVgmail.ColumnHeadersHeight = 40;
            DGVgmail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGVgmail.Cursor = Cursors.Hand;
            DGVgmail.EnableHeadersVisualStyles = false;
            DGVgmail.GridColor = Color.Black;
            DGVgmail.Location = new Point(152, 127);
            DGVgmail.Margin = new Padding(3, 2, 3, 2);
            DGVgmail.Name = "DGVgmail";
            DGVgmail.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(218, 41, 28);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(4, 106, 56);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVgmail.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVgmail.RowHeadersVisible = false;
            DGVgmail.RowHeadersWidth = 40;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(4, 106, 56);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DGVgmail.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DGVgmail.Size = new Size(500, 320);
            DGVgmail.TabIndex = 0;
            // 
            // BTNeliminar
            // 
            BTNeliminar.Cursor = Cursors.Hand;
            BTNeliminar.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNeliminar.Location = new Point(348, 467);
            BTNeliminar.Name = "BTNeliminar";
            BTNeliminar.Size = new Size(105, 23);
            BTNeliminar.TabIndex = 1;
            BTNeliminar.Text = "Eliminar Mensaje";
            TPLeliminar.SetToolTip(BTNeliminar, "Click para eliminar el mensaje de la base de datos");
            BTNeliminar.UseVisualStyleBackColor = true;
            BTNeliminar.Click += BTNeliminar_Click;
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