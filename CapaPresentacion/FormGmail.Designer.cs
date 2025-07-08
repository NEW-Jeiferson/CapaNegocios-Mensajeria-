namespace CapaPresentacion
{
    partial class FormGmail
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGmail));
            LBLmensaje = new Label();
            LBLenviarA = new Label();
            LBLasunto = new Label();
            TXTenviarA = new TextBox();
            TXTasunto = new TextBox();
            BTNenviarguardar = new Button();
            TXTmensaje = new TextBox();
            LBLfiles = new Label();
            BTNadjuntar = new Button();
            toolTipGuardar = new ToolTip(components);
            toolTipadjuntar = new ToolTip(components);
            SuspendLayout();
            // 
            // LBLmensaje
            // 
            LBLmensaje.AutoSize = true;
            LBLmensaje.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLmensaje.Location = new Point(177, 196);
            LBLmensaje.Name = "LBLmensaje";
            LBLmensaje.Size = new Size(74, 21);
            LBLmensaje.TabIndex = 6;
            LBLmensaje.Text = "Mensaje";
            // 
            // LBLenviarA
            // 
            LBLenviarA.AutoSize = true;
            LBLenviarA.BackColor = Color.White;
            LBLenviarA.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLenviarA.Location = new Point(177, 76);
            LBLenviarA.Name = "LBLenviarA";
            LBLenviarA.Size = new Size(77, 21);
            LBLenviarA.TabIndex = 7;
            LBLenviarA.Text = "Enviar a";
            // 
            // LBLasunto
            // 
            LBLasunto.AutoSize = true;
            LBLasunto.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLasunto.Location = new Point(177, 129);
            LBLasunto.Name = "LBLasunto";
            LBLasunto.Size = new Size(62, 21);
            LBLasunto.TabIndex = 8;
            LBLasunto.Text = "Asunto";
            // 
            // TXTenviarA
            // 
            TXTenviarA.BackColor = Color.White;
            TXTenviarA.Font = new Font("Trebuchet MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TXTenviarA.Location = new Point(281, 76);
            TXTenviarA.Name = "TXTenviarA";
            TXTenviarA.Size = new Size(236, 21);
            TXTenviarA.TabIndex = 2;
            toolTipGuardar.SetToolTip(TXTenviarA, "Introduce la dirección de correo electrónico del destinatario aquí");
            TXTenviarA.TextChanged += TXTenviarA_TextChanged;
            TXTenviarA.KeyPress += TXTenviarA_KeyPress;
            // 
            // TXTasunto
            // 
            TXTasunto.BackColor = Color.White;
            TXTasunto.Font = new Font("Trebuchet MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TXTasunto.Location = new Point(281, 129);
            TXTasunto.Name = "TXTasunto";
            TXTasunto.Size = new Size(236, 21);
            TXTasunto.TabIndex = 3;
            TXTasunto.TextChanged += TXTasunto_TextChanged;
            TXTasunto.KeyPress += TXTasunto_KeyPress;
            // 
            // BTNenviarguardar
            // 
            BTNenviarguardar.BackColor = Color.White;
            BTNenviarguardar.Cursor = Cursors.Hand;
            BTNenviarguardar.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNenviarguardar.Location = new Point(357, 384);
            BTNenviarguardar.Name = "BTNenviarguardar";
            BTNenviarguardar.Size = new Size(100, 23);
            BTNenviarguardar.TabIndex = 9;
            BTNenviarguardar.Text = "Enviar / Guardar";
            toolTipGuardar.SetToolTip(BTNenviarguardar, "Haz Click para Guardar en la Base de Datos");
            BTNenviarguardar.UseVisualStyleBackColor = false;
            BTNenviarguardar.Click += BTNenviarguardar_Click;
            // 
            // TXTmensaje
            // 
            TXTmensaje.BackColor = Color.White;
            TXTmensaje.Font = new Font("Trebuchet MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TXTmensaje.Location = new Point(257, 196);
            TXTmensaje.Multiline = true;
            TXTmensaje.Name = "TXTmensaje";
            TXTmensaje.ScrollBars = ScrollBars.Vertical;
            TXTmensaje.Size = new Size(290, 182);
            TXTmensaje.TabIndex = 14;
            TXTmensaje.TextChanged += TXTmensaje_TextChanged_1;
            // 
            // LBLfiles
            // 
            LBLfiles.AutoSize = true;
            LBLfiles.BackColor = Color.White;
            LBLfiles.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLfiles.Location = new Point(357, 439);
            LBLfiles.Name = "LBLfiles";
            LBLfiles.Size = new Size(16, 15);
            LBLfiles.TabIndex = 16;
            LBLfiles.Text = "...";
            // 
            // BTNadjuntar
            // 
            BTNadjuntar.BackColor = Color.White;
            BTNadjuntar.Cursor = Cursors.Hand;
            BTNadjuntar.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNadjuntar.Location = new Point(348, 413);
            BTNadjuntar.Name = "BTNadjuntar";
            BTNadjuntar.Size = new Size(119, 23);
            BTNadjuntar.TabIndex = 17;
            BTNadjuntar.Text = "Adjuntar Archivos";
            toolTipadjuntar.SetToolTip(BTNadjuntar, "Haz Click para Adjuntar Archivos");
            BTNadjuntar.UseVisualStyleBackColor = false;
            BTNadjuntar.Click += BTNadjuntar_Click;
            // 
            // FormGmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 573);
            Controls.Add(BTNadjuntar);
            Controls.Add(LBLfiles);
            Controls.Add(TXTmensaje);
            Controls.Add(BTNenviarguardar);
            Controls.Add(LBLasunto);
            Controls.Add(LBLenviarA);
            Controls.Add(LBLmensaje);
            Controls.Add(TXTasunto);
            Controls.Add(TXTenviarA);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGmail";
            StartPosition = FormStartPosition.Manual;
            Text = "Gmail";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LBLmensaje;
        private Label LBLenviarA;
        private Label LBLasunto;
        private TextBox TXTenviarA;
        private TextBox TXTasunto;
        private Button BTNenviarguardar;
        private TextBox TXTmensaje;
        private Label LBLfiles;
        private Button BTNadjuntar;
        private ToolTip toolTipGuardar;
        private ToolTip toolTipadjuntar;
    }
}
