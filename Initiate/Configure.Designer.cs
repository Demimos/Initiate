namespace Initiate
{
    partial class Configure
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
            this.Done = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DexterityBox = new System.Windows.Forms.TextBox();
            this.WitBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListBoxOfPlayers = new System.Windows.Forms.ListBox();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(713, 415);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 23);
            this.Done.TabIndex = 0;
            this.Done.Text = "Готово";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(338, 328);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(187, 238);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(226, 20);
            this.NameBox.TabIndex = 2;
            // 
            // DexterityBox
            // 
            this.DexterityBox.Location = new System.Drawing.Point(187, 283);
            this.DexterityBox.Name = "DexterityBox";
            this.DexterityBox.Size = new System.Drawing.Size(100, 20);
            this.DexterityBox.TabIndex = 3;
            // 
            // WitBox
            // 
            this.WitBox.Location = new System.Drawing.Point(187, 325);
            this.WitBox.Name = "WitBox";
            this.WitBox.Size = new System.Drawing.Size(100, 20);
            this.WitBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ловкость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сообразительность";
            // 
            // ListBoxOfPlayers
            // 
            this.ListBoxOfPlayers.FormattingEnabled = true;
            this.ListBoxOfPlayers.Location = new System.Drawing.Point(13, 13);
            this.ListBoxOfPlayers.Name = "ListBoxOfPlayers";
            this.ListBoxOfPlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ListBoxOfPlayers.Size = new System.Drawing.Size(655, 199);
            this.ListBoxOfPlayers.TabIndex = 8;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(532, 218);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(136, 23);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Удалить выделенное";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.ListBoxOfPlayers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WitBox);
            this.Controls.Add(this.DexterityBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Done);
            this.Name = "Configure";
            this.Text = "Редактор Списка Участников";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox DexterityBox;
        private System.Windows.Forms.TextBox WitBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListBoxOfPlayers;
        private System.Windows.Forms.Button Delete;
    }
}