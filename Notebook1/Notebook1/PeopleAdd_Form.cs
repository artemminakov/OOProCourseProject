using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook1
{
    public partial class PeopleAdd_Form : Form
    {
        private Form1 mainForm;
        public PeopleAdd_Form(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void OK_btn_Click(object sender, EventArgs e)
        {  
            bool validation = false;
            var error =  ErrorBox_label;
            string name = Name_textBox.Text;
            DateTime dataOfBirth = DateTime.Parse(DataOfBirth_textBox.Text);
            string address = Address_textBox.Text;
            string telphoneNumber = TelephoneNumber_textBox.Text;
            string work = Work_textBox.Text;
            string post = Post_textBox.Text;
            string friendsPost = FriendsPost_textBox.Text;
            string meeting = Meeting_textBox.Text;
            string qualities = Qualities_textBox.Text;

            if (string.IsNullOrEmpty(name))
            {
               error.Text = "Не заполнено поле имени ! \n";
               validation = false;
            }
            else if (string.IsNullOrEmpty(dataOfBirth.ToString()))
            {
                error.Text = "Не заполнено поле даты рождения! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(address))
            {
                error.Text = "Не заполнено поле адреса! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(telphoneNumber))
            {
                error.Text = "Не заполнено поле телефонного номера! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(work))
            {
                error.Text = "Не заполнено поле места работы/учебы! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(post))
            {
                error.Text = "Не заполнено поле должность! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(friendsPost))
            {
                error.Text = "Не заполнено поле должность знакомых! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(meeting))
            {
                error.Text = "Не заполнено поле характер знакомства! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(qualities))
            {
                error.Text = "Не заполнено поле деловые качества! \n";
                validation = false;
            }
            else
            {
                validation = true;
            }

            if (validation)
            {
                this.DialogResult = DialogResult.OK;
                var people = new People(name, dataOfBirth, address, telphoneNumber, work, post, 
                    friendsPost, meeting, qualities);
                mainForm.AddValuesToDatagrid(people);
                foreach (var item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        var x = item as TextBox;
                        x.Text = "";
                    }
                }
            }
        }

        private void Cansel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TeoneNumber_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PeopleAdd_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
