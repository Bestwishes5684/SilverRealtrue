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

            }
        }
    }
}
