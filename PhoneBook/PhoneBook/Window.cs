using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PhoneBook
{
    public partial class Window : Form
    {
        private void textBox_name(object sender, EventArgs e)
        {

        }
        public Window()
        {
            InitializeComponent();
            updatelist();
        }
        private void updatelist() {
          //  this.Controls.Add(listBox1);
            Contacts x = new Contacts("contacts");
            listBox1.Items.Clear();
            listBox1.BeginUpdate();

            int length = x.GetLength();
            for (int i = 0; i < length; i++)
            {
                listBox1.Items.Add(i + 1 + " \t" + x.GetName(i) + "\t" + x.GetSurname(i) + "\t" + x.GetNumber(i));
            }

            listBox1.EndUpdate();
            listBox1.SetSelected(0, true);
        }
        private void button_exit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void button_newcontact(object sender, EventArgs e)
        {
            Contacts x = new Contacts("contacts");
            int error;

            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string number = textBoxNumber.Text;

            try
            {
               int.Parse(number);
                if (number.Length > 9 || number.Length < 1 || int.Parse(number) < 0)
                {
                    labelInfo.Text = "Sorry, incorrect number";
                }
                else
                {
                    if (name.Length != 0 && surname.Length != 0) {
                        Person newPerson = new Person(name, surname, int.Parse(number));
                        error = x.Add(newPerson);
                        if (error == 1)
                        {
                            labelInfo.Text = "Sorry, add a new contact failed";
                        }
                        else
                        {
                            labelInfo.Text = "Successfully added a new contact";
                            updatelist();
                        }
                    }
                }
            }
            catch 
            {
                if (name.Length == 0)
                {
                    labelInfo.Text = "Sorry, incorrect name";
                }else if (surname.Length == 0)
                {
                    labelInfo.Text = "Sorry, incorrect surname";
                }
                else
                {
                    labelInfo.Text = "Sorry, incorrect number";
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Window_Load(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Contacts x = new Contacts("contacts");
            int error;
            error = x.Delete(listBox1.SelectedIndex);
            if (error == 1)
            {
                labelInfo.Text = "Sorry, removing a contact failed";
            }
            else
            {
                labelInfo.Text = "Successfully removed a contact";
            }
            updatelist();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Contacts x = new Contacts("contacts");
            
                int i = x.Find(textBoxSearch.Text);
               
                listBox1.Items.Clear();
                listBox1.BeginUpdate();
                if (i >= 0)
                    listBox1.Items.Add(i + 1 + " \t" + x.GetName(i) + "\t" + x.GetSurname(i) + "\t" + x.GetNumber(i));

                listBox1.EndUpdate();
                if (i >= 0)
                     listBox1.SetSelected(0, true);
                
            if (textBoxSearch.TextLength == 0)
            {
                updatelist();
            }

        }
    }
}
