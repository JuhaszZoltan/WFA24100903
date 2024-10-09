namespace WFA24100903
{
    partial class FrmQuadratic
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
            lblUI01 = new Label();
            nudSD = new NumericUpDown();
            label1 = new Label();
            nudFD = new NumericUpDown();
            label3 = new Label();
            nudConst = new NumericUpDown();
            label2 = new Label();
            rtbSol = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)nudSD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudConst).BeginInit();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblUI01.Location = new Point(12, 9);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(245, 25);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Quadratic Equation Solver";
            // 
            // nudSD
            // 
            nudSD.DecimalPlaces = 2;
            nudSD.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            nudSD.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudSD.Location = new Point(12, 56);
            nudSD.Name = "nudSD";
            nudSD.Size = new Size(87, 32);
            nudSD.TabIndex = 1;
            nudSD.TextAlign = HorizontalAlignment.Right;
            nudSD.UpDownAlign = LeftRightAlignment.Left;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(107, 56);
            label1.Name = "label1";
            label1.Size = new Size(64, 32);
            label1.TabIndex = 0;
            label1.Text = "X² +";
            label1.Click += this.label1_Click;
            // 
            // nudFD
            // 
            nudFD.DecimalPlaces = 2;
            nudFD.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            nudFD.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudFD.Location = new Point(170, 56);
            nudFD.Name = "nudFD";
            nudFD.Size = new Size(87, 32);
            nudFD.TabIndex = 1;
            nudFD.TextAlign = HorizontalAlignment.Right;
            nudFD.UpDownAlign = LeftRightAlignment.Left;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(263, 56);
            label3.Name = "label3";
            label3.Size = new Size(54, 32);
            label3.TabIndex = 0;
            label3.Text = "X +";
            label3.Click += this.label1_Click;
            // 
            // nudConst
            // 
            nudConst.DecimalPlaces = 2;
            nudConst.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            nudConst.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudConst.Location = new Point(323, 56);
            nudConst.Name = "nudConst";
            nudConst.Size = new Size(87, 32);
            nudConst.TabIndex = 1;
            nudConst.TextAlign = HorizontalAlignment.Right;
            nudConst.UpDownAlign = LeftRightAlignment.Left;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(416, 56);
            label2.Name = "label2";
            label2.Size = new Size(59, 32);
            label2.TabIndex = 0;
            label2.Text = " = 0";
            label2.Click += this.label1_Click;
            // 
            // rtbSol
            // 
            rtbSol.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            rtbSol.Location = new Point(12, 114);
            rtbSol.Name = "rtbSol";
            rtbSol.Size = new Size(463, 66);
            rtbSol.TabIndex = 2;
            rtbSol.Text = "X₁ := \nX₂ :=";
            // 
            // FrmQuadratic
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 192);
            Controls.Add(rtbSol);
            Controls.Add(nudConst);
            Controls.Add(nudFD);
            Controls.Add(nudSD);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FrmQuadratic";
            Text = "Quadratic Equation Solver";
            ((System.ComponentModel.ISupportInitialize)nudSD).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFD).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudConst).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private NumericUpDown nudSD;
        private Label label1;
        private NumericUpDown nudFD;
        private Label label3;
        private NumericUpDown nudConst;
        private Label label2;
        private RichTextBox rtbSol;
    }
}
