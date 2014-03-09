using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int x = Form.ActiveForm.Width - 10;
            int y = Form.ActiveForm.Height - 62;
            Zakladki.Size = new Size(x,y);
        }


        

       



     


    }
}
