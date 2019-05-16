namespace Minify_Project_Export
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SelectPath_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GetFils_btn = new System.Windows.Forms.Button();
            this.ListFiles = new System.Windows.Forms.ListBox();
            this.Filters = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FoundFile = new System.Windows.Forms.Label();
            this.FoundedLable = new System.Windows.Forms.Label();
            this.Copy_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectPath_btn
            // 
            this.SelectPath_btn.Location = new System.Drawing.Point(12, 12);
            this.SelectPath_btn.Name = "SelectPath_btn";
            this.SelectPath_btn.Size = new System.Drawing.Size(126, 23);
            this.SelectPath_btn.TabIndex = 0;
            this.SelectPath_btn.Text = "Choose Path";
            this.SelectPath_btn.UseVisualStyleBackColor = true;
            this.SelectPath_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // GetFils_btn
            // 
            this.GetFils_btn.Location = new System.Drawing.Point(12, 41);
            this.GetFils_btn.Name = "GetFils_btn";
            this.GetFils_btn.Size = new System.Drawing.Size(126, 23);
            this.GetFils_btn.TabIndex = 3;
            this.GetFils_btn.Text = "Get Files";
            this.GetFils_btn.UseVisualStyleBackColor = true;
            this.GetFils_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListFiles
            // 
            this.ListFiles.FormattingEnabled = true;
            this.ListFiles.Location = new System.Drawing.Point(12, 70);
            this.ListFiles.Name = "ListFiles";
            this.ListFiles.Size = new System.Drawing.Size(733, 277);
            this.ListFiles.TabIndex = 4;
            // 
            // Filters
            // 
            this.Filters.Location = new System.Drawing.Point(184, 44);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(561, 20);
            this.Filters.TabIndex = 5;
            this.Filters.Text = "*.json";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filters";
            // 
            // FoundFile
            // 
            this.FoundFile.AutoSize = true;
            this.FoundFile.Location = new System.Drawing.Point(12, 355);
            this.FoundFile.Name = "FoundFile";
            this.FoundFile.Size = new System.Drawing.Size(67, 13);
            this.FoundFile.TabIndex = 7;
            this.FoundFile.Text = "Files Found :";
            // 
            // FoundedLable
            // 
            this.FoundedLable.AutoSize = true;
            this.FoundedLable.Location = new System.Drawing.Point(80, 356);
            this.FoundedLable.Name = "FoundedLable";
            this.FoundedLable.Size = new System.Drawing.Size(13, 13);
            this.FoundedLable.TabIndex = 8;
            this.FoundedLable.Text = "0";
            // 
            // Copy_btn
            // 
            this.Copy_btn.Location = new System.Drawing.Point(99, 350);
            this.Copy_btn.Name = "Copy_btn";
            this.Copy_btn.Size = new System.Drawing.Size(646, 23);
            this.Copy_btn.TabIndex = 9;
            this.Copy_btn.Text = "Convert To TV Font Support";
            this.Copy_btn.UseVisualStyleBackColor = true;
            this.Copy_btn.Click += new System.EventHandler(this.Copy_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 378);
            this.Controls.Add(this.Copy_btn);
            this.Controls.Add(this.FoundedLable);
            this.Controls.Add(this.FoundFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Filters);
            this.Controls.Add(this.ListFiles);
            this.Controls.Add(this.GetFils_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectPath_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MRK Convertor Unicode Project By Filter Extenition - Aminio101";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectPath_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetFils_btn;
        private System.Windows.Forms.ListBox ListFiles;
        private System.Windows.Forms.TextBox Filters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FoundFile;
        private System.Windows.Forms.Label FoundedLable;
        private System.Windows.Forms.Button Copy_btn;
    }
}

