namespace WindowsFormsApplication1
{
    partial class Emulador
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.med_lb = new System.Windows.Forms.Label();
            this.bt_inicio = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conexãoToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // conexãoToolStripMenuItem
            // 
            this.conexãoToolStripMenuItem.Name = "conexãoToolStripMenuItem";
            this.conexãoToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.conexãoToolStripMenuItem.Text = "Conexão";
            this.conexãoToolStripMenuItem.Click += new System.EventHandler(this.conexãoToolStripMenuItem_Click);
            // 
            // med_lb
            // 
            this.med_lb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.med_lb.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_lb.ForeColor = System.Drawing.Color.Lime;
            this.med_lb.Location = new System.Drawing.Point(95, 98);
            this.med_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.med_lb.Name = "med_lb";
            this.med_lb.Size = new System.Drawing.Size(80, 43);
            this.med_lb.TabIndex = 2;
            this.med_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_inicio
            // 
            this.bt_inicio.Location = new System.Drawing.Point(341, 44);
            this.bt_inicio.Margin = new System.Windows.Forms.Padding(4);
            this.bt_inicio.Name = "bt_inicio";
            this.bt_inicio.Size = new System.Drawing.Size(131, 28);
            this.bt_inicio.TabIndex = 3;
            this.bt_inicio.Text = "INICIAR";
            this.bt_inicio.UseVisualStyleBackColor = true;
            this.bt_inicio.Click += new System.EventHandler(this.Bt_inicio_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM13";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.vazao1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 432);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Emulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 464);
            this.Controls.Add(this.bt_inicio);
            this.Controls.Add(this.med_lb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Emulador";
            this.Text = "Emulador 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexãoToolStripMenuItem;
        private System.Windows.Forms.Label med_lb;
        private System.Windows.Forms.Button bt_inicio;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

