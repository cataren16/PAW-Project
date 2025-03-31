namespace WindowsFormsApp1
{
    partial class Form2
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
            this.tbComboInstrument = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSimbol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbDivident = new System.Windows.Forms.TextBox();
            this.tbDobanda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbComboInstrument
            // 
            this.tbComboInstrument.AllowDrop = true;
            this.tbComboInstrument.FormattingEnabled = true;
            this.tbComboInstrument.Items.AddRange(new object[] {
            "Actiune",
            "Obligatiune"});
            this.tbComboInstrument.Location = new System.Drawing.Point(255, 96);
            this.tbComboInstrument.Name = "tbComboInstrument";
            this.tbComboInstrument.Size = new System.Drawing.Size(228, 24);
            this.tbComboInstrument.TabIndex = 0;
            this.tbComboInstrument.SelectedIndexChanged += new System.EventHandler(this.tbComboInstrument_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alege tipul instrumentului:";
            // 
            // tbSimbol
            // 
            this.tbSimbol.Location = new System.Drawing.Point(255, 157);
            this.tbSimbol.Name = "tbSimbol";
            this.tbSimbol.Size = new System.Drawing.Size(228, 22);
            this.tbSimbol.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Simbol:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(255, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Inregistreaza operatiune";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Mergi Inapoi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // tbDivident
            // 
            this.tbDivident.Location = new System.Drawing.Point(255, 219);
            this.tbDivident.Name = "tbDivident";
            this.tbDivident.Size = new System.Drawing.Size(228, 22);
            this.tbDivident.TabIndex = 9;
            // 
            // tbDobanda
            // 
            this.tbDobanda.Location = new System.Drawing.Point(255, 219);
            this.tbDobanda.Name = "tbDobanda";
            this.tbDobanda.Size = new System.Drawing.Size(228, 22);
            this.tbDobanda.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Procent Divident:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dobanda";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDobanda);
            this.Controls.Add(this.tbDivident);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSimbol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbComboInstrument);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tbComboInstrument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSimbol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDobanda;
        private System.Windows.Forms.TextBox tbDivident;
    }
}