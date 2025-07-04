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
            LBLtelegramChatId = new Label();
            LBLtelegramMensaje = new Label();
            BTNenviarMensaje = new Button();
            BTNlimpiarCampos = new Button();
            TXTtelegramChatId = new TextBox();
            TXTmensajeTelegram = new TextBox();
            LBLtelegram = new Label();
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
            BTNenviarMensaje.UseVisualStyleBackColor = true;
            // 
            // BTNlimpiarCampos
            // 
            BTNlimpiarCampos.Location = new Point(317, 307);
            BTNlimpiarCampos.Name = "BTNlimpiarCampos";
            BTNlimpiarCampos.Size = new Size(75, 23);
            BTNlimpiarCampos.TabIndex = 3;
            BTNlimpiarCampos.Text = "Limpiar";
            BTNlimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // TXTtelegramChatId
            // 
            TXTtelegramChatId.Location = new Point(262, 78);
            TXTtelegramChatId.Name = "TXTtelegramChatId";
            TXTtelegramChatId.Size = new Size(188, 23);
            TXTtelegramChatId.TabIndex = 4;
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
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(664, 415);
            Controls.Add(LBLtelegram);
            Controls.Add(TXTmensajeTelegram);
            Controls.Add(TXTtelegramChatId);
            Controls.Add(BTNlimpiarCampos);
            Controls.Add(BTNenviarMensaje);
            Controls.Add(LBLtelegramMensaje);
            Controls.Add(LBLtelegramChatId);
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
        private Button BTNlimpiarCampos;
        private TextBox TXTtelegramChatId;
        private TextBox TXTmensajeTelegram;
        private Label LBLtelegram;
    }
}