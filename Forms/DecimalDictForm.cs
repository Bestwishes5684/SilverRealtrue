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
    public partial class DecimalDictForm : Form
    {
        public DecimalDictForm()
        {
            InitializeComponent();
            InitDatagrid();
        }

        public void InitDatagrid()
        {
            using (var db = new SilverREContext())
            {
                dataGridDecimal.DataSource = db.DecimalNumber.ToList();

                dataGridDecimal.Columns["IdDecimal"].HeaderText = "Идентификатор номера";
                dataGridDecimal.Columns["TitleDecimal"].HeaderText = "Децимальный номер";
                dataGridDecimal.Columns["Check"].Visible = false;
                dataGridDecimal.Columns["Norm"].Visible = false;


            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            using (var db = new SilverREContext())
            {
                if (textBoxSearch.Text != "")
                {

                    dataGridDecimal.DataSource = db.DecimalNumber.Where(x => x.TitleDecimal.Contains(textBoxSearch.Text)).ToList();

                }
                else
                {
                    InitDatagrid();
                }
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var db = new SilverREContext())
            {
                DecimalNumber newDecimal = new DecimalNumber
                {
                    TitleDecimal = textBoxSearch.Text,
                };

                db.DecimalNumber.Add(newDecimal);
                db.SaveChanges();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            using (var db = new SilverREContext())
            {
                var selected = Convert.ToInt32(dataGridDecimal.Rows[dataGridDecimal.SelectedRows[0].Index].Cells[0].Value);
                var editDecimal = db.DecimalNumber.FirstOrDefault(x => x.IdDecimal == selected);

                EditDecimalForm editDecimalForm = new EditDecimalForm(editDecimal);


                if (editDecimalForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Децимальный номер успешно изменён");
                    InitDatagrid();
                }

            }
        }
    }
}
