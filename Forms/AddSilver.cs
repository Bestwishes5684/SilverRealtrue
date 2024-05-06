using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SilverRealtrue.ModelsAndContex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SilverRealtrue
{
    public partial class AddSilver : Form
    {
        public AddSilver()
        {
            InitializeComponent();

            using (var db = new SilverREContext())
            {



                comboBox1.DataSource = db.SilverType.ToList();
                comboBox2.DataSource=db.DecimalNumber.ToList();
                comboBox1.SelectedIndex= 0;
                comboBox2.SelectedIndex= 0;


                comboBox1.DisplayMember = nameof(SilverType.TitleSilverType);
                comboBox2.DisplayMember = nameof(DecimalNumber.TitleDecimal);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new SilverREContext())
            {



                Check check = new Check
                {


                    DateCheck = DateTime.Now,
                    DepartmentCheck = Convert.ToInt32(textBox4.Text),
                    NormCheck = textBox1.Text,
                    SilverTypeCheck = ((SilverType)comboBox1.SelectedItem).CodeSilverType,
                    CoverageCheck= Convert.ToDecimal(textBox3.Text),
                    AmountCheck=Convert.ToInt32(textBox5.Text),
                    DecimalCheck=((DecimalNumber)comboBox2.SelectedItem).IdDecimal,
              
                    OrderCheck = textBox2.Text



                };

                db.Check.Add(check);
                db.SaveChanges();
                this.Close();

               

            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
