
namespace лр_2
{
    partial class Form4
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
            this.richResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richResult
            // 
            this.richResult.Location = new System.Drawing.Point(23, 21);
            this.richResult.Name = "richResult";
            this.richResult.ReadOnly = true;
            this.richResult.Size = new System.Drawing.Size(352, 250);
            this.richResult.TabIndex = 0;
            this.richResult.Text = "";
            this.richResult.TextChanged += new System.EventHandler(this.richResult_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 342);
            this.Controls.Add(this.richResult);
            this.Name = "Form4";
            this.Text = "Sort by";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richResult;
    }
}