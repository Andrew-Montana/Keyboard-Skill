namespace Keyboard_Skill
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label_Total = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_Good = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_Bad = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_Accuracy = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_Difficulty = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("HP Simplified", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBox1.ItemHeight = 111;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(823, 139);
            this.listBox1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_Total,
            this.label_Good,
            this.label_Bad,
            this.label_Accuracy,
            this.label_Difficulty,
            this.difficultyProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 117);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(823, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // label_Total
            // 
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(50, 17);
            this.label_Total.Text = "Всего: 0";
            // 
            // label_Good
            // 
            this.label_Good.Name = "label_Good";
            this.label_Good.Size = new System.Drawing.Size(59, 17);
            this.label_Good.Text = "Удачно: 0";
            // 
            // label_Bad
            // 
            this.label_Bad.Name = "label_Bad";
            this.label_Bad.Size = new System.Drawing.Size(73, 17);
            this.label_Bad.Text = "Неудачно: 0";
            // 
            // label_Accuracy
            // 
            this.label_Accuracy.Name = "label_Accuracy";
            this.label_Accuracy.Size = new System.Drawing.Size(81, 17);
            this.label_Accuracy.Text = "Точность: 0%";
            // 
            // label_Difficulty
            // 
            this.label_Difficulty.Name = "label_Difficulty";
            this.label_Difficulty.Size = new System.Drawing.Size(451, 17);
            this.label_Difficulty.Spring = true;
            this.label_Difficulty.Text = "Сложность";
            this.label_Difficulty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // difficultyProgressBar
            // 
            this.difficultyProgressBar.Maximum = 700;
            this.difficultyProgressBar.Name = "difficultyProgressBar";
            this.difficultyProgressBar.Size = new System.Drawing.Size(400, 16);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 139);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Keyboard Skill";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel label_Total;
        private System.Windows.Forms.ToolStripStatusLabel label_Good;
        private System.Windows.Forms.ToolStripStatusLabel label_Bad;
        private System.Windows.Forms.ToolStripStatusLabel label_Accuracy;
        private System.Windows.Forms.ToolStripStatusLabel label_Difficulty;
        private System.Windows.Forms.ToolStripProgressBar difficultyProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}

