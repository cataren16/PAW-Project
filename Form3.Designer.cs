namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.rbVanzare = new System.Windows.Forms.RadioButton();
            this.rbCumparare = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dbData = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbAdaugaOperatiune = new System.Windows.Forms.Button();
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // rbVanzare
            // 
            this.rbVanzare.AutoSize = true;
            this.rbVanzare.Location = new System.Drawing.Point(327, 90);
            this.rbVanzare.Name = "rbVanzare";
            this.rbVanzare.Size = new System.Drawing.Size(92, 20);
            this.rbVanzare.TabIndex = 0;
            this.rbVanzare.TabStop = true;
            this.rbVanzare.Text = "VANZARE";
            this.rbVanzare.UseVisualStyleBackColor = true;
            // 
            // rbCumparare
            // 
            this.rbCumparare.AutoSize = true;
            this.rbCumparare.Location = new System.Drawing.Point(327, 116);
            this.rbCumparare.Name = "rbCumparare";
            this.rbCumparare.Size = new System.Drawing.Size(114, 20);
            this.rbCumparare.TabIndex = 1;
            this.rbCumparare.TabStop = true;
            this.rbCumparare.Text = "CUMPARARE";
            this.rbCumparare.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alege tipul operatiunii";
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(115, 193);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(200, 22);
            this.tbPret.TabIndex = 3;
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(437, 193);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(200, 22);
            this.tbCantitate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pret:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantitate";
            // 
            // dbData
            // 
            this.dbData.Location = new System.Drawing.Point(286, 267);
            this.dbData.Name = "dbData";
            this.dbData.Size = new System.Drawing.Size(200, 22);
            this.dbData.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Haide sa adaugam o noua operatiune";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data tranzactiei";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Mergi Inapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbAdaugaOperatiune
            // 
            this.tbAdaugaOperatiune.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbAdaugaOperatiune.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbAdaugaOperatiune.Location = new System.Drawing.Point(233, 334);
            this.tbAdaugaOperatiune.Name = "tbAdaugaOperatiune";
            this.tbAdaugaOperatiune.Size = new System.Drawing.Size(297, 37);
            this.tbAdaugaOperatiune.TabIndex = 11;
            this.tbAdaugaOperatiune.Text = "Adauga Operatiune";
            this.tbAdaugaOperatiune.UseVisualStyleBackColor = false;
            this.tbAdaugaOperatiune.Click += new System.EventHandler(this.tbAdaugaOperatiune_Click);
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbAdaugaOperatiune);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dbData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbCumparare);
            this.Controls.Add(this.rbVanzare);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbVanzare;
        private System.Windows.Forms.RadioButton rbCumparare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dbData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tbAdaugaOperatiune;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}