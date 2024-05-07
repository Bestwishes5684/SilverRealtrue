using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverRealtrue
{
    public partial class Search : Form
    {
        public static string searchRequest;
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchRequest = textBoxSearch.Text;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
