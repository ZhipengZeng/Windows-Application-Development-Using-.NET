using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W2Lab_Zeng
{
    public partial class ChildGeneralPassportApplication : Form
    {
        public ChildGeneralPassportApplication()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picPhoto.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogbox = MessageBox.Show("Are you sure to Cancel?", "Just to Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogbox == DialogResult.Yes)
            {
                this.Close();
            }
            else
                txtSurname.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = String.Format("Surname: {0}\nGiven Name: {1}\nDate of Birth: {2}\nSex: {3}\nCity: {4}\nCountry: {5}\nProvince: {6}"
                , txtSurname.Text, txtGivenName.Text, dtpDateOfBirth.Value, (rdoFemale.Checked?"Female":"Male")
                ,txtCity.Text, txtCountry.Text, cboProvince.Text);
            DialogResult dialogbox1 = MessageBox.Show(message, "Information", MessageBoxButtons.OKCancel);
            if (dialogbox1 == DialogResult.OK)
            {
                DialogResult dialogbox2 = MessageBox.Show("Are you sure to Submit?", "Just to Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogbox2 == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                    txtSurname.Focus();
            }
            else
                txtSurname.Focus();
        }
    }
}
