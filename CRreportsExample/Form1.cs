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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.database1DataSet.Inventory);

        }

        private void toolStripComboBox_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox_Material.Text=="All")
            {
                this.inventoryTableAdapter.Fill(this.database1DataSet.Inventory);
            }
            else
                this.inventoryTableAdapter.FillByName(this.database1DataSet.Inventory, toolStripComboBox_Material.Text);
        }

        private void toolStripButton_Report_Click(object sender, EventArgs e)
        {
            Report report = new Report(toolStripComboBox_Material.Text);
            report.Show();
        }
    }
}
