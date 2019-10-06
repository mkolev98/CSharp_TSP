namespace Zadacha1b
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.x1_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.x1_result = new System.Windows.Forms.Label();
            this.x2_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(45, 57);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(19, 13);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "a=";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(45, 89);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(19, 13);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "b=";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(45, 122);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(19, 13);
            this.labelC.TabIndex = 2;
            this.labelC.Text = "c=";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(82, 49);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 3;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(82, 82);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 4;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(82, 115);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 20);
            this.textBoxC.TabIndex = 5;
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxC_TextChanged);
            // 
            // x1_label
            // 
            this.x1_label.AutoSize = true;
            this.x1_label.Location = new System.Drawing.Point(45, 176);
            this.x1_label.Name = "x1_label";
            this.x1_label.Size = new System.Drawing.Size(27, 13);
            this.x1_label.TabIndex = 6;
            this.x1_label.Text = "x1 =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "x1 =";
            // 
            // x1_result
            // 
            this.x1_result.AutoSize = true;
            this.x1_result.Location = new System.Drawing.Point(96, 175);
            this.x1_result.Name = "x1_result";
            this.x1_result.Size = new System.Drawing.Size(35, 13);
            this.x1_result.TabIndex = 8;
            this.x1_result.Text = "label2";
            // 
            // x2_result
            // 
            this.x2_result.AutoSize = true;
            this.x2_result.Location = new System.Drawing.Point(99, 200);
            this.x2_result.Name = "x2_result";
            this.x2_result.Size = new System.Drawing.Size(35, 13);
            this.x2_result.TabIndex = 9;
            this.x2_result.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 440);
            this.Controls.Add(this.x2_result);
            this.Controls.Add(this.x1_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x1_label);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
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
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label x1_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label x1_result;
        private System.Windows.Forms.Label x2_result;
    }
}

