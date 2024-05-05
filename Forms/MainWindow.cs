using SilverRealtrue.ModelsAndContex;

namespace SilverRealtrue
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var db = new SilverREContext())
            {
                dataGridView1.DataSource = db.Check.ToList();


            }
            dataGridView1.Columns["DecimalCheckNavigation"].Visible = false;
            dataGridView1.Columns["SilverTypeCheckNavigation"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSilver addSilver = new AddSilver();
            addSilver.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search search = new Search();   
            search.ShowDialog();
        }
    }
}
