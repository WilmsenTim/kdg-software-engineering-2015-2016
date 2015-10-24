namespace Roulette
{
    partial class LockView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_lock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_lock
            // 
            this.btn_lock.Location = new System.Drawing.Point(23, 14);
            this.btn_lock.Name = "btn_lock";
            this.btn_lock.Size = new System.Drawing.Size(213, 38);
            this.btn_lock.TabIndex = 0;
            this.btn_lock.Text = "Lock";
            this.btn_lock.UseVisualStyleBackColor = true;
            this.btn_lock.Click += new System.EventHandler(this.btn_lock_Click);
            // 
            // LockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.Controls.Add(this.btn_lock);
            this.Name = "LockView";
            this.Size = new System.Drawing.Size(256, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_lock;
    }
}
