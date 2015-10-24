namespace Roulette
{
    partial class BoardView
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
            this.Number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Number
            // 
            this.Number.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number.Cursor = System.Windows.Forms.Cursors.Default;
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Number.Location = new System.Drawing.Point(0, 0);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(32, 48);
            this.Number.TabIndex = 1;
            this.Number.Text = "1";
            this.Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Number);
            this.Name = "BoardView";
            this.Size = new System.Drawing.Size(30, 48);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Number;
    }
}
