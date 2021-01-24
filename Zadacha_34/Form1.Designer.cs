namespace Zadacha_34
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
            this.textBoxWriter = new System.Windows.Forms.TextBox();
            this.buttonWriter = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.listBoxRead = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxWriter
            // 
            this.textBoxWriter.Location = new System.Drawing.Point(12, 78);
            this.textBoxWriter.Multiline = true;
            this.textBoxWriter.Name = "textBoxWriter";
            this.textBoxWriter.Size = new System.Drawing.Size(202, 212);
            this.textBoxWriter.TabIndex = 0;
            // 
            // buttonWriter
            // 
            this.buttonWriter.Location = new System.Drawing.Point(12, 305);
            this.buttonWriter.Name = "buttonWriter";
            this.buttonWriter.Size = new System.Drawing.Size(75, 23);
            this.buttonWriter.TabIndex = 1;
            this.buttonWriter.Text = "Запись";
            this.buttonWriter.UseVisualStyleBackColor = true;
            this.buttonWriter.Click += new System.EventHandler(this.buttonWriter_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(257, 305);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 3;
            this.buttonRead.Text = "OK";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // listBoxRead
            // 
            this.listBoxRead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxRead.FormattingEnabled = true;
            this.listBoxRead.Location = new System.Drawing.Point(242, 78);
            this.listBoxRead.Name = "listBoxRead";
            this.listBoxRead.Size = new System.Drawing.Size(202, 212);
            this.listBoxRead.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 468);
            this.Controls.Add(this.listBoxRead);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonWriter);
            this.Controls.Add(this.textBoxWriter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWriter;
        private System.Windows.Forms.Button buttonWriter;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.ListBox listBoxRead;
    }
}

