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

        private Check editCheck;
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

        public AddSilver(Check check) : this()
        {
            buttonAdd.Text = "Редактировать";
            Text = "Редактирование чека";

            textBoxNorm.Text = check.NormCheck;
            comboBoxDepart.SelectedItem = check.DepartmentCheck;
            comboBoxType.SelectedItem = check.SilverTypeCheck;
            comboBoxDecimal.SelectedItem = check.DecimalCheck;
            maskedTextBoxCover.Text = check.CoverageCheck.ToString();
            numericUpDownAmount.Value = Convert.ToDecimal(check.AmountCheck);
            textBoxOrder.Text = check.OrderCheck;

            editCheck = check;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new SilverREContext())
            {
                if (Text == "Редактирование чека")
                {
                    editCheck.NormCheck = textBoxNorm.Text;
                    editCheck.OrderCheck = textBoxOrder.Text;
                    editCheck.DecimalCheck = ((DecimalNumber)comboBoxDecimal.SelectedItem).IdDecimal;
                    editCheck.CoverageCheck = Convert.ToDecimal(maskedTextBoxCover.Text);
                    editCheck.SilverTypeCheck = ((SilverType)comboBoxType.SelectedItem).CodeSilverType;
                    editCheck.DepartmentCheck = Convert.ToInt32(comboBoxDepart.SelectedItem);
                    editCheck.AmountCheck = Convert.ToInt32(numericUpDownAmount.Value);

                    db.Check.Update(editCheck);
                    db.SaveChanges();

                    MessageBox.Show($"Успешное редактирование чека №{editCheck.IdCheck}");

                }
                else
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
