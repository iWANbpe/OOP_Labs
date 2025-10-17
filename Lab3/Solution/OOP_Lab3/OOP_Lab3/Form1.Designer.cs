
namespace OOP_Lab3
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Dot_StripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Line_StripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Rectangle_StripButton3 = new System.Windows.Forms.ToolStripButton();
            this.Circle_StripButton4 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dot_StripButton1,
            this.Line_StripButton2,
            this.Rectangle_StripButton3,
            this.Circle_StripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1279, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Dot_StripButton1
            // 
            this.Dot_StripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Dot_StripButton1.Image = global::OOP_Lab3.Properties.Resources.DotIcon;
            this.Dot_StripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Dot_StripButton1.Name = "Dot_StripButton1";
            this.Dot_StripButton1.Size = new System.Drawing.Size(29, 29);
            this.Dot_StripButton1.Text = "Dot";
            // 
            // Line_StripButton2
            // 
            this.Line_StripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Line_StripButton2.Image = global::OOP_Lab3.Properties.Resources.LineIcon;
            this.Line_StripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line_StripButton2.Name = "Line_StripButton2";
            this.Line_StripButton2.Size = new System.Drawing.Size(29, 29);
            this.Line_StripButton2.Text = "Line";
            // 
            // Rectangle_StripButton3
            // 
            this.Rectangle_StripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rectangle_StripButton3.Image = global::OOP_Lab3.Properties.Resources.RectIcon;
            this.Rectangle_StripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rectangle_StripButton3.Name = "Rectangle_StripButton3";
            this.Rectangle_StripButton3.Size = new System.Drawing.Size(29, 29);
            this.Rectangle_StripButton3.Text = "Rectangle";
            // 
            // Circle_StripButton4
            // 
            this.Circle_StripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Circle_StripButton4.Image = global::OOP_Lab3.Properties.Resources.CircleIcon;
            this.Circle_StripButton4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Circle_StripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Circle_StripButton4.Name = "Circle_StripButton4";
            this.Circle_StripButton4.Size = new System.Drawing.Size(29, 29);
            this.Circle_StripButton4.Text = "Circle";
            this.Circle_StripButton4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1279, 610);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1177, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "113/113";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1011, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "                   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 644);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Dot_StripButton1;
        private System.Windows.Forms.ToolStripButton Line_StripButton2;
        private System.Windows.Forms.ToolStripButton Rectangle_StripButton3;
        private System.Windows.Forms.ToolStripButton Circle_StripButton4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

