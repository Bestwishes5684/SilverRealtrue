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
    public partial class NormForm : Form
    {
        public NormForm()
        {
            InitializeComponent();

            initDatagridNorm();
        }

        private void initDatagridNorm()
        {
            using (var db = new SilverREContext())
            {

                var result = from norm in db.Norm.ToList()

                             select new
                             {
                                 IdNorm = norm.IdNorm,
                                 TitleNorm = norm.TitleNorm,
                                 SilverTypeNorm = db.SilverType.FirstOrDefault(x => x.CodeSilverType == norm.SilverTypeNorm).TitleSilverType,
                                 DecimalNorm = db.DecimalNumber.FirstOrDefault(x => x.IdDecimal == norm.DecimalNorm).TitleDecimal,
                                 DepartmentNorm = db.Department.FirstOrDefault(x => x.CodeDepartment == norm.DepartmentNorm).CodeDepartment,

                             };



                if (result.Any())
                {
                    dataGridViewNorm.DataSource = result.ToList();
                }

                else
                {
                    MessageBox.Show("Не найдено ни одной записи");
                }



                  dataGridViewNorm.Columns["IdNorm"].HeaderText = "Идентификатор нормы";
                   dataGridViewNorm.Columns["TitleNorm"].HeaderText = "Норма";
                 dataGridViewNorm.Columns["SilverTypeNorm"].HeaderText = "Тип серебра";
                   dataGridViewNorm.Columns["DecimalNorm"].HeaderText = "Децимальный номер";
                   dataGridViewNorm.Columns["DepartmentNorm"].HeaderText = "Цех";


            }
        }

        private void buttonADDNorm_Click(object sender, EventArgs e)
        {
            AddNorm addNorm = new AddNorm();

            addNorm.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            using (var db = new SilverREContext())
            {
                var selected = Convert.ToInt32(dataGridViewNorm.Rows[dataGridViewNorm.SelectedRows[0].Index].Cells[0].Value);
                var editNorm = db.Norm.FirstOrDefault(x => x.IdNorm == selected);

                if (editNorm != null)
                {
                    var editForm = new AddNorm(editNorm);
                    editForm.ShowDialog();
                    if (editForm.DialogResult == DialogResult.OK)
                    {
                        initDatagridNorm();
                    }
                }
                else MessageBox.Show("Выберите норму для редактирования");
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            using (var db = new SilverREContext())
            {
                var selected = Convert.ToInt32(dataGridViewNorm.Rows[dataGridViewNorm.SelectedRows[0].Index].Cells[0].Value);

                var deleteNorm = db.Norm.FirstOrDefault(x => x.IdNorm == selected);
                      
                if (deleteNorm != null)
                {
                    DialogResult confirm;

                   
                  confirm = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Внимание!", MessageBoxButtons.OKCancel);
                  

                    if (confirm == DialogResult.OK)
                    {
                        db.Norm.Remove(deleteNorm);
                        db.SaveChanges();

                        initDatagridNorm();
                    }
                }
                else MessageBox.Show("Выберите запись для удаления");

            }
        }
    }
}
