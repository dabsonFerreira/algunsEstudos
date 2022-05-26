namespace WindowsFormsApplication1
{
    partial class FormConfigConex
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_COM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_stopbit = new System.Windows.Forms.ComboBox();
            this.cb_paridade = new System.Windows.Forms.ComboBox();
            this.cb_baudrate = new System.Windows.Forms.ComboBox();
            this.cb_databits = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BAUDRATE";
            // 
            // cb_COM
            // 
            this.cb_COM.FormattingEnabled = true;
            this.cb_COM.Location = new System.Drawing.Point(100, 31);
            this.cb_COM.Name = "cb_COM";
            this.cb_COM.Size = new System.Drawing.Size(121, 21);
            this.cb_COM.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PORTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "STOPBIT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PARIDADE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "DATABITS";
            // 
            // cb_stopbit
            // 
            this.cb_stopbit.FormattingEnabled = true;
            this.cb_stopbit.Location = new System.Drawing.Point(100, 104);
            this.cb_stopbit.Name = "cb_stopbit";
            this.cb_stopbit.Size = new System.Drawing.Size(121, 21);
            this.cb_stopbit.TabIndex = 11;
            // 
            // cb_paridade
            // 
            this.cb_paridade.FormattingEnabled = true;
            this.cb_paridade.Location = new System.Drawing.Point(100, 129);
            this.cb_paridade.Name = "cb_paridade";
            this.cb_paridade.Size = new System.Drawing.Size(121, 21);
            this.cb_paridade.TabIndex = 12;
            // 
            // cb_baudrate
            // 
            this.cb_baudrate.FormattingEnabled = true;
            this.cb_baudrate.Location = new System.Drawing.Point(100, 56);
            this.cb_baudrate.Name = "cb_baudrate";
            this.cb_baudrate.Size = new System.Drawing.Size(121, 21);
            this.cb_baudrate.TabIndex = 13;
            // 
            // cb_databits
            // 
            this.cb_databits.FormattingEnabled = true;
            this.cb_databits.Location = new System.Drawing.Point(100, 80);
            this.cb_databits.Name = "cb_databits";
            this.cb_databits.Size = new System.Drawing.Size(121, 21);
            this.cb_databits.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "CONFIGURAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormConfigConex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 188);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_databits);
            this.Controls.Add(this.cb_baudrate);
            this.Controls.Add(this.cb_paridade);
            this.Controls.Add(this.cb_stopbit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_COM);
            this.Controls.Add(this.label1);
            this.Name = "FormConfigConex";
            this.Text = "CONFIGURAÇÕES PORTA SERIAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_COM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_stopbit;
        private System.Windows.Forms.ComboBox cb_paridade;
        private System.Windows.Forms.ComboBox cb_baudrate;
        private System.Windows.Forms.ComboBox cb_databits;
        private System.Windows.Forms.Button button1;
    }
}