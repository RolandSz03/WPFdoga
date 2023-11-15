namespace WPFdoga
{
    partial class MainForm
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
            label1 = new Label();
            TxtNev = new TextBox();
            Btnkoszonj = new Button();
            lbludvozles = new Label();
            lblPiros = new Label();
            lblZold = new Label();
            lblKek = new Label();
            txtszam2 = new TextBox();
            txtszam1 = new TextBox();
            btnPlusz = new Button();
            btnMinusz = new Button();
            btnOsztas = new Button();
            btnSzorzas = new Button();
            label2 = new Label();
            txtEredmeny = new TextBox();
            btnSzamol = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 40);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "név:";
            // 
            // TxtNev
            // 
            TxtNev.Location = new Point(58, 32);
            TxtNev.Name = "TxtNev";
            TxtNev.Size = new Size(111, 23);
            TxtNev.TabIndex = 1;
            TxtNev.TextChanged += TxtNev_TextChanged;
            // 
            // Btnkoszonj
            // 
            Btnkoszonj.Location = new Point(184, 32);
            Btnkoszonj.Name = "Btnkoszonj";
            Btnkoszonj.Size = new Size(86, 23);
            Btnkoszonj.TabIndex = 2;
            Btnkoszonj.Text = "Köszönj!";
            Btnkoszonj.UseVisualStyleBackColor = true;
            // 
            // lbludvozles
            // 
            lbludvozles.AutoSize = true;
            lbludvozles.BackColor = Color.Yellow;
            lbludvozles.Font = new Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbludvozles.Location = new Point(23, 79);
            lbludvozles.Name = "lbludvozles";
            lbludvozles.Padding = new Padding(15);
            lbludvozles.Size = new Size(250, 52);
            lbludvozles.TabIndex = 3;
            lbludvozles.Text = "###UDVOZLES###";
            // 
            // lblPiros
            // 
            lblPiros.BackColor = Color.Red;
            lblPiros.Location = new Point(290, 14);
            lblPiros.Name = "lblPiros";
            lblPiros.Size = new Size(52, 41);
            lblPiros.TabIndex = 4;
            lblPiros.Text = "piros";
            // 
            // lblZold
            // 
            lblZold.BackColor = Color.Lime;
            lblZold.Location = new Point(348, 14);
            lblZold.Name = "lblZold";
            lblZold.Size = new Size(53, 41);
            lblZold.TabIndex = 5;
            lblZold.Text = "zöld";
            // 
            // lblKek
            // 
            lblKek.BackColor = Color.DodgerBlue;
            lblKek.Location = new Point(407, 14);
            lblKek.Name = "lblKek";
            lblKek.Size = new Size(49, 41);
            lblKek.TabIndex = 6;
            lblKek.Text = "kék";
            // 
            // txtszam2
            // 
            txtszam2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtszam2.Location = new Point(166, 169);
            txtszam2.Name = "txtszam2";
            txtszam2.Size = new Size(52, 35);
            txtszam2.TabIndex = 7;
            // 
            // txtszam1
            // 
            txtszam1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtszam1.Location = new Point(23, 169);
            txtszam1.Name = "txtszam1";
            txtszam1.Size = new Size(52, 35);
            txtszam1.TabIndex = 7;
            // 
            // btnPlusz
            // 
            btnPlusz.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlusz.Location = new Point(81, 153);
            btnPlusz.Name = "btnPlusz";
            btnPlusz.Size = new Size(33, 29);
            btnPlusz.TabIndex = 8;
            btnPlusz.Text = "+";
            btnPlusz.UseVisualStyleBackColor = true;
            // 
            // btnMinusz
            // 
            btnMinusz.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinusz.Location = new Point(120, 153);
            btnMinusz.Name = "btnMinusz";
            btnMinusz.Size = new Size(33, 29);
            btnMinusz.TabIndex = 8;
            btnMinusz.Text = "-";
            btnMinusz.UseVisualStyleBackColor = true;
            // 
            // btnOsztas
            // 
            btnOsztas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOsztas.Location = new Point(120, 188);
            btnOsztas.Name = "btnOsztas";
            btnOsztas.Size = new Size(33, 29);
            btnOsztas.TabIndex = 8;
            btnOsztas.Text = "/";
            btnOsztas.UseVisualStyleBackColor = true;
            // 
            // btnSzorzas
            // 
            btnSzorzas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSzorzas.Location = new Point(81, 188);
            btnSzorzas.Name = "btnSzorzas";
            btnSzorzas.Size = new Size(33, 29);
            btnSzorzas.TabIndex = 8;
            btnSzorzas.Text = "*";
            btnSzorzas.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(237, 168);
            label2.Name = "label2";
            label2.Size = new Size(33, 36);
            label2.TabIndex = 9;
            label2.Text = "=";
            // 
            // txtEredmeny
            // 
            txtEredmeny.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtEredmeny.Location = new Point(290, 170);
            txtEredmeny.Name = "txtEredmeny";
            txtEredmeny.Size = new Size(145, 34);
            txtEredmeny.TabIndex = 10;
            txtEredmeny.Text = "#eredmeny#";
            txtEredmeny.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSzamol
            // 
            btnSzamol.Location = new Point(23, 246);
            btnSzamol.Name = "btnSzamol";
            btnSzamol.Size = new Size(412, 23);
            btnSzamol.TabIndex = 11;
            btnSzamol.Text = "Számolj!";
            btnSzamol.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 450);
            Controls.Add(btnSzamol);
            Controls.Add(txtEredmeny);
            Controls.Add(label2);
            Controls.Add(btnSzorzas);
            Controls.Add(btnOsztas);
            Controls.Add(btnMinusz);
            Controls.Add(btnPlusz);
            Controls.Add(txtszam1);
            Controls.Add(txtszam2);
            Controls.Add(lblKek);
            Controls.Add(lblZold);
            Controls.Add(lblPiros);
            Controls.Add(lbludvozles);
            Controls.Add(Btnkoszonj);
            Controls.Add(TxtNev);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "WFA dolgozat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtNev;
        private Button Btnkoszonj;
        private Label lbludvozles;
        private Label lblPiros;
        private Label lblZold;
        private Label lblKek;
        private TextBox txtszam2;
        private TextBox txtszam1;
        private Button btnPlusz;
        private Button btnMinusz;
        private Button btnOsztas;
        private Button btnSzorzas;
        private Label label2;
        private TextBox txtEredmeny;
        private Button btnSzamol;
    }
}