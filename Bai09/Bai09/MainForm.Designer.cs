namespace Bai09
{
    partial class MainForm
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
            this.comboBoxTest = new System.Windows.Forms.ComboBox();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.DrawPlace = new System.Windows.Forms.PictureBox();
            this.panelDrawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTest
            // 
            this.comboBoxTest.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTest.FormattingEnabled = true;
            this.comboBoxTest.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Ellipse",
            "Pie",
            "Filled Circle",
            "Filled Square",
            "Filled Ellipse",
            "Filled Pie"});
            this.comboBoxTest.Location = new System.Drawing.Point(38, 45);
            this.comboBoxTest.Name = "comboBoxTest";
            this.comboBoxTest.Size = new System.Drawing.Size(363, 49);
            this.comboBoxTest.TabIndex = 0;
            this.comboBoxTest.SelectionChangeCommitted += new System.EventHandler(this.ShapeChanged);
            // 
            // panelDrawing
            // 
            this.panelDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDrawing.Controls.Add(this.DrawPlace);
            this.panelDrawing.Location = new System.Drawing.Point(38, 131);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(830, 454);
            this.panelDrawing.TabIndex = 1;
            // 
            // DrawPlace
            // 
            this.DrawPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawPlace.Location = new System.Drawing.Point(0, 0);
            this.DrawPlace.Name = "DrawPlace";
            this.DrawPlace.Size = new System.Drawing.Size(830, 454);
            this.DrawPlace.TabIndex = 0;
            this.DrawPlace.TabStop = false;
            this.DrawPlace.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintShape);
            this.DrawPlace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartDrawing);
            this.DrawPlace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drawing);
            this.DrawPlace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EndDrawing);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 613);
            this.Controls.Add(this.panelDrawing);
            this.Controls.Add(this.comboBoxTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "ComboBoxTest";
            this.panelDrawing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DrawPlace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTest;
        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.PictureBox DrawPlace;
    }
}

