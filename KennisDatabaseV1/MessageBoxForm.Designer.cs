namespace KennisDatabaseV1
{
    partial class MessageBoxForm
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
            this.MessageBoxTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessageBoxTxt
            // 
            this.MessageBoxTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageBoxTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBoxTxt.Location = new System.Drawing.Point(0, 0);
            this.MessageBoxTxt.Multiline = true;
            this.MessageBoxTxt.Name = "MessageBoxTxt";
            this.MessageBoxTxt.ReadOnly = true;
            this.MessageBoxTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageBoxTxt.Size = new System.Drawing.Size(679, 576);
            this.MessageBoxTxt.TabIndex = 0;
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 576);
            this.Controls.Add(this.MessageBoxTxt);
            this.Name = "MessageBoxForm";
            this.Text = "MessageBox";
            this.Load += new System.EventHandler(this.MessageBoxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageBoxTxt;
    }
}