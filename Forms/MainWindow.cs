using Microsoft.EntityFrameworkCore;
using SilverRealtrue.Forms;
using SilverRealtrue.ModelsAndContex;
using System.Windows.Forms;

namespace SilverRealtrue
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            InitDatagrid();

            checkBoxDelete.Checked = true;
        }

        public void InitDatagrid()
        {
            using (var db = new SilverREContext())
            {
                //var show = db.Check.OrderBy(x => x.IdCheck).ToList();
                var result = from check in db.Check
                             .Where(x => x.NumberCheck.Contains(Search.searchRequest)
                                || x.DecimalCheckNavigation.TitleDecimal.Contains(Search.searchRequest)
                                || Search.searchRequest == null)
                             select new
                             {
                                 IdCheck = check.IdCheck,
                                 NumberCheck = check.NumberCheck,
                                 DateCheck = check.DateCheck,
                                 DepartmentCheck = check.DepartmentCheck,
                                 NormCheck = check.NormCheck,
                                 SilverTypeCheck = db.SilverType.FirstOrDefault(x => x.CodeSilverType == check.SilverTypeCheck).TitleSilverType,
                                 CoverageCheck = check.CoverageCheck,
                                 AmountCheck = check.AmountCheck,
                                 DecimalCheck = db.DecimalNumber.FirstOrDefault(x => x.IdDecimal == check.DecimalCheck).TitleDecimal,
                                 OrderCheck = check.OrderCheck,
                             };



                if (result.Any())
                {
                    dataGridSilver.DataSource = result.ToList();
                }

                else
                {
                    MessageBox.Show("Не найдено ни одной записи");
                }

                dataGridSilver.Columns["IdCheck"].HeaderText = "Идентификатор чека";
                dataGridSilver.Columns["NumberCheck"].HeaderText = "Номер чека";
                dataGridSilver.Columns["DateCheck"].HeaderText = "Дата чека";
                dataGridSilver.Columns["DepartmentCheck"].HeaderText = "Номер цеха";
                dataGridSilver.Columns["NormCheck"].HeaderText = "Норма серебра";
                dataGridSilver.Columns["SilverTypeCheck"].HeaderText = "Вид серебра";
                dataGridSilver.Columns["CoverageCheck"].HeaderText = "Площадь покрытия";
                dataGridSilver.Columns["AmountCheck"].HeaderText = "Количество";
                dataGridSilver.Columns["DecimalCheck"].HeaderText = "Децимальный номер";
                dataGridSilver.Columns["OrderCheck"].HeaderText = "Номер заказа";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSilver addSilver = new AddSilver();

            if (addSilver.ShowDialog() == DialogResult.OK)
            {
                InitDatagrid();
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            if (search.ShowDialog() == DialogResult.OK)
            {
                InitDatagrid();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Search.searchRequest = null;

            InitDatagrid();
        }

        private void buttonIncorrect_Click(object sender, EventArgs e)
        {
            using (var db = new SilverREContext())
            {
                var checks = db.Check.OrderBy(x => x.IdCheck).ToList();

                foreach (DataGridViewRow row in dataGridSilver.Rows)
                {
                    var correctNorm = db.Norm.FirstOrDefault(x => x.DecimalNormNavigation.TitleDecimal == row.Cells[8].Value.ToString());

                    if (correctNorm != null)
                        if (correctNorm.TitleNorm.ToString() != row.Cells[4].Value.ToString()
                            || correctNorm.SilverTypeNorm.ToString() != row.Cells[5].Value.ToString()) // Тут надо позор с ToString как то переделать
                            dataGridSilver.Rows[row.Index].DefaultCellStyle.BackColor = Color.IndianRed; // P.S. Decimal.Compare не работает, потому что nullable в моделях
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            using (var db = new SilverREContext())
            {
                var selected = Convert.ToInt32(dataGridSilver.Rows[dataGridSilver.SelectedRows[0].Index].Cells[0].Value);
                var editCheck = db.Check.FirstOrDefault(x => x.IdCheck == selected);

                if (editCheck != null)
                {
                    var editForm = new AddSilver(editCheck);
                    editForm.ShowDialog();
                    if (editForm.DialogResult == DialogResult.OK)
                    {
                        InitDatagrid();
                    }
                }
                else MessageBox.Show("Выберите чек для редактирования");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (var db = new SilverREContext())
            {
                var selected = Convert.ToInt32(dataGridSilver.Rows[dataGridSilver.SelectedRows[0].Index].Cells[0].Value);

                var deleteCheck = db.Check.FirstOrDefault(x => x.IdCheck == selected);

                if (deleteCheck != null)
                {
                    DialogResult confirm;

                    if (checkBoxDelete.Checked == true)
                        confirm = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Внимание!", MessageBoxButtons.OKCancel);
                    else confirm = DialogResult.OK;

                    if (confirm == DialogResult.OK)
                    {
                        db.Check.Remove(deleteCheck);
                        db.SaveChanges();

                        InitDatagrid();
                    }
                }
                else MessageBox.Show("Выберите запись для удаления");

            }
        }

        private void checkBoxDelete_CheckedChanged(object sender, EventArgs e)
        {
            // Вообще было бы чётенько всю чепуху с удалением перенести в ContextMenu
        }

        private void buttonNormTB_Click(object sender, EventArgs e)
        {
            NormForm normForm = new NormForm();
            normForm.ShowDialog();
        }

        private void buttonDecimalDict_Click(object sender, EventArgs e)
        {
            DecimalDictForm decForm = new DecimalDictForm();
            decForm.ShowDialog();
        }
    }
}
