using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildHaven
{
    public partial class TestForm : Form
    {
        int result;

        public TestForm()
        {
            InitializeComponent();

            result = InformationAnalysis.getResult();

            labelResult.Text = result.ToString();
            Application.DoEvents();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrazyWorld cw = new CrazyWorld();
            cw.ShowDialog();
        }

        
    }
}
