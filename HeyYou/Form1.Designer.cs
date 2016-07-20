namespace HeyYou
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
            this.DoIt = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoIt
            // 
            this.DoIt.Location = new System.Drawing.Point(83, 152);
            this.DoIt.Name = "DoIt";
            this.DoIt.Size = new System.Drawing.Size(126, 42);
            this.DoIt.TabIndex = 0;
            this.DoIt.Text = "Press Here";
            this.DoIt.UseVisualStyleBackColor = true;
            this.DoIt.Click += new System.EventHandler(this.DoIt_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(94, 58);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(96, 42);
            this.output.TabIndex = 1;
            this.output.Text = "Start";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.output);
            this.Controls.Add(this.DoIt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoIt;
        private System.Windows.Forms.Label output;
    }
}

