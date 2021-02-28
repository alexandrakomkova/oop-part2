
namespace лр_2
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textFindName = new System.Windows.Forms.TextBox();
            this.textPriceLow = new System.Windows.Forms.TextBox();
            this.textPriceUp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboFindType = new System.Windows.Forms.ComboBox();
            this.richFindResult = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.backToForm1 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя для поиска:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите тип товара:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите диапазон \r\nцены для поиска:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 3;
            // 
            // textFindName
            // 
            this.textFindName.Location = new System.Drawing.Point(224, 36);
            this.textFindName.Name = "textFindName";
            this.textFindName.Size = new System.Drawing.Size(121, 22);
            this.textFindName.TabIndex = 4;
            this.textFindName.TextChanged += new System.EventHandler(this.textFindName_TextChanged);
            // 
            // textPriceLow
            // 
            this.textPriceLow.Location = new System.Drawing.Point(224, 118);
            this.textPriceLow.Name = "textPriceLow";
            this.textPriceLow.Size = new System.Drawing.Size(43, 22);
            this.textPriceLow.TabIndex = 5;
            this.textPriceLow.Text = "0";
            // 
            // textPriceUp
            // 
            this.textPriceUp.Location = new System.Drawing.Point(302, 118);
            this.textPriceUp.Name = "textPriceUp";
            this.textPriceUp.Size = new System.Drawing.Size(43, 22);
            this.textPriceUp.TabIndex = 6;
            this.textPriceUp.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "-";
            // 
            // comboFindType
            // 
            this.comboFindType.DisplayMember = "(нет)";
            this.comboFindType.FormattingEnabled = true;
            this.comboFindType.Items.AddRange(new object[] {
            "аксессуары",
            "одежда",
            "обувь"});
            this.comboFindType.Location = new System.Drawing.Point(224, 76);
            this.comboFindType.Name = "comboFindType";
            this.comboFindType.Size = new System.Drawing.Size(121, 24);
            this.comboFindType.TabIndex = 8;
            this.comboFindType.SelectedIndexChanged += new System.EventHandler(this.comboFindType_SelectedIndexChanged);
            // 
            // richFindResult
            // 
            this.richFindResult.Location = new System.Drawing.Point(49, 243);
            this.richFindResult.Name = "richFindResult";
            this.richFindResult.ReadOnly = true;
            this.richFindResult.Size = new System.Drawing.Size(342, 164);
            this.richFindResult.TabIndex = 9;
            this.richFindResult.Text = "";
            this.richFindResult.TextChanged += new System.EventHandler(this.richFindResult_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Найденные товары:";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(299, 161);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(92, 36);
            this.buttonFind.TabIndex = 11;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            this.buttonFind.Validating += new System.ComponentModel.CancelEventHandler(this.buttonFind_Validating);
            // 
            // backToForm1
            // 
            this.backToForm1.Location = new System.Drawing.Point(281, 430);
            this.backToForm1.Name = "backToForm1";
            this.backToForm1.Size = new System.Drawing.Size(106, 41);
            this.backToForm1.TabIndex = 15;
            this.backToForm1.Text = "Назад";
            this.backToForm1.UseVisualStyleBackColor = true;
            this.backToForm1.UseWaitCursor = true;
            this.backToForm1.Click += new System.EventHandler(this.backToForm1_Click_1);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(373, 118);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(373, 76);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(373, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "Сброс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 499);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backToForm1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richFindResult);
            this.Controls.Add(this.comboFindType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPriceUp);
            this.Controls.Add(this.textPriceLow);
            this.Controls.Add(this.textFindName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.Text = "Find";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFindName;
        private System.Windows.Forms.TextBox textPriceLow;
        private System.Windows.Forms.TextBox textPriceUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboFindType;
        private System.Windows.Forms.RichTextBox richFindResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button backToForm1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}