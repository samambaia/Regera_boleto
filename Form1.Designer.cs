namespace RegeraBoleto
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
            this.label1 = new System.Windows.Forms.Label();
            this.sCodeBar1 = new System.Windows.Forms.TextBox();
            this.sCodeBar2 = new System.Windows.Forms.TextBox();
            this.sCodeBar3 = new System.Windows.Forms.TextBox();
            this.sCodeBar4 = new System.Windows.Forms.TextBox();
            this.sCodeBar5 = new System.Windows.Forms.TextBox();
            this.sCodeBar6 = new System.Windows.Forms.TextBox();
            this.sCodeBar7 = new System.Windows.Forms.TextBox();
            this.sCodeBar8 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_vencimento = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Barra:";
            // 
            // sCodeBar1
            // 
            this.sCodeBar1.Location = new System.Drawing.Point(26, 25);
            this.sCodeBar1.Name = "sCodeBar1";
            this.sCodeBar1.Size = new System.Drawing.Size(68, 20);
            this.sCodeBar1.TabIndex = 1;
            this.sCodeBar1.TextChanged += new System.EventHandler(this.sCodeBar1_TextChanged);
            // 
            // sCodeBar2
            // 
            this.sCodeBar2.Location = new System.Drawing.Point(100, 25);
            this.sCodeBar2.Name = "sCodeBar2";
            this.sCodeBar2.Size = new System.Drawing.Size(68, 20);
            this.sCodeBar2.TabIndex = 2;
            this.sCodeBar2.TextChanged += new System.EventHandler(this.sCodeBar1_TextChanged);
            // 
            // sCodeBar3
            // 
            this.sCodeBar3.Location = new System.Drawing.Point(174, 25);
            this.sCodeBar3.Name = "sCodeBar3";
            this.sCodeBar3.Size = new System.Drawing.Size(68, 20);
            this.sCodeBar3.TabIndex = 3;
            this.sCodeBar3.TextChanged += new System.EventHandler(this.sCodeBar1_TextChanged);
            // 
            // sCodeBar4
            // 
            this.sCodeBar4.Location = new System.Drawing.Point(248, 25);
            this.sCodeBar4.Name = "sCodeBar4";
            this.sCodeBar4.Size = new System.Drawing.Size(68, 20);
            this.sCodeBar4.TabIndex = 4;
            this.sCodeBar4.TextChanged += new System.EventHandler(this.sCodeBar1_TextChanged);
            // 
            // sCodeBar5
            // 
            this.sCodeBar5.Location = new System.Drawing.Point(322, 25);
            this.sCodeBar5.Name = "sCodeBar5";
            this.sCodeBar5.Size = new System.Drawing.Size(68, 20);
            this.sCodeBar5.TabIndex = 5;
            this.sCodeBar5.TextChanged += new System.EventHandler(this.sCodeBar1_TextChanged);
            // 
            // sCodeBar6
            // 
            this.sCodeBar6.Location = new System.Drawing.Point(396, 25);
            this.sCodeBar6.Name = "sCodeBar6";
            this.sCodeBar6.Size = new System.Drawing.Size(68, 20);
            this.sCodeBar6.TabIndex = 6;
            this.sCodeBar6.TextChanged += new System.EventHandler(this.sCodeBar1_TextChanged);
            // 
            // sCodeBar7
            // 
            this.sCodeBar7.Location = new System.Drawing.Point(470, 25);
            this.sCodeBar7.Name = "sCodeBar7";
            this.sCodeBar7.Size = new System.Drawing.Size(25, 20);
            this.sCodeBar7.TabIndex = 7;
            this.sCodeBar7.TextChanged += new System.EventHandler(this.sCodeBar1_TextChanged);
            // 
            // sCodeBar8
            // 
            this.sCodeBar8.Location = new System.Drawing.Point(501, 25);
            this.sCodeBar8.Name = "sCodeBar8";
            this.sCodeBar8.Size = new System.Drawing.Size(141, 20);
            this.sCodeBar8.TabIndex = 8;
            this.sCodeBar8.TextChanged += new System.EventHandler(this.sCodeBar1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Processar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vencimento";
            // 
            // dt_vencimento
            // 
            this.dt_vencimento.Location = new System.Drawing.Point(26, 68);
            this.dt_vencimento.Name = "dt_vencimento";
            this.dt_vencimento.Size = new System.Drawing.Size(100, 20);
            this.dt_vencimento.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri Light", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(26, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(627, 35);
            this.textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 218);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dt_vencimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sCodeBar8);
            this.Controls.Add(this.sCodeBar7);
            this.Controls.Add(this.sCodeBar6);
            this.Controls.Add(this.sCodeBar5);
            this.Controls.Add(this.sCodeBar4);
            this.Controls.Add(this.sCodeBar3);
            this.Controls.Add(this.sCodeBar2);
            this.Controls.Add(this.sCodeBar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regera BOLETO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sCodeBar1;
        private System.Windows.Forms.TextBox sCodeBar2;
        private System.Windows.Forms.TextBox sCodeBar3;
        private System.Windows.Forms.TextBox sCodeBar4;
        private System.Windows.Forms.TextBox sCodeBar5;
        private System.Windows.Forms.TextBox sCodeBar6;
        private System.Windows.Forms.TextBox sCodeBar7;
        private System.Windows.Forms.TextBox sCodeBar8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dt_vencimento;
        private System.Windows.Forms.TextBox textBox1;
    }
}

