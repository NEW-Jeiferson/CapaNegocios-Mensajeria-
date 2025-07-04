namespace CapaPresentacion
{
    partial class Form1
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
            LBLmensaje = new Label();
            LBLenviarA = new Label();
            LBLasunto = new Label();
            TXTenviarA = new TextBox();
            TXTasunto = new TextBox();
            BTNenviarguardar = new Button();
            LBLgmail = new Label();
            LBLadjuntarArchivos = new Label();
            TXTmensaje = new TextBox();
            BTNinicio = new Button();
            LBLfiles = new Label();
            BTNadjuntar = new Button();
            SuspendLayout();
            // 
            // LBLmensaje
            // 
            LBLmensaje.AutoSize = true;
            LBLmensaje.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLmensaje.Location = new Point(169, 119);
            LBLmensaje.Name = "LBLmensaje";
            LBLmensaje.Size = new Size(62, 17);
            LBLmensaje.TabIndex = 6;
            LBLmensaje.Text = "Mensaje";
            // 
            // LBLenviarA
            // 
            LBLenviarA.AutoSize = true;
            LBLenviarA.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLenviarA.Location = new Point(169, 45);
            LBLenviarA.Name = "LBLenviarA";
            LBLenviarA.Size = new Size(62, 17);
            LBLenviarA.TabIndex = 7;
            LBLenviarA.Text = "Enviar a";
            // 
            // LBLasunto
            // 
            LBLasunto.AutoSize = true;
            LBLasunto.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLasunto.Location = new Point(169, 84);
            LBLasunto.Name = "LBLasunto";
            LBLasunto.Size = new Size(51, 17);
            LBLasunto.TabIndex = 8;
            LBLasunto.Text = "Asunto";
            // 
            // TXTenviarA
            // 
            TXTenviarA.BackColor = SystemColors.MenuBar;
            TXTenviarA.Location = new Point(237, 43);
            TXTenviarA.Name = "TXTenviarA";
            TXTenviarA.Size = new Size(215, 23);
            TXTenviarA.TabIndex = 2;
            TXTenviarA.TextChanged += TXTenviarA_TextChanged;
            // 
            // TXTasunto
            // 
            TXTasunto.BackColor = SystemColors.MenuBar;
            TXTasunto.Location = new Point(237, 78);
            TXTasunto.Name = "TXTasunto";
            TXTasunto.Size = new Size(215, 23);
            TXTasunto.TabIndex = 3;
            TXTasunto.TextChanged += TXTasunto_TextChanged;
            // 
            // BTNenviarguardar
            // 
            BTNenviarguardar.BackColor = SystemColors.MenuBar;
            BTNenviarguardar.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNenviarguardar.Location = new Point(302, 224);
            BTNenviarguardar.Name = "BTNenviarguardar";
            BTNenviarguardar.Size = new Size(100, 23);
            BTNenviarguardar.TabIndex = 9;
            BTNenviarguardar.Text = "Enviar / Guardar";
            BTNenviarguardar.UseVisualStyleBackColor = false;
            BTNenviarguardar.Click += BTNenviarguardar_Click;
            // 
            // LBLgmail
            // 
            LBLgmail.AutoSize = true;
            LBLgmail.BackColor = SystemColors.GradientActiveCaption;
            LBLgmail.Font = new Font("Times New Roman", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLgmail.Location = new Point(302, -3);
            LBLgmail.Name = "LBLgmail";
            LBLgmail.Size = new Size(88, 34);
            LBLgmail.TabIndex = 11;
            LBLgmail.Text = "Gmail";
            // 
            // LBLadjuntarArchivos
            // 
            LBLadjuntarArchivos.AutoSize = true;
            LBLadjuntarArchivos.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLadjuntarArchivos.Location = new Point(169, 257);
            LBLadjuntarArchivos.Name = "LBLadjuntarArchivos";
            LBLadjuntarArchivos.Size = new Size(95, 15);
            LBLadjuntarArchivos.TabIndex = 13;
            LBLadjuntarArchivos.Text = "Adjuntar Archivos";
            // 
            // TXTmensaje
            // 
            TXTmensaje.BackColor = SystemColors.MenuBar;
            TXTmensaje.Location = new Point(237, 117);
            TXTmensaje.Multiline = true;
            TXTmensaje.Name = "TXTmensaje";
            TXTmensaje.ScrollBars = ScrollBars.Vertical;
            TXTmensaje.Size = new Size(215, 101);
            TXTmensaje.TabIndex = 14;
            TXTmensaje.TextChanged += TXTmensaje_TextChanged_1;
            // 
            // BTNinicio
            // 
            BTNinicio.BackColor = SystemColors.MenuBar;
            BTNinicio.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNinicio.Location = new Point(24, 39);
            BTNinicio.Name = "BTNinicio";
            BTNinicio.Size = new Size(75, 23);
            BTNinicio.TabIndex = 15;
            BTNinicio.Text = "Inicio";
            BTNinicio.UseVisualStyleBackColor = false;
            BTNinicio.Click += BTNinicio_Click;
            // 
            // LBLfiles
            // 
            LBLfiles.AutoSize = true;
            LBLfiles.BackColor = SystemColors.MenuBar;
            LBLfiles.Location = new Point(295, 279);
            LBLfiles.Name = "LBLfiles";
            LBLfiles.Size = new Size(16, 15);
            LBLfiles.TabIndex = 16;
            LBLfiles.Text = "...";
            // 
            // BTNadjuntar
            // 
            BTNadjuntar.BackColor = SystemColors.MenuBar;
            BTNadjuntar.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNadjuntar.Location = new Point(295, 253);
            BTNadjuntar.Name = "BTNadjuntar";
            BTNadjuntar.Size = new Size(107, 23);
            BTNadjuntar.TabIndex = 17;
            BTNadjuntar.Text = "Adjuntar Archivos";
            BTNadjuntar.UseVisualStyleBackColor = false;
            BTNadjuntar.Click += BTNadjuntar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(664, 415);
            Controls.Add(BTNadjuntar);
            Controls.Add(LBLfiles);
            Controls.Add(BTNinicio);
            Controls.Add(TXTmensaje);
            Controls.Add(LBLadjuntarArchivos);
            Controls.Add(LBLgmail);
            Controls.Add(BTNenviarguardar);
            Controls.Add(LBLasunto);
            Controls.Add(LBLenviarA);
            Controls.Add(LBLmensaje);
            Controls.Add(TXTasunto);
            Controls.Add(TXTenviarA);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label LBLgmail;
        private Label LBLadjuntarArchivos;
        private TextBox TXTmensaje;
        private Button BTNinicio;
        private Label LBLfiles;
        private Button BTNadjuntar;
    }
}
