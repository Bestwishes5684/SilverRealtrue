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
                dataGridViewNorm.DataSource = db.Norm.ToList();


                dataGridViewNorm.Columns["IdNorm"].HeaderText = "Идентификатор нормы";
                dataGridViewNorm.Columns["DecimalNorm"].HeaderText = "Децимальный номер";
                dataGridViewNorm.Columns["SilverTypeNorm"].HeaderText = "Тип серебра";
                dataGridViewNorm.Columns["TitleNorm"].HeaderText = "Title_Norm";
                dataGridViewNorm.Columns["DepartmentNorm"].HeaderText = "Department_Norm";


            }
        }

        private void buttonADDNorm_Click(object sender, EventArgs e)
        {
            AddNorm addNorm = new AddNorm();    
            
            addNorm.ShowDialog();
        }
    }
}
