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
namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InstalledFontCollection font = new InstalledFontCollection();
            foreach (FontFamily item in font.Families)
            {
                Font newFont = new Font(item.Name, 14);
                txtBox.SelectionFont = newFont;
                txtBox.AppendText(" "+item.Name + "\n");
            }
        }
    }
}
