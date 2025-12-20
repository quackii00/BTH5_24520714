namespace Bai11
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxBrushes = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonLGB = new System.Windows.Forms.RadioButton();
            this.radioButtonTextureBrush = new System.Windows.Forms.RadioButton();
            this.radioButtonHatchBrush = new System.Windows.Forms.RadioButton();
            this.radioButtonSolidBrush = new System.Windows.Forms.RadioButton();
            this.groupBoxPen = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnColor = new System.Windows.Forms.Button();
            this.labelWidth = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.groupBoxShape = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.panelDrawing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxBrushes.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBoxPen.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxShape.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel2.Controls.Add(this.panelDrawing);
            this.splitContainer1.Size = new System.Drawing.Size(1174, 929);
            this.splitContainer1.SplitterDistance = 391;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxBrushes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxPen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxShape, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(25);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.91468F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.63936F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.44596F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 929);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxBrushes
            // 
            this.groupBoxBrushes.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxBrushes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBrushes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBrushes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBoxBrushes.Location = new System.Drawing.Point(28, 462);
            this.groupBoxBrushes.Margin = new System.Windows.Forms.Padding(3, 20, 3, 5);
            this.groupBoxBrushes.Name = "groupBoxBrushes";
            this.groupBoxBrushes.Size = new System.Drawing.Size(335, 437);
            this.groupBoxBrushes.TabIndex = 2;
            this.groupBoxBrushes.TabStop = false;
            this.groupBoxBrushes.Text = "Brushes";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.radioButtonLGB, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.radioButtonTextureBrush, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.radioButtonHatchBrush, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.radioButtonSolidBrush, 0, 0);
            this.tableLayoutPanel4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(21, 58);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(273, 240);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // radioButtonLGB
            // 
            this.radioButtonLGB.AutoSize = true;
            this.radioButtonLGB.Location = new System.Drawing.Point(3, 183);
            this.radioButtonLGB.Name = "radioButtonLGB";
            this.radioButtonLGB.Size = new System.Drawing.Size(265, 33);
            this.radioButtonLGB.TabIndex = 3;
            this.radioButtonLGB.TabStop = true;
            this.radioButtonLGB.Text = "LinearGradientBrush";
            this.radioButtonLGB.UseVisualStyleBackColor = true;
            this.radioButtonLGB.CheckedChanged += new System.EventHandler(this.BrushesChanged);
            // 
            // radioButtonTextureBrush
            // 
            this.radioButtonTextureBrush.AutoSize = true;
            this.radioButtonTextureBrush.Location = new System.Drawing.Point(3, 123);
            this.radioButtonTextureBrush.Name = "radioButtonTextureBrush";
            this.radioButtonTextureBrush.Size = new System.Drawing.Size(188, 33);
            this.radioButtonTextureBrush.TabIndex = 2;
            this.radioButtonTextureBrush.TabStop = true;
            this.radioButtonTextureBrush.Text = "TextureBrush";
            this.radioButtonTextureBrush.UseVisualStyleBackColor = true;
            this.radioButtonTextureBrush.CheckedChanged += new System.EventHandler(this.BrushesChanged);
            // 
            // radioButtonHatchBrush
            // 
            this.radioButtonHatchBrush.AutoSize = true;
            this.radioButtonHatchBrush.Location = new System.Drawing.Point(3, 63);
            this.radioButtonHatchBrush.Name = "radioButtonHatchBrush";
            this.radioButtonHatchBrush.Size = new System.Drawing.Size(167, 33);
            this.radioButtonHatchBrush.TabIndex = 1;
            this.radioButtonHatchBrush.TabStop = true;
            this.radioButtonHatchBrush.Text = "HatchBrush";
            this.radioButtonHatchBrush.UseVisualStyleBackColor = true;
            this.radioButtonHatchBrush.CheckedChanged += new System.EventHandler(this.BrushesChanged);
            // 
            // radioButtonSolidBrush
            // 
            this.radioButtonSolidBrush.AutoSize = true;
            this.radioButtonSolidBrush.Location = new System.Drawing.Point(3, 3);
            this.radioButtonSolidBrush.Name = "radioButtonSolidBrush";
            this.radioButtonSolidBrush.Size = new System.Drawing.Size(162, 33);
            this.radioButtonSolidBrush.TabIndex = 0;
            this.radioButtonSolidBrush.TabStop = true;
            this.radioButtonSolidBrush.Text = "SolidBrush";
            this.radioButtonSolidBrush.UseVisualStyleBackColor = true;
            this.radioButtonSolidBrush.CheckedChanged += new System.EventHandler(this.BrushesChanged);
            // 
            // groupBoxPen
            // 
            this.groupBoxPen.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxPen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBoxPen.Location = new System.Drawing.Point(28, 264);
            this.groupBoxPen.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.groupBoxPen.Name = "groupBoxPen";
            this.groupBoxPen.Size = new System.Drawing.Size(335, 175);
            this.groupBoxPen.TabIndex = 1;
            this.groupBoxPen.TabStop = false;
            this.groupBoxPen.Text = "Pen";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.7347F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.2653F));
            this.tableLayoutPanel3.Controls.Add(this.btnColor, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelWidth, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtWidth, 1, 0);
            this.tableLayoutPanel3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(18, 48);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(273, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnColor
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.btnColor, 2);
            this.btnColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnColor.Location = new System.Drawing.Point(50, 50);
            this.btnColor.Margin = new System.Windows.Forms.Padding(50, 0, 50, 3);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(173, 47);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Color...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWidth.Location = new System.Drawing.Point(3, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(94, 50);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "Width:";
            // 
            // txtWidth
            // 
            this.txtWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWidth.Location = new System.Drawing.Point(103, 0);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(3, 0, 90, 3);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(80, 35);
            this.txtWidth.TabIndex = 1;
            this.txtWidth.TextChanged += new System.EventHandler(this.CheckWidth);
            // 
            // groupBoxShape
            // 
            this.groupBoxShape.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxShape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxShape.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBoxShape.Location = new System.Drawing.Point(28, 28);
            this.groupBoxShape.Name = "groupBoxShape";
            this.groupBoxShape.Size = new System.Drawing.Size(335, 213);
            this.groupBoxShape.TabIndex = 0;
            this.groupBoxShape.TabStop = false;
            this.groupBoxShape.Text = "Shapes";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonEllipse, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonRectangle, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonLine, 0, 0);
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 51);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(233, 141);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;
            this.radioButtonEllipse.Location = new System.Drawing.Point(3, 97);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(118, 33);
            this.radioButtonEllipse.TabIndex = 2;
            this.radioButtonEllipse.TabStop = true;
            this.radioButtonEllipse.Text = "Ellipse";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            this.radioButtonEllipse.CheckedChanged += new System.EventHandler(this.ShapesChanged);
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(3, 50);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(153, 33);
            this.radioButtonRectangle.TabIndex = 1;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Rectangle";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            this.radioButtonRectangle.CheckedChanged += new System.EventHandler(this.ShapesChanged);
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Location = new System.Drawing.Point(3, 3);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(90, 33);
            this.radioButtonLine.TabIndex = 0;
            this.radioButtonLine.TabStop = true;
            this.radioButtonLine.Text = "Line";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            this.radioButtonLine.CheckedChanged += new System.EventHandler(this.ShapesChanged);
            // 
            // panelDrawing
            // 
            this.panelDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDrawing.Location = new System.Drawing.Point(0, 0);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(779, 929);
            this.panelDrawing.TabIndex = 0;
            this.panelDrawing.TabStop = false;
            this.panelDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawShape);
            this.panelDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartDrawing);
            this.panelDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drawing);
            this.panelDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EndDrawing);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 929);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai Thi";
            this.Resize += new System.EventHandler(this.ChangeSize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxBrushes.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBoxPen.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBoxShape.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDrawing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxBrushes;
        private System.Windows.Forms.GroupBox groupBoxPen;
        private System.Windows.Forms.GroupBox groupBoxShape;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButtonEllipse;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton radioButtonLGB;
        private System.Windows.Forms.RadioButton radioButtonTextureBrush;
        private System.Windows.Forms.RadioButton radioButtonHatchBrush;
        private System.Windows.Forms.RadioButton radioButtonSolidBrush;
        private System.Windows.Forms.PictureBox panelDrawing;
    }
}

