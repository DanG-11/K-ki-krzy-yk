namespace Kółki_krzyżyk
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
            btnLewoGora1 = new Button();
            btnGora2 = new Button();
            btnPrawoGora3 = new Button();
            btnLewo4 = new Button();
            btnSrodek5 = new Button();
            btnPrawo6 = new Button();
            btnLewoDol7 = new Button();
            btnDol8 = new Button();
            btnPrawoDol9 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblAktywnyGracz = new Label();
            btnReset = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLewoGora1
            // 
            btnLewoGora1.Location = new Point(3, 35);
            btnLewoGora1.Name = "btnLewoGora1";
            btnLewoGora1.Size = new Size(119, 104);
            btnLewoGora1.TabIndex = 0;
            btnLewoGora1.Text = "1";
            btnLewoGora1.UseVisualStyleBackColor = true;
            btnLewoGora1.Click += btnLewoGora1_Click;
            // 
            // btnGora2
            // 
            btnGora2.Location = new Point(130, 35);
            btnGora2.Name = "btnGora2";
            btnGora2.Size = new Size(119, 104);
            btnGora2.TabIndex = 1;
            btnGora2.Text = "2";
            btnGora2.UseVisualStyleBackColor = true;
            btnGora2.Click += btnGora2_Click;
            // 
            // btnPrawoGora3
            // 
            btnPrawoGora3.Location = new Point(257, 35);
            btnPrawoGora3.Name = "btnPrawoGora3";
            btnPrawoGora3.Size = new Size(119, 104);
            btnPrawoGora3.TabIndex = 2;
            btnPrawoGora3.Text = "3";
            btnPrawoGora3.UseVisualStyleBackColor = true;
            btnPrawoGora3.Click += btnPrawoGora3_Click;
            // 
            // btnLewo4
            // 
            btnLewo4.Location = new Point(3, 146);
            btnLewo4.Name = "btnLewo4";
            btnLewo4.Size = new Size(119, 118);
            btnLewo4.TabIndex = 3;
            btnLewo4.Text = "4";
            btnLewo4.UseVisualStyleBackColor = true;
            btnLewo4.Click += btnLewo4_Click;
            // 
            // btnSrodek5
            // 
            btnSrodek5.Location = new Point(130, 146);
            btnSrodek5.Name = "btnSrodek5";
            btnSrodek5.Size = new Size(119, 118);
            btnSrodek5.TabIndex = 4;
            btnSrodek5.Text = "5";
            btnSrodek5.UseVisualStyleBackColor = true;
            btnSrodek5.Click += btnSrodek5_Click;
            // 
            // btnPrawo6
            // 
            btnPrawo6.Location = new Point(257, 146);
            btnPrawo6.Name = "btnPrawo6";
            btnPrawo6.Size = new Size(119, 118);
            btnPrawo6.TabIndex = 5;
            btnPrawo6.Text = "6";
            btnPrawo6.UseVisualStyleBackColor = true;
            btnPrawo6.Click += btnPrawo6_Click;
            // 
            // btnLewoDol7
            // 
            btnLewoDol7.Location = new Point(3, 270);
            btnLewoDol7.Name = "btnLewoDol7";
            btnLewoDol7.Size = new Size(119, 118);
            btnLewoDol7.TabIndex = 6;
            btnLewoDol7.Text = "7";
            btnLewoDol7.UseVisualStyleBackColor = true;
            btnLewoDol7.Click += btnLewoDol7_Click;
            // 
            // btnDol8
            // 
            btnDol8.Location = new Point(130, 270);
            btnDol8.Name = "btnDol8";
            btnDol8.Size = new Size(119, 118);
            btnDol8.TabIndex = 7;
            btnDol8.Text = "8";
            btnDol8.UseVisualStyleBackColor = true;
            btnDol8.Click += btnDol8_Click;
            // 
            // btnPrawoDol9
            // 
            btnPrawoDol9.Location = new Point(257, 270);
            btnPrawoDol9.Name = "btnPrawoDol9";
            btnPrawoDol9.Size = new Size(119, 118);
            btnPrawoDol9.TabIndex = 8;
            btnPrawoDol9.Text = "9";
            btnPrawoDol9.UseVisualStyleBackColor = true;
            btnPrawoDol9.Click += btnPrawoDol9_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.Controls.Add(btnDol8, 1, 3);
            tableLayoutPanel1.Controls.Add(btnPrawoDol9, 2, 3);
            tableLayoutPanel1.Controls.Add(btnLewoDol7, 0, 3);
            tableLayoutPanel1.Controls.Add(btnLewo4, 0, 2);
            tableLayoutPanel1.Controls.Add(btnSrodek5, 1, 2);
            tableLayoutPanel1.Controls.Add(btnPrawo6, 2, 2);
            tableLayoutPanel1.Controls.Add(btnPrawoGora3, 2, 1);
            tableLayoutPanel1.Controls.Add(btnGora2, 1, 1);
            tableLayoutPanel1.Controls.Add(btnLewoGora1, 0, 1);
            tableLayoutPanel1.Controls.Add(lblAktywnyGracz, 1, 0);
            tableLayoutPanel1.Controls.Add(btnReset, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.5352116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 77.46479F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 124F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 123F));
            tableLayoutPanel1.Size = new Size(384, 391);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // lblAktywnyGracz
            // 
            lblAktywnyGracz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAktywnyGracz.AutoSize = true;
            lblAktywnyGracz.Location = new Point(130, 0);
            lblAktywnyGracz.Name = "lblAktywnyGracz";
            lblAktywnyGracz.Size = new Size(121, 32);
            lblAktywnyGracz.TabIndex = 9;
            lblAktywnyGracz.Text = "Aktywny gracz:";
            lblAktywnyGracz.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(3, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(119, 26);
            btnReset.TabIndex = 10;
            btnReset.Text = "Następna partia";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 391);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLewoGora1;
        private Button btnGora2;
        private Button btnPrawoGora3;
        private Button btnLewo4;
        private Button btnSrodek5;
        private Button btnPrawo6;
        private Button btnLewoDol7;
        private Button btnDol8;
        private Button btnPrawoDol9;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblAktywnyGracz;
        private Button btnReset;
    }
}
