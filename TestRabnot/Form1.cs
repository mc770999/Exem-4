using TestRabnot.Model;
using TestRabnot.Service;
using static TestRabnot.Service.AllFunction;


namespace TestRabnot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateXmlIfNotExist();
        }

        private void button1_ClickAddDate(object sender, EventArgs e)
        {
            string Day = comboBox1.Text;
            string DayInMonth = comboBox2.Text;
            string Month = comboBox3.Text;
            string Year = comboBox4.Text;

            QueryModel querymodel = new QueryModel();
            querymodel.Month = Month;
            querymodel.Year = Year;
            querymodel.Day = Day;
            querymodel.DayInMonth = Convert.ToInt16(DayInMonth) ;
            MessageBox.Show(querymodel.Res);
            Addquery(ReadDocument(), querymodel);


        }
    }
}
