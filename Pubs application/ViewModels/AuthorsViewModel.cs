using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pubs_application.Database;

namespace Pubs_application.ViewModels
{
    internal class AuthorsViewModel : BaseViewModel
    {
        public AuthorsViewModel()
        {
            columns = new Dictionary<string, string>();
            createColumns();
        }

        public override void createColumns()
        {
            columns.Add("ID", "au_id");
            columns.Add("First Name", "au_lname");
            columns.Add("Last Name", "au_fname");
            columns.Add("Phone", "phone");
            columns.Add("Address", "address");
            columns.Add("City", "city");
            columns.Add("State", "state");
            columns.Add("Zip Code", "zip");
        }
    }
}
