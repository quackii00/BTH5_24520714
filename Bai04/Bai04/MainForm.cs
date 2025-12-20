using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Bai04
{
    public partial class MainForm : Form
    {
        private bool isBold = false;
        private bool isItalic = false;
        private bool isUnderline = false;
        public MainForm()
        {
            InitializeComponent();
            int[] fontsize = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 72 };
            foreach (var size in fontsize)
            {
                comboBoxSize.Items.Add(size);
            }
            comboBoxSize.SelectedItem = (int)Math.Round(TxtBox.Font.Size);
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach ( var font in fonts.Families ) 
            {
                comboBoxFont.Items.Add( font.Name );
            }
            comboBoxFont.SelectedItem = TxtBox.Font.Name;
            radioButtonLeft.Checked = true;
            buttonColor.BackColor = Color.Black;
        }

        public void Update()
        {
            string name = comboBoxFont.SelectedItem.ToString();
            float size = int.Parse(comboBoxSize.SelectedItem.ToString());
            FontStyle style = FontStyle.Regular;
            if (isBold)
            {
                style |= FontStyle.Bold;
            }
            if (isItalic)
            {
                style |= FontStyle.Italic;
            }
            if (isUnderline)
            {
                style |= FontStyle.Underline;
            }

            Font font = new Font(name, size,style);
            TxtBox.SelectionFont = font;
        }

        private void ChangedFont(object sender, EventArgs e)
        {
            Update();
        }

        private void ChangedColor(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TxtBox.SelectionColor = dialog.Color;
                buttonColor.BackColor = dialog.Color;
            }
        }

        private void CheckItalic(object sender, EventArgs e)
        {
            isItalic = !isItalic;
            Update();
        }

        private void CheckBold(object sender, EventArgs e)
        {
            isBold = !isBold;
            Update();
        }

        private void CheckUnderline(object sender, EventArgs e)
        {
            isUnderline = !isUnderline;
            Update();
        }

        private void AlignTextChanged(object sender, EventArgs e)
        {

            if (radioButtonLeft.Checked)
            {
                TxtBox.SelectionAlignment = HorizontalAlignment.Left;
            }
            else if (radioButtonRight.Checked)
            {
                TxtBox.SelectionAlignment = HorizontalAlignment.Right;
            }
            else if (radioButtonCenter.Checked)
            {
                TxtBox.SelectionAlignment= HorizontalAlignment.Center;
            }    
            
            
        }
    }
}
