using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRreportsExample
{
    public partial class Report : Form
    {
        string parameter;
        public Report(string parameter)
        {
            InitializeComponent();
            this.parameter = parameter;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            if (parameter == "All")
            {
                this.inventoryTableAdapter.Fill(this.database1DataSet.Inventory);
            }
            else
                this.inventoryTableAdapter.FillByName(this.database1DataSet.Inventory, parameter);

            CReport1.SetDataSource(database1DataSet);
            crystalReportViewer1.ReportSource = CReport1;
        }
    }
}
