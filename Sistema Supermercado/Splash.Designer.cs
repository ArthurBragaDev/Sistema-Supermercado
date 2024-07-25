namespace Sistema_Supermercado
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            label2 = new Label();
            MeuProgresso = new Bunifu.UI.WinForms.BunifuProgressBar();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(103, 16);
            label1.Name = "label1";
            label1.Size = new Size(539, 41);
            label1.TabIndex = 5;
            label1.Text = "Sistema de Gerenciamento MercaFácil";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(311, 57);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 5;
            label2.Text = "Versão 1.0";
            label2.Click += label1_Click;
            // 
            // MeuProgresso
            // 
            MeuProgresso.AllowAnimations = false;
            MeuProgresso.Animation = 0;
            MeuProgresso.AnimationSpeed = 220;
            MeuProgresso.AnimationStep = 10;
            MeuProgresso.BackColor = Color.FromArgb(94, 148, 255);
            MeuProgresso.BackgroundImage = (Image)resources.GetObject("MeuProgresso.BackgroundImage");
            MeuProgresso.BorderColor = Color.FromArgb(94, 148, 255);
            MeuProgresso.BorderRadius = 9;
            MeuProgresso.BorderThickness = 1;
            MeuProgresso.Location = new Point(0, 265);
            MeuProgresso.Maximum = 100;
            MeuProgresso.MaximumValue = 100;
            MeuProgresso.Minimum = 0;
            MeuProgresso.MinimumValue = 0;
            MeuProgresso.Name = "MeuProgresso";
            MeuProgresso.Orientation = Orientation.Horizontal;
            MeuProgresso.ProgressBackColor = Color.FromArgb(94, 148, 255);
            MeuProgresso.ProgressColorLeft = Color.FromArgb(64, 64, 64);
            MeuProgresso.ProgressColorRight = Color.FromArgb(64, 64, 64);
            MeuProgresso.Size = new Size(739, 16);
            MeuProgresso.TabIndex = 6;
            MeuProgresso.Value = 50;
            MeuProgresso.ValueByTransition = 50;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(180, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(94, 148, 255);
            ClientSize = new Size(739, 281);
            Controls.Add(pictureBox1);
            Controls.Add(MeuProgresso);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Bunifu.UI.WinForms.BunifuProgressBar MeuProgresso;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}