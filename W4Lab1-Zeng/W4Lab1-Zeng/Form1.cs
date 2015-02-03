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
        List<PassportApplication> MyList = new List<PassportApplication>();

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
            string message = String.Format("Surname: {0}\nGiven Name: {1}\nDate of Birth: {2}\nSex: {3}\nCity: {4}\nCountry: {5}\nProvince: {6}\nReturn to me: {7}"
                , txtSurname.Text, txtGivenName.Text, dtpDateOfBirth.Text, (rdoFemale.Checked?"Female":"Male")
                ,txtCity.Text, txtCountry.Text, cboProvince.Text, (chkReturn.Checked?"True":"False"));
            DialogResult dialogbox1 = MessageBox.Show(message, "Information", MessageBoxButtons.OKCancel);
            if (dialogbox1 == DialogResult.OK)
            {
                DialogResult dialogbox2 = MessageBox.Show("Are you sure to Submit?", "Just to Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogbox2 == DialogResult.Yes)
                {
                    PassportApplication MyPassPort = new PassportApplication(txtSurname.Text, txtGivenName.Text, rdoFemale.Checked, dtpDateOfBirth.Text, txtCity.Text, txtCountry.Text, cboProvince.Text, chkReturn.Checked);
                    MyList.Add(MyPassPort);
                    ClearUI();
                }
                else
                    txtSurname.Focus();
            }
            else
                txtSurname.Focus();

            

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lstInformation.Items.Clear();
            foreach (var item in MyList)
            {
                lstInformation.Items.Add(item);
            }
        }

        public void ClearUI()
        {
            txtCity.Text = string.Empty;
            txtCountry.Text = "";
            dtpDateOfBirth.Text = null;
            cboProvince.Text = null;
            chkReturn.Checked = false;
            txtSurname.Text = null;
            txtGivenName.Text = null;
            rdoFemale.Checked = false;
            rdoMale.Checked = false;
        }

        private void lstInformation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstInformation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtSurname.Text = MyList[lstInformation.SelectedIndex].Surname;
            txtGivenName.Text = MyList[lstInformation.SelectedIndex].Givenname;
            dtpDateOfBirth.Text = MyList[lstInformation.SelectedIndex].DateOfBirth;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtSurname.Text == MyList[lstInformation.SelectedIndex].Surname &&
                txtGivenName.Text == MyList[lstInformation.SelectedIndex].Givenname &&
                dtpDateOfBirth.Text == MyList[lstInformation.SelectedIndex].DateOfBirth)
            {
                txtSurname.Text = null;
                txtGivenName.Text = null;
                dtpDateOfBirth.Text = null;
            }
            MyList.Remove(MyList[lstInformation.SelectedIndex]);
            lstInformation.Items.Remove(lstInformation.SelectedItem);
        }

        
    }
}
