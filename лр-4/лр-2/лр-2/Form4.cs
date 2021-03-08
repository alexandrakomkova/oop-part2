using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //Form1 form1 = new Form1();
        //public Form4(Form1 form1)
        //{
        //    InitializeComponent();
        //}


        private void Form4_Load(object sender, EventArgs e)
        {
            this.richResult.Text = Form1.result;
        }
       
        private void richResult_TextChanged(object sender, EventArgs e)
        {
            //this.richResult.Text = Form1.result;
        }

      
    }
}
