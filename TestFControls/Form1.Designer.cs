namespace TestFControls
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
            this.fButton1 = new FControls.FButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fLabel1 = new FControls.FLabel();
            this.SuspendLayout();
            // 
            // fButton1
            // 
            this.fButton1.BorderRadius = 10;
            this.fButton1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fButton1.ClickContourColor = System.Drawing.Color.White;
            this.fButton1.Font = new System.Drawing.Font("Verdana", 10F);
            this.fButton1.ForeColor = System.Drawing.Color.White;
            this.fButton1.GradientFill = true;
            this.fButton1.Location = new System.Drawing.Point(89, 105);
            this.fButton1.MouseEnterBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.fButton1.MouseEnterLightness = ((byte)(50));
            this.fButton1.MouseEnterMutate = true;
            this.fButton1.MouseEnterMutation = FControls.FButton.MouseEnterMutationEnum.ChangeLightness;
            this.fButton1.MouseEnterTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.fButton1.Name = "fButton1";
            this.fButton1.Size = new System.Drawing.Size(117, 28);
            this.fButton1.TabIndex = 0;
            this.fButton1.Text = "Show It";
            this.fButton1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.fButton1.Click += new System.EventHandler(this.fButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 1;
            // 
            // fLabel1
            // 
            this.fLabel1.AutoSize = true;
            this.fLabel1.Font = new System.Drawing.Font("Verdana", 12F);
            this.fLabel1.Location = new System.Drawing.Point(75, 37);
            this.fLabel1.Name = "fLabel1";
            this.fLabel1.Size = new System.Drawing.Size(139, 18);
            this.fLabel1.TabIndex = 2;
            this.fLabel1.Text = "Type your name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(290, 164);
            this.Controls.Add(this.fLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fButton1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FControls.FButton fButton1;
        private System.Windows.Forms.TextBox textBox1;
        private FControls.FLabel fLabel1;
    }
}

