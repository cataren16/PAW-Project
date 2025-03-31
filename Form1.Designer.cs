namespace WindowsFormsApp1
{
    partial class Form1
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btAdaugaInstrument = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btCreazaPortofoliu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbValoare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(244, 113);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(235, 22);
            this.tbNume.TabIndex = 0;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(244, 177);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(235, 22);
            this.tbPrenume.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(244, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Verifica Portofoliu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prenume:";
            // 
            // btAdaugaInstrument
            // 
            this.btAdaugaInstrument.BackColor = System.Drawing.SystemColors.GrayText;
            this.btAdaugaInstrument.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAdaugaInstrument.Location = new System.Drawing.Point(3, 401);
            this.btAdaugaInstrument.Name = "btAdaugaInstrument";
            this.btAdaugaInstrument.Size = new System.Drawing.Size(235, 37);
            this.btAdaugaInstrument.TabIndex = 5;
            this.btAdaugaInstrument.Text = "Adauga Instrument";
            this.btAdaugaInstrument.UseVisualStyleBackColor = false;
            this.btAdaugaInstrument.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(553, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 37);
            this.button3.TabIndex = 6;
            this.button3.Text = "Vizualizare Portofoliu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btCreazaPortofoliu
            // 
            this.btCreazaPortofoliu.BackColor = System.Drawing.SystemColors.GrayText;
            this.btCreazaPortofoliu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCreazaPortofoliu.Location = new System.Drawing.Point(3, 401);
            this.btCreazaPortofoliu.Name = "btCreazaPortofoliu";
            this.btCreazaPortofoliu.Size = new System.Drawing.Size(235, 37);
            this.btCreazaPortofoliu.TabIndex = 7;
            this.btCreazaPortofoliu.Text = "Creaza portofoliu";
            this.btCreazaPortofoliu.UseVisualStyleBackColor = false;
            this.btCreazaPortofoliu.Click += new System.EventHandler(this.btCreazaPortofoliu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 8;
            // 
            // tbValoare
            // 
            this.tbValoare.BackColor = System.Drawing.SystemColors.Info;
            this.tbValoare.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbValoare.Location = new System.Drawing.Point(600, 177);
            this.tbValoare.Name = "tbValoare";
            this.tbValoare.ReadOnly = true;
            this.tbValoare.Size = new System.Drawing.Size(143, 22);
            this.tbValoare.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valoare portofoliu:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(627, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Calculeaza";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbValoare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCreazaPortofoliu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btAdaugaInstrument);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdaugaInstrument;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btCreazaPortofoliu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbValoare;
        private System.Windows.Forms.Button button2;
    }
}

