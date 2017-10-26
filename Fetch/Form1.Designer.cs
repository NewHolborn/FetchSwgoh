namespace Fetch
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
            this.butFetch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butFetch
            // 
            this.butFetch.Location = new System.Drawing.Point(12, 12);
            this.butFetch.Name = "butFetch";
            this.butFetch.Size = new System.Drawing.Size(75, 23);
            this.butFetch.TabIndex = 0;
            this.butFetch.Text = "Fetch";
            this.butFetch.UseVisualStyleBackColor = true;
            this.butFetch.Click += new System.EventHandler(this.butFetch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 192);
            this.Controls.Add(this.butFetch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butFetch;
    }
}

