using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        DataAccess db = new DataAccess();
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();
            refreshPeopleFoundBox();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            people = db.GetPeople(LastNameText.Text);
            refreshPeopleFoundBox();
            
        }


        private void refreshPeopleFoundBox()
        {
            
            PeopleFoundListBox.DataSource = people;
            PeopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void GetAll_Click(object sender, EventArgs e)
        {
            LastNameText.Clear();
            people = db.GetAllPeople();
            refreshPeopleFoundBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            db.InsertPerson(FNameEntry.Text, LNameEntry.Text, EmailEntry.Text, PhoneEntry.Text);

            FNameEntry.Text = "";
            LNameEntry.Text = "";
            EmailEntry.Text = "";
            PhoneEntry.Text = "";
            refreshPeopleFoundBox();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int count = PeopleFoundListBox.Items.Count;
            List<Person> peopleList = new List<Person>();
            if(count > 0)
            {
                peopleList = PeopleFoundListBox.SelectedItems.Cast<Person>().ToList();
                Person person = peopleList[0];
                int deletedRows = db.DeletePerson(person.id);
            }
            refreshPeopleFoundBox();
        }
    }
}
