//Zhipeng Zeng
//LAB-03
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class frmTempConvert : Form
    {
        public frmTempConvert()
        {
            InitializeComponent();
        }

        //here is Convert Button Click Event
        private void btnConvert_Click(object sender, EventArgs e)
        {
            double dblCTemp = Convert.ToDouble(txtCelsius.Text);

            double dblFTemp = (9.0 / 5.0) * dblCTemp + 32.0;

            txtFahrenheit.Text = dblFTemp.ToString();
        }

        //here is Exit Button Click Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
//End namespace
//End class