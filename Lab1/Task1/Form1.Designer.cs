
namespace Lab1
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
            this.process1 = new System.Windows.Forms.ListBox();
            this.process0 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_process_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // process1
            // 
            this.process1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.process1.FormattingEnabled = true;
            this.process1.ItemHeight = 25;
            this.process1.Items.AddRange(new object[] {
            " while (1)",
            "  {",
            "    while (numProc == 0) {};",
            "    Критическая секция 1; ",
            "    numProc = 0;",
            "  }"});
            this.process1.Location = new System.Drawing.Point(500, 40);
            this.process1.Margin = new System.Windows.Forms.Padding(6);
            this.process1.Name = "process1";
            this.process1.Size = new System.Drawing.Size(406, 179);
            this.process1.TabIndex = 13;
            // 
            // process0
            // 
            this.process0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.process0.FormattingEnabled = true;
            this.process0.ItemHeight = 25;
            this.process0.Items.AddRange(new object[] {
            "while (1)",
            "  {",
            "    while (numProc == 1) {};",
            "    Критическая секция 0; ",
            "    numProc = 1;",
            "  }"});
            this.process0.Location = new System.Drawing.Point(24, 40);
            this.process0.Margin = new System.Windows.Forms.Padding(6);
            this.process0.Name = "process0";
            this.process0.Size = new System.Drawing.Size(412, 179);
            this.process0.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(626, 303);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "Step";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 303);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Step";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_process_num
            // 
            this.label_process_num.AutoSize = true;
            this.label_process_num.Location = new System.Drawing.Point(346, 354);
            this.label_process_num.Name = "label_process_num";
            this.label_process_num.Size = new System.Drawing.Size(214, 25);
            this.label_process_num.TabIndex = 14;
            this.label_process_num.Text = "Номер процесса = 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 467);
            this.Controls.Add(this.label_process_num);
            this.Controls.Add(this.process1);
            this.Controls.Add(this.process0);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Алгоритм 1 Жданов В.И. 525-Б";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox process1;
        private System.Windows.Forms.ListBox process0;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_process_num;
    }
}

