using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
    public class DataAccess
    {


        public List<Person> GetPeople(string lastName)
        {
         
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PeopleDB")))
            {
                //var output = connection.Query<Person>($"select * from People where LastName = '{ lastName }'").ToList();

               var output = connection.Query<Person>("dbo.GetByLastName @LastName", new { LastName = lastName } ).ToList();

                return  output;
            }
        }

        public List<Person> GetAllPeople()
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PeopleDB")))
            {
                //var output = connection.Query<Person>($"select * from People where LastName = '{ lastName }'").ToList();
                var output = connection.Query<Person>("dbo.GetAllPeople").ToList();

                return output;
            }
        }

        public int DeletePerson(int idToDelete)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PeopleDB")))
            {
              
                return connection.Execute("dbo.DeletePerson @id", new Person { id = idToDelete });
            }
        }

        public void InsertPerson(string firstname, string lastname, string email, string phone)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PeopleDB")))
            {
                //Person newPerson = new Person { FirstName = firstname, LastName = lastname, EmailAddress = email, PhoneNumber = phone };
                List<Person> people = new List<Person>();
                people.Add(new Person { FirstName = firstname, LastName = lastname, EmailAddress = email, PhoneNumber = phone });
                connection.Execute("dbo.InsertPerson @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);
            }
        }

    }
}
