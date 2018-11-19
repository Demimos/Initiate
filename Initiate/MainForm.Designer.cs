namespace Initiate
{
    partial class MainForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Step = new System.Windows.Forms.Button();
            this.Configure = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 329);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(713, 360);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(75, 23);
            this.Step.TabIndex = 1;
            this.Step.Text = "Step";
            this.Step.UseVisualStyleBackColor = true;
            this.Step.Click += new System.EventHandler(this.Step_Click);
            // 
            // Configure
            // 
            this.Configure.Location = new System.Drawing.Point(13, 360);
            this.Configure.Name = "Configure";
            this.Configure.Size = new System.Drawing.Size(75, 23);
            this.Configure.TabIndex = 2;
            this.Configure.Text = "Configure";
            this.Configure.UseVisualStyleBackColor = true;
            this.Configure.Click += new System.EventHandler(this.Configure_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Очерёдность хода";
            // 
            // ReCalc
            // 
            this.ReCalc.Location = new System.Drawing.Point(681, 415);
            this.ReCalc.Name = "ReCalc";
            this.ReCalc.Size = new System.Drawing.Size(107, 23);
            this.ReCalc.TabIndex = 4;
            this.ReCalc.Text = "Пересчитать";
            this.ReCalc.UseVisualStyleBackColor = true;
            this.ReCalc.Click += new System.EventHandler(this.ReCalc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Configure);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.listBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Step;
        private System.Windows.Forms.Button Configure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReCalc;
    }
}

