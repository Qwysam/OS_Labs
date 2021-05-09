
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label_numProc0 = new System.Windows.Forms.Label();
            this.label_numProc1 = new System.Windows.Forms.Label();
            this.label_j0 = new System.Windows.Forms.Label();
            this.label_j1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // process1
            // 
            this.process1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.process1.FormattingEnabled = true;
            this.process1.ItemHeight = 25;
            this.process1.Items.AddRange(new object[] {
            "  while (1)",
            "  {",
            "    inProc [1] = true;",
            "    numProc[1] = max(numProc[0], numProc[1])+1; ",
            "    inProc [1] = false;",
            "    for (int j = 0; j< 2; j++)",
            "    {",
            "      while(numProc[j]){};",
            "      while(numProc[j]!=0 && (numProc[j]<numProc[1] || (numProc[j]==numProc[1] &&" +
                " j<1))){};",
            "    };",
            "    Критический участок 1;",
            "    numProc[1] = 0;",
            "  }"});
            this.process1.Location = new System.Drawing.Point(24, 474);
            this.process1.Margin = new System.Windows.Forms.Padding(6);
            this.process1.Name = "process1";
            this.process1.Size = new System.Drawing.Size(1343, 354);
            this.process1.TabIndex = 13;
            // 
            // process0
            // 
            this.process0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.process0.FormattingEnabled = true;
            this.process0.ItemHeight = 25;
            this.process0.Items.AddRange(new object[] {
            "  while (1)",
            "  {",
            "    inProc [i] = true;",
            "    numProc[i] = max(numProc[0], numProc[1])+1; ",
            "    inProc [i] = false;",
            "    for (int j = 0; j< 2; j++)",
            "    {",
            "      while(numProc[j]){};",
            "      while(numProc[j]!=0 && (numProc[j]<numProc[1] || (numProc[j]==numProc[1] &&" +
                " j<i))){};",
            "    };",
            "    Критический участок 0;",
            "    numProc[0] = 0;",
            "  }"});
            this.process0.Location = new System.Drawing.Point(24, 40);
            this.process0.Margin = new System.Windows.Forms.Padding(6);
            this.process0.Name = "process0";
            this.process0.Size = new System.Drawing.Size(1343, 354);
            this.process0.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1454, 661);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "Step";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1454, 179);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Step";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1475, 526);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 29);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "InProc[0]";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1475, 575);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(129, 29);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "InProc[1]";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label_numProc0
            // 
            this.label_numProc0.AutoSize = true;
            this.label_numProc0.Location = new System.Drawing.Point(1470, 290);
            this.label_numProc0.Name = "label_numProc0";
            this.label_numProc0.Size = new System.Drawing.Size(163, 25);
            this.label_numProc0.TabIndex = 16;
            this.label_numProc0.Text = "numProc [0] = 0";
            // 
            // label_numProc1
            // 
            this.label_numProc1.AutoSize = true;
            this.label_numProc1.Location = new System.Drawing.Point(1470, 358);
            this.label_numProc1.Name = "label_numProc1";
            this.label_numProc1.Size = new System.Drawing.Size(163, 25);
            this.label_numProc1.TabIndex = 17;
            this.label_numProc1.Text = "numProc [1] = 0";
            // 
            // label_j0
            // 
            this.label_j0.AutoSize = true;
            this.label_j0.Location = new System.Drawing.Point(1470, 414);
            this.label_j0.Name = "label_j0";
            this.label_j0.Size = new System.Drawing.Size(85, 25);
            this.label_j0.TabIndex = 18;
            this.label_j0.Text = "j (0) = 0";
            // 
            // label_j1
            // 
            this.label_j1.AutoSize = true;
            this.label_j1.Location = new System.Drawing.Point(1470, 465);
            this.label_j1.Name = "label_j1";
            this.label_j1.Size = new System.Drawing.Size(85, 25);
            this.label_j1.TabIndex = 19;
            this.label_j1.Text = "j (1) = 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1424, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 351);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1675, 864);
            this.Controls.Add(this.label_j1);
            this.Controls.Add(this.label_j0);
            this.Controls.Add(this.label_numProc1);
            this.Controls.Add(this.label_numProc0);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.process1);
            this.Controls.Add(this.process0);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Алгоритм Лампорта Жданов В.И. 525-Б";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox process1;
        private System.Windows.Forms.ListBox process0;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label_numProc0;
        private System.Windows.Forms.Label label_numProc1;
        private System.Windows.Forms.Label label_j0;
        private System.Windows.Forms.Label label_j1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

