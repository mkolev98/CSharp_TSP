namespace Zadacha1
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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.x1_result = new System.Windows.Forms.Label();
            this.x2_result = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.disc_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(89, 53);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(19, 13);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "a=";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(89, 88);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(19, 13);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "b=";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(89, 123);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(19, 13);
            this.labelC.TabIndex = 2;
            this.labelC.Text = "c=";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(89, 190);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(24, 13);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "x1=";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(89, 231);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(24, 13);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "x2=";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(129, 53);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 5;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(129, 85);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 6;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(129, 114);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 20);
            this.textBoxC.TabIndex = 7;
            // 
            // x1_result
            // 
            this.x1_result.AutoSize = true;
            this.x1_result.Location = new System.Drawing.Point(141, 189);
            this.x1_result.Name = "x1_result";
            this.x1_result.Size = new System.Drawing.Size(35, 13);
            this.x1_result.TabIndex = 8;
            this.x1_result.Text = "label1";
            // 
            // x2_result
            // 
            this.x2_result.AutoSize = true;
            this.x2_result.Location = new System.Drawing.Point(141, 231);
            this.x2_result.Name = "x2_result";
            this.x2_result.Size = new System.Drawing.Size(35, 13);
            this.x2_result.TabIndex = 9;
            this.x2_result.Text = "label1";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(276, 189);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(113, 55);
            this.btn_calc.TabIndex = 10;
            this.btn_calc.Text = "Calc";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // disc_label
            // 
            this.disc_label.AutoSize = true;
            this.disc_label.Location = new System.Drawing.Point(126, 149);
            this.disc_label.Name = "disc_label";
            this.disc_label.Size = new System.Drawing.Size(35, 13);
            this.disc_label.TabIndex = 11;
            this.disc_label.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "disc=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 299);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disc_label);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.x2_result);
            this.Controls.Add(this.x1_result);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label x1_result;
        private System.Windows.Forms.Label x2_result;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label disc_label;
        private System.Windows.Forms.Label label1;
    }
}

