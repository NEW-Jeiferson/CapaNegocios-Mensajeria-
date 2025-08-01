﻿namespace CapaPresentacion
{
    partial class FormPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPresentacion));
            BarraTitulo = new Panel();
            BTNminimizar = new PictureBox();
            BTNcerrar = new PictureBox();
            MenuVertical = new Panel();
            panel3 = new Panel();
            BTNhistorial = new Button();
            SubmenuHistorial = new Panel();
            BTNhistorialGmail = new Button();
            BTNhitorialTelegram = new Button();
            panel2 = new Panel();
            BTNgmail = new Button();
            panel1 = new Panel();
            BTNtelegram = new Button();
            BTNinicio = new PictureBox();
            panelContenedor = new Panel();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BTNminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BTNcerrar).BeginInit();
            MenuVertical.SuspendLayout();
            SubmenuHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BTNinicio).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(218, 41, 28);
            BarraTitulo.Controls.Add(BTNminimizar);
            BarraTitulo.Controls.Add(BTNcerrar);
            BarraTitulo.Cursor = Cursors.Hand;
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1000, 38);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // BTNminimizar
            // 
            BTNminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTNminimizar.Cursor = Cursors.Hand;
            BTNminimizar.Image = Properties.Resources.icons8_minimize_window_50;
            BTNminimizar.Location = new Point(926, 8);
            BTNminimizar.Name = "BTNminimizar";
            BTNminimizar.Size = new Size(24, 24);
            BTNminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            BTNminimizar.TabIndex = 1;
            BTNminimizar.TabStop = false;
            BTNminimizar.Click += BTNminimizar_Click;
            // 
            // BTNcerrar
            // 
            BTNcerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTNcerrar.Cursor = Cursors.Hand;
            BTNcerrar.Image = (Image)resources.GetObject("BTNcerrar.Image");
            BTNcerrar.Location = new Point(965, 8);
            BTNcerrar.Name = "BTNcerrar";
            BTNcerrar.Size = new Size(24, 24);
            BTNcerrar.SizeMode = PictureBoxSizeMode.Zoom;
            BTNcerrar.TabIndex = 0;
            BTNcerrar.TabStop = false;
            BTNcerrar.Click += BTNcerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.Black;
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(BTNhistorial);
            MenuVertical.Controls.Add(SubmenuHistorial);
            MenuVertical.Controls.Add(panel2);
            MenuVertical.Controls.Add(BTNgmail);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(BTNtelegram);
            MenuVertical.Controls.Add(BTNinicio);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 38);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(180, 612);
            MenuVertical.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(4, 106, 56);
            panel3.Location = new Point(0, 383);
            panel3.Name = "panel3";
            panel3.Size = new Size(7, 53);
            panel3.TabIndex = 6;
            // 
            // BTNhistorial
            // 
            BTNhistorial.BackColor = Color.Black;
            BTNhistorial.Cursor = Cursors.Hand;
            BTNhistorial.FlatAppearance.BorderSize = 0;
            BTNhistorial.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 106, 56);
            BTNhistorial.FlatStyle = FlatStyle.Flat;
            BTNhistorial.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNhistorial.ForeColor = Color.White;
            BTNhistorial.Image = Properties.Resources.icons8_pasado_30;
            BTNhistorial.ImageAlign = ContentAlignment.MiddleLeft;
            BTNhistorial.Location = new Point(3, 383);
            BTNhistorial.Name = "BTNhistorial";
            BTNhistorial.Size = new Size(177, 53);
            BTNhistorial.TabIndex = 5;
            BTNhistorial.Text = "Historial";
            BTNhistorial.UseVisualStyleBackColor = false;
            BTNhistorial.Click += BTNhistorial_Click;
            // 
            // SubmenuHistorial
            // 
            SubmenuHistorial.Controls.Add(BTNhistorialGmail);
            SubmenuHistorial.Controls.Add(BTNhitorialTelegram);
            SubmenuHistorial.Location = new Point(8, 433);
            SubmenuHistorial.Name = "SubmenuHistorial";
            SubmenuHistorial.Size = new Size(172, 69);
            SubmenuHistorial.TabIndex = 7;
            SubmenuHistorial.Visible = false;
            // 
            // BTNhistorialGmail
            // 
            BTNhistorialGmail.BackColor = Color.Black;
            BTNhistorialGmail.Cursor = Cursors.Hand;
            BTNhistorialGmail.FlatAppearance.BorderSize = 0;
            BTNhistorialGmail.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 106, 56);
            BTNhistorialGmail.FlatStyle = FlatStyle.Flat;
            BTNhistorialGmail.Font = new Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNhistorialGmail.ForeColor = Color.White;
            BTNhistorialGmail.ImageAlign = ContentAlignment.MiddleLeft;
            BTNhistorialGmail.Location = new Point(0, 37);
            BTNhistorialGmail.Name = "BTNhistorialGmail";
            BTNhistorialGmail.Size = new Size(168, 32);
            BTNhistorialGmail.TabIndex = 7;
            BTNhistorialGmail.Text = "Gmail";
            BTNhistorialGmail.UseVisualStyleBackColor = false;
            BTNhistorialGmail.Click += BTNhistorialGmail_Click;
            // 
            // BTNhitorialTelegram
            // 
            BTNhitorialTelegram.BackColor = Color.Black;
            BTNhitorialTelegram.Cursor = Cursors.Hand;
            BTNhitorialTelegram.FlatAppearance.BorderSize = 0;
            BTNhitorialTelegram.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 106, 56);
            BTNhitorialTelegram.FlatStyle = FlatStyle.Flat;
            BTNhitorialTelegram.Font = new Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNhitorialTelegram.ForeColor = Color.White;
            BTNhitorialTelegram.ImageAlign = ContentAlignment.MiddleLeft;
            BTNhitorialTelegram.Location = new Point(0, 3);
            BTNhitorialTelegram.Name = "BTNhitorialTelegram";
            BTNhitorialTelegram.Size = new Size(168, 32);
            BTNhitorialTelegram.TabIndex = 6;
            BTNhitorialTelegram.Text = "Telegram";
            BTNhitorialTelegram.UseVisualStyleBackColor = false;
            BTNhitorialTelegram.Click += BTNhitorialTelegram_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(4, 106, 56);
            panel2.Location = new Point(0, 275);
            panel2.Name = "panel2";
            panel2.Size = new Size(7, 53);
            panel2.TabIndex = 4;
            // 
            // BTNgmail
            // 
            BTNgmail.BackColor = Color.Black;
            BTNgmail.Cursor = Cursors.Hand;
            BTNgmail.FlatAppearance.BorderSize = 0;
            BTNgmail.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 106, 56);
            BTNgmail.FlatStyle = FlatStyle.Flat;
            BTNgmail.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNgmail.ForeColor = Color.White;
            BTNgmail.Image = (Image)resources.GetObject("BTNgmail.Image");
            BTNgmail.ImageAlign = ContentAlignment.MiddleLeft;
            BTNgmail.Location = new Point(3, 275);
            BTNgmail.Name = "BTNgmail";
            BTNgmail.Size = new Size(177, 53);
            BTNgmail.TabIndex = 3;
            BTNgmail.Text = "Gmail";
            BTNgmail.UseVisualStyleBackColor = false;
            BTNgmail.Click += BTNgmail_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 106, 56);
            panel1.Location = new Point(0, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(7, 53);
            panel1.TabIndex = 2;
            // 
            // BTNtelegram
            // 
            BTNtelegram.BackColor = Color.Black;
            BTNtelegram.Cursor = Cursors.Hand;
            BTNtelegram.FlatAppearance.BorderSize = 0;
            BTNtelegram.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 106, 56);
            BTNtelegram.FlatStyle = FlatStyle.Flat;
            BTNtelegram.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNtelegram.ForeColor = Color.White;
            BTNtelegram.Image = (Image)resources.GetObject("BTNtelegram.Image");
            BTNtelegram.ImageAlign = ContentAlignment.MiddleLeft;
            BTNtelegram.Location = new Point(3, 164);
            BTNtelegram.Name = "BTNtelegram";
            BTNtelegram.Size = new Size(177, 53);
            BTNtelegram.TabIndex = 1;
            BTNtelegram.Text = "Telegram";
            BTNtelegram.UseVisualStyleBackColor = false;
            BTNtelegram.Click += BTNtelegram_Click;
            // 
            // BTNinicio
            // 
            BTNinicio.Cursor = Cursors.Hand;
            BTNinicio.Image = (Image)resources.GetObject("BTNinicio.Image");
            BTNinicio.Location = new Point(0, 0);
            BTNinicio.Name = "BTNinicio";
            BTNinicio.Size = new Size(180, 144);
            BTNinicio.SizeMode = PictureBoxSizeMode.Zoom;
            BTNinicio.TabIndex = 0;
            BTNinicio.TabStop = false;
            BTNinicio.Click += BTNinicio_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Gainsboro;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(180, 38);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(820, 612);
            panelContenedor.TabIndex = 2;
            // 
            // FormPresentacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(panelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPresentacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BTNminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTNcerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            SubmenuHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BTNinicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private Panel MenuVertical;
        private Panel panelContenedor;
        private PictureBox BTNcerrar;
        private PictureBox BTNminimizar;
        private PictureBox BTNinicio;
        private Button BTNtelegram;
        private Panel panel1;
        private Panel panel2;
        private Button BTNgmail;
        private Panel panel3;
        private Button BTNhistorial;
        private Panel SubmenuHistorial;
        private Button BTNhistorialGmail;
        private Button BTNhitorialTelegram;
    }
}