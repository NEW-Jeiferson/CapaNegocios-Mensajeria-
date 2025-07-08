namespace CapaPresentacion
{
    partial class FormTelegram
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
            LBLtelegramChatId = new Label();
            LBLtelegramMensaje = new Label();
            BTNenviarMensaje = new Button();
            TXTtelegramChatId = new TextBox();
            TXTmensajeTelegram = new TextBox();
            BTNadjuntar = new Button();
            LBLfiles = new Label();
            BTNlimpiarFotos = new Button();
            toolTipEnviar = new ToolTip(components);
            toolTipAdjuntar = new ToolTip(components);
            toolTipLimpiarfotos = new ToolTip(components);
            SuspendLayout();
            // 
            // LBLtelegramChatId
            // 
            LBLtelegramChatId.AutoSize = true;
            LBLtelegramChatId.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLtelegramChatId.Location = new Point(100, 142);
            LBLtelegramChatId.Name = "LBLtelegramChatId";
            LBLtelegramChatId.Size = new Size(152, 19);
            LBLtelegramChatId.TabIndex = 0;
            LBLtelegramChatId.Text = "Destinatario (Chat Id)";
            // 
            // LBLtelegramMensaje
            // 
            LBLtelegramMensaje.AutoSize = true;
            LBLtelegramMensaje.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLtelegramMensaje.Location = new Point(141, 196);
            LBLtelegramMensaje.Name = "LBLtelegramMensaje";
            LBLtelegramMensaje.Size = new Size(63, 19);
            LBLtelegramMensaje.TabIndex = 1;
            LBLtelegramMensaje.Text = "Mensaje";
            // 
            // BTNenviarMensaje
            // 
            BTNenviarMensaje.BackColor = Color.White;
            BTNenviarMensaje.Cursor = Cursors.Hand;
            BTNenviarMensaje.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNenviarMensaje.Location = new Point(356, 384);
            BTNenviarMensaje.Name = "BTNenviarMensaje";
            BTNenviarMensaje.Size = new Size(103, 23);
            BTNenviarMensaje.TabIndex = 2;
            BTNenviarMensaje.Text = "Enviar Mensaje";
            toolTipEnviar.SetToolTip(BTNenviarMensaje, "Haz Click para Guardar en la Base de Datos");
            BTNenviarMensaje.UseVisualStyleBackColor = false;
            BTNenviarMensaje.Click += BTNenviarMensaje_Click;
            // 
            // TXTtelegramChatId
            // 
            TXTtelegramChatId.BackColor = Color.White;
            TXTtelegramChatId.Font = new Font("Trebuchet MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TXTtelegramChatId.Location = new Point(284, 140);
            TXTtelegramChatId.Name = "TXTtelegramChatId";
            TXTtelegramChatId.Size = new Size(236, 21);
            TXTtelegramChatId.TabIndex = 4;
            TXTtelegramChatId.KeyPress += TXTtelegramChatId_KeyPress;
            // 
            // TXTmensajeTelegram
            // 
            TXTmensajeTelegram.BackColor = Color.White;
            TXTmensajeTelegram.Font = new Font("Trebuchet MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TXTmensajeTelegram.Location = new Point(257, 196);
            TXTmensajeTelegram.Multiline = true;
            TXTmensajeTelegram.Name = "TXTmensajeTelegram";
            TXTmensajeTelegram.ScrollBars = ScrollBars.Vertical;
            TXTmensajeTelegram.Size = new Size(290, 182);
            TXTmensajeTelegram.TabIndex = 5;
            // 
            // BTNadjuntar
            // 
            BTNadjuntar.BackColor = Color.White;
            BTNadjuntar.Cursor = Cursors.Hand;
            BTNadjuntar.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNadjuntar.Location = new Point(356, 427);
            BTNadjuntar.Name = "BTNadjuntar";
            BTNadjuntar.RightToLeft = RightToLeft.Yes;
            BTNadjuntar.Size = new Size(103, 23);
            BTNadjuntar.TabIndex = 7;
            BTNadjuntar.Text = "Adjuntar Fotos";
            toolTipAdjuntar.SetToolTip(BTNadjuntar, "Haz Click para Adjuntar Fotos");
            BTNadjuntar.UseVisualStyleBackColor = false;
            BTNadjuntar.Click += BTNadjuntar_Click;
            // 
            // LBLfiles
            // 
            LBLfiles.AutoSize = true;
            LBLfiles.BackColor = Color.White;
            LBLfiles.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLfiles.Location = new Point(356, 453);
            LBLfiles.Name = "LBLfiles";
            LBLfiles.Size = new Size(16, 15);
            LBLfiles.TabIndex = 9;
            LBLfiles.Text = "...";
            // 
            // BTNlimpiarFotos
            // 
            BTNlimpiarFotos.BackColor = Color.White;
            BTNlimpiarFotos.Cursor = Cursors.Hand;
            BTNlimpiarFotos.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNlimpiarFotos.Location = new Point(345, 480);
            BTNlimpiarFotos.Name = "BTNlimpiarFotos";
            BTNlimpiarFotos.Size = new Size(128, 23);
            BTNlimpiarFotos.TabIndex = 11;
            BTNlimpiarFotos.Text = "Limpiar Fotos";
            toolTipLimpiarfotos.SetToolTip(BTNlimpiarFotos, "Haz Click para Eliminar Imagenes Seleccionadas");
            BTNlimpiarFotos.UseVisualStyleBackColor = false;
            BTNlimpiarFotos.Click += BTNlimpiarFotos_Click;
            // 
            // FormTelegram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkMagenta;
            ClientSize = new Size(820, 612);
            Controls.Add(BTNlimpiarFotos);
            Controls.Add(LBLfiles);
            Controls.Add(BTNadjuntar);
            Controls.Add(TXTmensajeTelegram);
            Controls.Add(TXTtelegramChatId);
            Controls.Add(BTNenviarMensaje);
            Controls.Add(LBLtelegramMensaje);
            Controls.Add(LBLtelegramChatId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTelegram";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Telegram";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLtelegramChatId;
        private Label LBLtelegramMensaje;
        private Button BTNenviarMensaje;
        private TextBox TXTtelegramChatId;
        private TextBox TXTmensajeTelegram;
        private Button BTNadjuntar;
        private Label LBLfiles;
        private Button BTNlimpiarFotos;
        private ToolTip toolTipEnviar;
        private ToolTip toolTipAdjuntar;
        private ToolTip toolTipLimpiarfotos;
    }
}