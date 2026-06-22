using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
namespace zeyadhotel.all_user_control
{
    public partial class log : Form
    {
        XDocument operation;
        public string url = @"C:\Users\aa077\source\repos\zeyadhotel\zeyadhotel\all user control\XMLog.xml";
        
        public log()
        {
            InitializeComponent();
            operation = XDocument.Load(url);
        }
        private void DataRefresh()
        {
            dynamic SelectedOp = operation.Descendants("operation").Select(
                p => new
                {
                    operation = p.Element("details").Value,
                    name = p.Element("employee_id").Value,
                    date = p.Element("date").Value
                }
                ).ToList();

            DataGridView1.DataSource = SelectedOp;

        }
        public void add_log(string name,string details)
        {

            XElement op = new XElement("operation",
                    new XElement("details", details),
                    new XElement("employee_id", name),
                    new XElement("date", System.DateTime.Now));
            operation.Root.Add(op);
            operation.Save(url);
            DataRefresh();

        }
        private void log_Load(object sender, EventArgs e)
        {
           
           
                DataRefresh(); 

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
