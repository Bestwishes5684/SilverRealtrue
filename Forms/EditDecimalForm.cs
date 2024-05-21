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

namespace SilverRealtrue.Forms
{
    public partial class EditDecimalForm : Form
    {
        private DecimalNumber editDecimal;
        public EditDecimalForm()
        {
            InitializeComponent();
        }

        public EditDecimalForm(DecimalNumber decimalNumber) : this()
        {
            Text = "Редактирование";
            buttonEdit.Text = "Изменить";

            editDecimal = decimalNumber;

            textBoxID.Text = editDecimal.IdDecimal.ToString();
            textBoxDecimalNum.Text = editDecimal.TitleDecimal;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            using (var db = new SilverREContext())
            {
                if (buttonEdit.Text == "Изменить")
                {
                    editDecimal.TitleDecimal = textBoxDecimalNum.Text;

                    db.DecimalNumber.Update(editDecimal);
                    db.SaveChanges();
                }
                else
                {
                    DecimalNumber newDecimal = new DecimalNumber
                    {
                        TitleDecimal = textBoxDecimalNum.Text,
                    };

                    db.DecimalNumber.Add(newDecimal);
                    db.SaveChanges();
                }
               

                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
