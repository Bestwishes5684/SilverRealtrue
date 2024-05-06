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



                comboBoxType.DataSource = db.SilverType.ToList();
                comboBoxDecimal.DataSource = db.DecimalNumber.ToList();


                comboBoxType.DisplayMember = nameof(SilverType.TitleSilverType);
                comboBoxDecimal.DisplayMember = nameof(DecimalNumber.TitleDecimal);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new SilverREContext())
            {



                Check newCheck = new Check
                {
                    DateCheck = DateTime.Now,
                    DepartmentCheck = Convert.ToInt32(comboBoxDepart.SelectedItem),
                    NormCheck = textBoxNorm.Text,
                    SilverTypeCheck = ((SilverType)comboBoxType.SelectedItem).CodeSilverType,
                    CoverageCheck = Convert.ToDecimal(maskedTextBoxCover.Text),
                    AmountCheck = Convert.ToInt32(numericUpDownAmount.Value),
                    DecimalCheck = ((DecimalNumber)comboBoxDecimal.SelectedItem).IdDecimal,
                    OrderCheck = textBoxOrder.Text
                };

                db.Check.Add(newCheck);
                db.SaveChanges();

                MessageBox.Show("Успешное добавление");

                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBoxNorm_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
