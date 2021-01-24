namespace Zadacha_35
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.buttonSetNandK = new System.Windows.Forms.Button();
            this.listBoxRes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(16, 43);
            this.textBoxN.Multiline = true;
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(36, 28);
            this.textBoxN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Укажите значение N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Укажите значение K";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(171, 43);
            this.textBoxK.Multiline = true;
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(36, 28);
            this.textBoxK.TabIndex = 3;
            // 
            // buttonSetNandK
            // 
            this.buttonSetNandK.Location = new System.Drawing.Point(79, 83);
            this.buttonSetNandK.Name = "buttonSetNandK";
            this.buttonSetNandK.Size = new System.Drawing.Size(75, 23);
            this.buttonSetNandK.TabIndex = 4;
            this.buttonSetNandK.Text = "OK";
            this.buttonSetNandK.UseVisualStyleBackColor = true;
            this.buttonSetNandK.Click += new System.EventHandler(this.buttonSetNandK_Click);
            // 
            // listBoxRes
            // 
            this.listBoxRes.FormattingEnabled = true;
            this.listBoxRes.Location = new System.Drawing.Point(16, 138);
            this.listBoxRes.Name = "listBoxRes";
            this.listBoxRes.Size = new System.Drawing.Size(191, 95);
            this.listBoxRes.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 338);
            this.Controls.Add(this.listBoxRes);
            this.Controls.Add(this.buttonSetNandK);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Button buttonSetNandK;
        private System.Windows.Forms.ListBox listBoxRes;
    }
}

