namespace Lab8_2
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
            this.lb1 = new System.Windows.Forms.Label();
            this.btAns = new System.Windows.Forms.Button();
            this.lbAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(416, 100);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(53, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "На пару?";
            // 
            // btAns
            // 
            this.btAns.Location = new System.Drawing.Point(403, 128);
            this.btAns.Name = "btAns";
            this.btAns.Size = new System.Drawing.Size(75, 23);
            this.btAns.TabIndex = 1;
            this.btAns.Text = "Ответ";
            this.btAns.UseVisualStyleBackColor = true;
            this.btAns.Click += new System.EventHandler(this.btAns_Click);
            // 
            // lbAns
            // 
            this.lbAns.AutoSize = true;
            this.lbAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAns.Location = new System.Drawing.Point(401, 167);
            this.lbAns.Name = "lbAns";
            this.lbAns.Size = new System.Drawing.Size(0, 24);
            this.lbAns.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 570);
            this.Controls.Add(this.lbAns);
            this.Controls.Add(this.btAns);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btAns;
        private System.Windows.Forms.Label lbAns;
    }
}

