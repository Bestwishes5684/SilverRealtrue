using Microsoft.EntityFrameworkCore;
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
        }

        public void InitDatagrid()
        {
            using (var db = new SilverREContext())
            {
                var show = db.Check.OrderBy(x => x.IdCheck).ToList();
                var result = from check in db.Check.Where(x => x.IdCheck.ToString().Contains(Search.searchRequest) || Search.searchRequest == null)
                             select new
                             {
                                 IdCheck = check.IdCheck,
                                 DateCheck = check.DateCheck,
                                 DepartmentCheck = check.DepartmentCheck,
                                 NormCheck = check.NormCheck,
                                 SilverTypeCheck = db.SilverType.FirstOrDefault(x => x.CodeSilverType == check.SilverTypeCheck).TitleSilverType,
                                 CoverageCheck = check.CoverageCheck,
                                 AmountCheck = check.AmountCheck,
                                 DecimalCheck = db.DecimalNumber.FirstOrDefault(x => x.IdDecimal == check.DecimalCheck).TitleDecimal,
                                 OrderCheck = check.OrderCheck,
                             };



                dataGridSilver.DataSource = result.ToList();

                dataGridSilver.Columns["IdCheck"].HeaderText = "����� ����";
                dataGridSilver.Columns["DateCheck"].HeaderText = "���� ����";
                dataGridSilver.Columns["DepartmentCheck"].HeaderText = "����� ����";
                dataGridSilver.Columns["NormCheck"].HeaderText = "����� �������";
                dataGridSilver.Columns["SilverTypeCheck"].HeaderText = "����� ����";
                dataGridSilver.Columns["CoverageCheck"].HeaderText = "������� ��������";
                dataGridSilver.Columns["AmountCheck"].HeaderText = "����������";
                dataGridSilver.Columns["DecimalCheck"].HeaderText = "����������� �����";
                dataGridSilver.Columns["OrderCheck"].HeaderText = "����� ������";






            }
            // dataGridSilver.Columns["DecimalCheckNavigation"].Visible = false;
            //dataGridSilver.Columns["SilverTypeCheckNavigation"].Visible = false;
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
    }
}
