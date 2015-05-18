using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Notebook1
{
    public partial class Form1 : Form
    {
        PeopleAdd_Form addPeople_Form;
        public Form1()
        {
            InitializeComponent();
            addPeople_Form = new PeopleAdd_Form(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addPeople_Form.ShowDialog() == DialogResult.OK)
            {
                CheckDateBirthday();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info frm = new Info();
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream mystr = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((mystr = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader myread = new StreamReader(mystr);
                    string[] str;
                    int num = 0;
                    try
                    {
                        string[] str1 = myread.ReadToEnd().Split('\n');
                        num = str1.Count();
                        dataGridView1.RowCount = num;
                        for (int i = 0; i < num; i++)
                        {
                            str = str1[i].Split('^');
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                try
                                {
                                    string data = str[j].Replace("[abv]", "^");
                                    dataGridView1.Rows[i].Cells[j].Value = data;
                                }
                                catch { }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myread.Close();
                        CheckDateBirthday();
                    }
                }
            }
        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void ClearSelect_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells != null)
                {
                    int ind = dataGridView1.SelectedCells[0].RowIndex;
                    dataGridView1.Rows.RemoveAt(ind);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter myWritet = new StreamWriter(myStream);
                    try
                    {
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        {
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                string data = dataGridView1.Rows[i].Cells[j].Value.ToString().Replace("^", "[abv]");
                                myWritet.Write(data + '^');
                            }
                            myWritet.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myWritet.Close();
                    }
                    myStream.Close();
                }
            }
        }

        private void Find_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(Find_textBox.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void splitContainer4_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sort_button_Click(object sender, EventArgs e)
        {
            switch (Sort_comboBox.Text)
            {
                case "Ф.И.О.":
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
                    break;
                case "Дата рождения":
                    dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
                    break;
                case "Адрес":
                    dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
                    break;
                case "Номер телефона":
                    dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
                    break;
                case "Место работы":
                    dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
                    break;
                case "Должность":
                    dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
                    break;
                case "Должность знакомых":
                    dataGridView1.Sort(dataGridView1.Columns[6], ListSortDirection.Ascending);
                    break;
                case "Характер знакомства":
                    dataGridView1.Sort(dataGridView1.Columns[7], ListSortDirection.Ascending);
                    break;
                case "Деловые качества":
                    dataGridView1.Sort(dataGridView1.Columns[8], ListSortDirection.Ascending);
                    break;
                case "Дата последней корректировки":
                    dataGridView1.Sort(dataGridView1.Columns[9], ListSortDirection.Ascending);
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void AddValuesToDatagrid(People _people)
        {
            People people = _people;
            int index = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows.Add();
            dataGridView1[0, index].Value = people.name;
            dataGridView1[1, index].Value = people.dataOfBirth;
            dataGridView1[2, index].Value = people.address;
            dataGridView1[3, index].Value = people.telphoneNumber;
            dataGridView1[4, index].Value = people.work;
            dataGridView1[5, index].Value = people.post;
            dataGridView1[6, index].Value = people.friendsPost;
            dataGridView1[7, index].Value = people.meeting;
            dataGridView1[8, index].Value = people.qualities;
            dataGridView1[9, index].Value = people.dt;
            dataGridView1.Update();
        }

        public void CheckDateBirthday()
        {
            DateTime dt = DateTime.Today;
            bool check = false;
            DateTime dateBirth;
            StringBuilder resString = new StringBuilder();
            int count = dataGridView1.Rows.Count;
            int countBirth = 0;
            string[] nameBirth = new string[10];
            resString.Append("Сегодня день рождения отмечают: \r\n");
            try
            {
                for (int i = 0; i < count - 1; i++)
                {
                    string data = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    dateBirth = DateTime.Parse(data);
                    if (dateBirth.Month == dt.Month && dateBirth.Day == dt.Day)
                    {
                        resString.Append(dataGridView1.Rows[i].Cells[0].Value.ToString() + "\r\n");
                        check = true;
                        nameBirth[countBirth] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        countBirth++;
                    }
                }
                if (check)
                {
                    BirthForm birthForm = new BirthForm(resString);
                    if (birthForm.ShowDialog() == DialogResult.OK)
                    {
                        SendBirthMes(countBirth, nameBirth);   
                        MessageBox.Show("Поздравления отправлены!");
                    }
                    else
                    {
                        MessageBox.Show("Поздравления отправлены не были!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SendBirthMes(int countBirth, string[] nameBirth)
        {
            for (int j = 0; j < countBirth; j++)
            {
                string text = "Дорогой " + nameBirth[j] + ", позравляю вас с Днём рождения!!!";
                string file = @"C:\1\" + nameBirth[j] + ".txt";
                System.IO.File.WriteAllText(file, text);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть программу?", "Вопрос",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else { e.Cancel = true; }
        }
    }
}