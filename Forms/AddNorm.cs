﻿using SilverRealtrue.ModelsAndContex;
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
    public partial class AddNorm : Form
    {
        private Norm editNorm;
        public AddNorm()
        {
            InitializeComponent();

            using (var db = new SilverREContext())
            {
                comboBoxDecimalNorm.DataSource = db.DecimalNumber.ToList();
                comboBoxDepartamentNorm.DataSource = db.Department.Where(x => x.IsAtWorkDepartment == true).ToList();
                comboBoxSilverNorm.DataSource = db.SilverType.ToList();

                comboBoxDecimalNorm.DisplayMember = nameof(DecimalNumber.TitleDecimal);
                comboBoxDepartamentNorm.DisplayMember = nameof(Department.CodeDepartment);
                comboBoxSilverNorm.DisplayMember = nameof(SilverType.TitleSilverType);


            }


        }


        public AddNorm(Norm norm) : this()
        {
            ADDbutton.Text = "Редактировать";
            Text = "Редактирование нормы";

            maskedTextBoxTitle.Text = norm.TitleNorm.ToString();
            comboBoxDecimalNorm.SelectedItem=norm.DecimalNorm;
            comboBoxDepartamentNorm.SelectedItem = norm.DepartmentNorm;
            comboBoxSilverNorm.SelectedItem = norm.SilverTypeNorm;

            editNorm = norm;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            using (var db = new SilverREContext())
            {

                if (Text == "Редактирование нормы")
                {
                    editNorm.TitleNorm = Convert.ToDecimal(maskedTextBoxTitle.Text);
                    editNorm.SilverTypeNorm = ((SilverType)comboBoxSilverNorm.SelectedItem).CodeSilverType;
                    editNorm.DecimalNorm = ((DecimalNumber)comboBoxDecimalNorm.SelectedItem).IdDecimal;
                    editNorm.DepartmentNorm = ((Department)comboBoxDepartamentNorm.SelectedItem).CodeDepartment;
                   

                    db.Norm.Update(editNorm);
                    db.SaveChanges();

                    MessageBox.Show($"Успешное редактирование номы №{editNorm.IdNorm}");

                }
                else
                {
                    Norm norm = new Norm
                    {
                        DecimalNorm = ((DecimalNumber)comboBoxDecimalNorm.SelectedItem).IdDecimal,
                        SilverTypeNorm = ((SilverType)comboBoxSilverNorm.SelectedItem).CodeSilverType,
                        TitleNorm = Convert.ToDecimal(maskedTextBoxTitle.Text),
                        DepartmentNorm = ((Department)comboBoxDepartamentNorm.SelectedItem).CodeDepartment





                    };


                    db.Norm.Add(norm);
                    db.SaveChanges();

                    MessageBox.Show("Успешное добавление");
                    this.Close();
                }







             

            }


        }
    }
}
