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
            dtgvMensajes = new DataGridView();
            CBOtipo = new ComboBox();
            LBLtipodemensaje = new Label();
            LBLdestinatario = new Label();
            LBLcontenido = new Label();
            TXTdestinatario = new TextBox();
            TXTcontenido = new TextBox();
            BTNenviarguardar = new Button();
            BTNcargarMensajes = new Button();
            LBLmensajeria = new Label();
            BTNlimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvMensajes).BeginInit();
            SuspendLayout();
            // 
            // dtgvMensajes
            // 
            dtgvMensajes.BackgroundColor = SystemColors.MenuBar;
            dtgvMensajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMensajes.GridColor = SystemColors.ControlText;
            dtgvMensajes.Location = new Point(321, 84);
            dtgvMensajes.Name = "dtgvMensajes";
            dtgvMensajes.ReadOnly = true;
            dtgvMensajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvMensajes.Size = new Size(431, 96);
            dtgvMensajes.TabIndex = 0;
            // 
            // CBOtipo
            // 
            CBOtipo.BackColor = SystemColors.MenuBar;
            CBOtipo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOtipo.FormattingEnabled = true;
            CBOtipo.Location = new Point(139, 182);
            CBOtipo.Name = "CBOtipo";
            CBOtipo.Size = new Size(81, 23);
            CBOtipo.TabIndex = 1;
            CBOtipo.SelectedIndexChanged += CBOtipo_SelectedIndexChanged;
            // 
            // LBLtipodemensaje
            // 
            LBLtipodemensaje.AutoSize = true;
            LBLtipodemensaje.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLtipodemensaje.Location = new Point(12, 190);
            LBLtipodemensaje.Name = "LBLtipodemensaje";
            LBLtipodemensaje.Size = new Size(112, 17);
            LBLtipodemensaje.TabIndex = 6;
            LBLtipodemensaje.Text = "Tipo de Mensaje";
            // 
            // LBLdestinatario
            // 
            LBLdestinatario.AutoSize = true;
            LBLdestinatario.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLdestinatario.Location = new Point(20, 90);
            LBLdestinatario.Name = "LBLdestinatario";
            LBLdestinatario.Size = new Size(86, 17);
            LBLdestinatario.TabIndex = 7;
            LBLdestinatario.Text = "Destinatario";
            // 
            // LBLcontenido
            // 
            LBLcontenido.AutoSize = true;
            LBLcontenido.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLcontenido.Location = new Point(30, 137);
            LBLcontenido.Name = "LBLcontenido";
            LBLcontenido.Size = new Size(73, 17);
            LBLcontenido.TabIndex = 8;
            LBLcontenido.Text = "Contenido";
            // 
            // TXTdestinatario
            // 
            TXTdestinatario.BackColor = SystemColors.MenuBar;
            TXTdestinatario.Location = new Point(112, 84);
            TXTdestinatario.Name = "TXTdestinatario";
            TXTdestinatario.Size = new Size(144, 23);
            TXTdestinatario.TabIndex = 2;
            TXTdestinatario.TextChanged += TXTdestinatario_TextChanged;
            // 
            // TXTcontenido
            // 
            TXTcontenido.BackColor = SystemColors.MenuBar;
            TXTcontenido.Location = new Point(112, 134);
            TXTcontenido.Name = "TXTcontenido";
            TXTcontenido.Size = new Size(144, 23);
            TXTcontenido.TabIndex = 3;
            TXTcontenido.TextChanged += TXTcontenido_TextChanged;
            // 
            // BTNenviarguardar
            // 
            BTNenviarguardar.BackColor = SystemColors.MenuBar;
            BTNenviarguardar.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNenviarguardar.Location = new Point(130, 211);
            BTNenviarguardar.Name = "BTNenviarguardar";
            BTNenviarguardar.Size = new Size(100, 23);
            BTNenviarguardar.TabIndex = 9;
            BTNenviarguardar.Text = "Enviar / Guardar";
            BTNenviarguardar.UseVisualStyleBackColor = false;
            BTNenviarguardar.Click += BTNenviarguardar_Click;
            // 
            // BTNcargarMensajes
            // 
            BTNcargarMensajes.BackColor = SystemColors.MenuBar;
            BTNcargarMensajes.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNcargarMensajes.Location = new Point(482, 204);
            BTNcargarMensajes.Name = "BTNcargarMensajes";
            BTNcargarMensajes.Size = new Size(104, 23);
            BTNcargarMensajes.TabIndex = 10;
            BTNcargarMensajes.Text = "Cargar Mensajes";
            BTNcargarMensajes.UseVisualStyleBackColor = false;
            BTNcargarMensajes.Click += BTNcargarMensajes_Click;
            // 
            // LBLmensajeria
            // 
            LBLmensajeria.AutoSize = true;
            LBLmensajeria.BackColor = SystemColors.GradientActiveCaption;
            LBLmensajeria.Font = new Font("Times New Roman", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLmensajeria.Location = new Point(112, 27);
            LBLmensajeria.Name = "LBLmensajeria";
            LBLmensajeria.Size = new Size(147, 34);
            LBLmensajeria.TabIndex = 11;
            LBLmensajeria.Text = "Mensajeria";
            // 
            // BTNlimpiar
            // 
            BTNlimpiar.BackColor = SystemColors.MenuBar;
            BTNlimpiar.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BTNlimpiar.Location = new Point(499, 233);
            BTNlimpiar.Name = "BTNlimpiar";
            BTNlimpiar.Size = new Size(75, 23);
            BTNlimpiar.TabIndex = 12;
            BTNlimpiar.Text = "Limpiar";
            BTNlimpiar.UseVisualStyleBackColor = false;
            BTNlimpiar.Click += BTNlimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(793, 323);
            Controls.Add(BTNlimpiar);
            Controls.Add(LBLmensajeria);
            Controls.Add(BTNcargarMensajes);
            Controls.Add(BTNenviarguardar);
            Controls.Add(LBLcontenido);
            Controls.Add(LBLdestinatario);
            Controls.Add(LBLtipodemensaje);
            Controls.Add(TXTcontenido);
            Controls.Add(TXTdestinatario);
            Controls.Add(CBOtipo);
            Controls.Add(dtgvMensajes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvMensajes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvMensajes;
        private ComboBox CBOtipo;
        private Label LBLtipodemensaje;
        private Label LBLdestinatario;
        private Label LBLcontenido;
        private TextBox TXTdestinatario;
        private TextBox TXTcontenido;
        private Button BTNenviarguardar;
        private Button BTNcargarMensajes;
        private Label LBLmensajeria;
        private Button BTNlimpiar;
    }
}
