﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
                comboBoxDepart.DataSource = db.Department.Where(x => x.IsAtWorkDepartment == true).ToList();
                comboBoxType.DataSource = db.SilverType.ToList();
                comboBoxDecimal.DataSource = db.DecimalNumber.ToList();

                comboBoxDepart.DisplayMember = nameof(Department.CodeDepartment);
                comboBoxType.DisplayMember = nameof(SilverType.TitleSilverType);
                comboBoxDecimal.DisplayMember = nameof(DecimalNumber.TitleDecimal);

            }
        }

        public AddSilver(Check check) : this()
        {
            buttonAdd.Text = "Редактировать";
            Text = "Редактирование чека";

            maskedTextBoxCover.Text = check.NormCheck.ToString();
            textBoxNumber.Text = check.NumberCheck;
            comboBoxDepart.SelectedItem = check.DepartmentCheck;
            comboBoxType.Text = check.SilverTypeCheck.ToString();
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
                    editCheck.NormCheck = Convert.ToDecimal(maskedTextBoxCover.Text);
                    editCheck.OrderCheck = textBoxOrder.Text;
                    editCheck.NumberCheck = textBoxNumber.Text;
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
                    int checkDecimal;

                    if (!db.DecimalNumber.Any(x => x.TitleDecimal.ToLower().Trim() == comboBoxDecimal.Text.ToLower().Trim()))
                    {
                        DecimalNumber newDecimal = new DecimalNumber
                        {
                            TitleDecimal = comboBoxDecimal.Text
                        };
                        db.DecimalNumber.Add(newDecimal);
                        db.SaveChanges();

                        checkDecimal = db.DecimalNumber.OrderBy(x => x.IdDecimal).Last().IdDecimal;
                    }
                    else
                    {
                        checkDecimal = ((DecimalNumber)comboBoxDecimal.SelectedItem).IdDecimal;
                    }

                    Check newCheck = new Check
                    {
                        DateCheck = dateTimePicker1.Value,
                        DepartmentCheck = Convert.ToInt32(comboBoxDepart.SelectedItem),
                        NumberCheck = textBoxNumber.Text,
                        NormCheck = Convert.ToDecimal(maskedTextBoxCover.Text),
                        SilverTypeCheck = ((SilverType)comboBoxType.SelectedItem).CodeSilverType,
                        CoverageCheck = Convert.ToDecimal(maskedTextBoxCover.Text),
                        AmountCheck = Convert.ToInt32(numericUpDownAmount.Value),
                        DecimalCheck = checkDecimal,
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void textBoxOrder_KeyDown(object sender, KeyEventArgs e)
        {
            char digit = Convert.ToChar(e.KeyCode);

            if (!Char.IsDigit(digit) || e.KeyCode == Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void maskedTextBoxNorm_KeyDown(object sender, KeyEventArgs e)
        {
            char digit = Convert.ToChar(e.KeyCode);

            if (!Char.IsDigit(digit) || e.KeyCode == Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxNumber_KeyDown(object sender, KeyEventArgs e)
        {
            char digit = Convert.ToChar(e.KeyCode);

            if (!Char.IsDigit(digit) || e.KeyCode == Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
