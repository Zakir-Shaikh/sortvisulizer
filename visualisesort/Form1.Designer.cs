namespace visualisesort
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
            this.pnlmoniter = new System.Windows.Forms.Panel();
            this.btnbubblesort = new System.Windows.Forms.Button();
            this.pnlcount = new System.Windows.Forms.Panel();
            this.lblloopcount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlcount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmoniter
            // 
            this.pnlmoniter.BackColor = System.Drawing.Color.Transparent;
            this.pnlmoniter.Location = new System.Drawing.Point(12, 26);
            this.pnlmoniter.Name = "pnlmoniter";
            this.pnlmoniter.Size = new System.Drawing.Size(688, 412);
            this.pnlmoniter.TabIndex = 0;
            this.pnlmoniter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMonitor_Paint);
            // 
            // btnbubblesort
            // 
            this.btnbubblesort.Location = new System.Drawing.Point(713, 135);
            this.btnbubblesort.Name = "btnbubblesort";
            this.btnbubblesort.Size = new System.Drawing.Size(75, 23);
            this.btnbubblesort.TabIndex = 1;
            this.btnbubblesort.Text = "bubble sort";
            this.btnbubblesort.UseVisualStyleBackColor = true;
            this.btnbubblesort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // pnlcount
            // 
            this.pnlcount.Controls.Add(this.lblloopcount);
            this.pnlcount.Controls.Add(this.label1);
            this.pnlcount.Location = new System.Drawing.Point(713, 26);
            this.pnlcount.Name = "pnlcount";
            this.pnlcount.Size = new System.Drawing.Size(75, 90);
            this.pnlcount.TabIndex = 2;
            // 
            // lblloopcount
            // 
            this.lblloopcount.AutoSize = true;
            this.lblloopcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloopcount.Location = new System.Drawing.Point(19, 34);
            this.lblloopcount.Name = "lblloopcount";
            this.lblloopcount.Size = new System.Drawing.Size(15, 16);
            this.lblloopcount.TabIndex = 1;
            this.lblloopcount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "loop";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlcount);
            this.Controls.Add(this.btnbubblesort);
            this.Controls.Add(this.pnlmoniter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlcount.ResumeLayout(false);
            this.pnlcount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmoniter;
        private System.Windows.Forms.Button btnbubblesort;
        private System.Windows.Forms.Panel pnlcount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblloopcount;
    }
}

