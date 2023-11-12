namespace Semaphore_HW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WorkingThreadsList = new System.Windows.Forms.ListBox();
            this.WaitingThreadsList = new System.Windows.Forms.ListBox();
            this.CreatedThreadsList = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CreateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Working Threads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Waiting Threads";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Created Threads";
            // 
            // WorkingThreadsList
            // 
            this.WorkingThreadsList.FormattingEnabled = true;
            this.WorkingThreadsList.ItemHeight = 15;
            this.WorkingThreadsList.Location = new System.Drawing.Point(26, 60);
            this.WorkingThreadsList.Name = "WorkingThreadsList";
            this.WorkingThreadsList.Size = new System.Drawing.Size(120, 94);
            this.WorkingThreadsList.TabIndex = 3;
            // 
            // WaitingThreadsList
            // 
            this.WaitingThreadsList.FormattingEnabled = true;
            this.WaitingThreadsList.ItemHeight = 15;
            this.WaitingThreadsList.Location = new System.Drawing.Point(234, 60);
            this.WaitingThreadsList.Name = "WaitingThreadsList";
            this.WaitingThreadsList.Size = new System.Drawing.Size(120, 94);
            this.WaitingThreadsList.TabIndex = 4;
            // 
            // CreatedThreadsList
            // 
            this.CreatedThreadsList.FormattingEnabled = true;
            this.CreatedThreadsList.ItemHeight = 15;
            this.CreatedThreadsList.Location = new System.Drawing.Point(424, 60);
            this.CreatedThreadsList.Name = "CreatedThreadsList";
            this.CreatedThreadsList.Size = new System.Drawing.Size(120, 94);
            this.CreatedThreadsList.TabIndex = 5;
            this.CreatedThreadsList.SelectedIndexChanged += new System.EventHandler(this.CreatedThreadsList_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(26, 255);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 6;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(469, 253);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.CreatedThreadsList);
            this.Controls.Add(this.WaitingThreadsList);
            this.Controls.Add(this.WorkingThreadsList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox WorkingThreadsList;
        private ListBox WaitingThreadsList;
        private ListBox CreatedThreadsList;
        private NumericUpDown numericUpDown1;
        private Button CreateButton;
    }
}