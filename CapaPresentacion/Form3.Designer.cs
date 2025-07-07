namespace CapaPresentacion
{
    partial class Form3
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
            LBLtelegram = new Label();
            BTNadjuntar = new Button();
            LBLfotos = new Label();
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
            LBLtelegramChatId.Location = new Point(137, 81);
            LBLtelegramChatId.Name = "LBLtelegramChatId";
            LBLtelegramChatId.Size = new Size(119, 15);
            LBLtelegramChatId.TabIndex = 0;
            LBLtelegramChatId.Text = "Destinatario (Chat Id)";
            // 
            // LBLtelegramMensaje
            // 
            LBLtelegramMensaje.AutoSize = true;
            LBLtelegramMensaje.Location = new Point(137, 141);
            LBLtelegramMensaje.Name = "LBLtelegramMensaje";
            LBLtelegramMensaje.Size = new Size(51, 15);
            LBLtelegramMensaje.TabIndex = 1;
            LBLtelegramMensaje.Text = "Mensaje";
            // 
            // BTNenviarMensaje
            // 
            BTNenviarMensaje.Location = new Point(301, 278);
            BTNenviarMensaje.Name = "BTNenviarMensaje";
            BTNenviarMensaje.Size = new Size(103, 23);
            BTNenviarMensaje.TabIndex = 2;
            BTNenviarMensaje.Text = "Enviar Mensaje";
            toolTipEnviar.SetToolTip(BTNenviarMensaje, "Haz Click para Guardar en la Base de Datos");
            BTNenviarMensaje.UseVisualStyleBackColor = true;
            BTNenviarMensaje.Click += BTNenviarMensaje_Click;
            // 
            // TXTtelegramChatId
            // 
            TXTtelegramChatId.Location = new Point(262, 78);
            TXTtelegramChatId.Name = "TXTtelegramChatId";
            TXTtelegramChatId.Size = new Size(188, 23);
            TXTtelegramChatId.TabIndex = 4;
            TXTtelegramChatId.KeyPress += TXTtelegramChatId_KeyPress;
            // 
            // TXTmensajeTelegram
            // 
            TXTmensajeTelegram.Location = new Point(252, 128);
            TXTmensajeTelegram.Multiline = true;
            TXTmensajeTelegram.Name = "TXTmensajeTelegram";
            TXTmensajeTelegram.ScrollBars = ScrollBars.Vertical;
            TXTmensajeTelegram.Size = new Size(208, 133);
            TXTmensajeTelegram.TabIndex = 5;
            // 
            // LBLtelegram
            // 
            LBLtelegram.AutoSize = true;
            LBLtelegram.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLtelegram.Location = new Point(315, 22);
            LBLtelegram.Name = "LBLtelegram";
            LBLtelegram.Size = new Size(89, 23);
            LBLtelegram.TabIndex = 6;
            LBLtelegram.Text = "Telegram";
            // 
            // BTNadjuntar
            // 
            BTNadjuntar.Location = new Point(301, 316);
            BTNadjuntar.Name = "BTNadjuntar";
            BTNadjuntar.RightToLeft = RightToLeft.Yes;
            BTNadjuntar.Size = new Size(103, 23);
            BTNadjuntar.TabIndex = 7;
            BTNadjuntar.Text = "Adjuntar Fotos";
            toolTipAdjuntar.SetToolTip(BTNadjuntar, "Haz Click para Adjuntar Fotos");
            BTNadjuntar.UseVisualStyleBackColor = true;
            BTNadjuntar.Click += BTNadjuntar_Click;
            // 
            // LBLfotos
            // 
            LBLfotos.AutoSize = true;
            LBLfotos.Location = new Point(137, 320);
            LBLfotos.Name = "LBLfotos";
            LBLfotos.Size = new Size(85, 15);
            LBLfotos.TabIndex = 8;
            LBLfotos.Text = "Adjuntar Fotos";
            // 
            // LBLfiles
            // 
            LBLfiles.AutoSize = true;
            LBLfiles.BackColor = SystemColors.ControlLightLight;
            LBLfiles.Location = new Point(301, 342);
            LBLfiles.Name = "LBLfiles";
            LBLfiles.Size = new Size(16, 15);
            LBLfiles.TabIndex = 9;
            LBLfiles.Text = "...";
            // 
            // BTNlimpiarFotos
            // 
            BTNlimpiarFotos.Location = new Point(301, 380);
            BTNlimpiarFotos.Name = "BTNlimpiarFotos";
            BTNlimpiarFotos.Size = new Size(103, 23);
            BTNlimpiarFotos.TabIndex = 11;
            BTNlimpiarFotos.Text = "Limpiar Fotos";
            toolTipLimpiarfotos.SetToolTip(BTNlimpiarFotos, "Haz Click para Eliminar Imagenes Seleccionadas");
            BTNlimpiarFotos.UseVisualStyleBackColor = true;
            BTNlimpiarFotos.Click += BTNlimpiarFotos_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(820, 612);
            Controls.Add(BTNlimpiarFotos);
            Controls.Add(LBLfiles);
            Controls.Add(LBLfotos);
            Controls.Add(BTNadjuntar);
            Controls.Add(LBLtelegram);
            Controls.Add(TXTmensajeTelegram);
            Controls.Add(TXTtelegramChatId);
            Controls.Add(BTNenviarMensaje);
            Controls.Add(LBLtelegramMensaje);
            Controls.Add(LBLtelegramChatId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
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
        private Label LBLtelegram;
        private Button BTNadjuntar;
        private Label LBLfotos;
        private Label LBLfiles;
        private Button BTNlimpiarFotos;
        private ToolTip toolTipEnviar;
        private ToolTip toolTipAdjuntar;
        private ToolTip toolTipLimpiarfotos;
    }
}