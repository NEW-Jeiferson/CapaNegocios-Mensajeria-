namespace CapaPresentacion
{
    partial class Inicio
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
            LBLhora = new Label();
            horafecha = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LBLhora
            // 
            LBLhora.AutoSize = true;
            LBLhora.Font = new Font("Bodoni MT Condensed", 60F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLhora.ForeColor = Color.FromArgb(218, 41, 28);
            LBLhora.Location = new Point(307, 510);
            LBLhora.Name = "LBLhora";
            LBLhora.Size = new Size(181, 93);
            LBLhora.TabIndex = 0;
            LBLhora.Text = "label1";
            // 
            // horafecha
            // 
            horafecha.Enabled = true;
            horafecha.Tick += horafecha_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_07_08_221359;
            pictureBox1.Location = new Point(260, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 270);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(218, 41, 28);
            label1.Location = new Point(316, 53);
            label1.Name = "label1";
            label1.Size = new Size(189, 41);
            label1.TabIndex = 2;
            label1.Text = "Goat Comm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(4, 106, 56);
            label2.Location = new Point(100, 110);
            label2.Name = "label2";
            label2.Size = new Size(620, 41);
            label2.TabIndex = 3;
            label2.Text = "Donde la comunicación se transforma. 🚀";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(184, 467);
            label3.Name = "label3";
            label3.Size = new Size(452, 23);
            label3.TabIndex = 4;
            label3.Text = " Conéctate. Comunica. Confía. Somos GOAT Comm";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(820, 612);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(LBLhora);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLhora;
        private System.Windows.Forms.Timer horafecha;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}