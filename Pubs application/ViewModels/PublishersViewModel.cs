using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubs_application.ViewModels
{
    internal class PublishersViewModel : BaseViewModel
    {
        public PublishersViewModel()
        {
            columns = new Dictionary<string, string>();
            createColumns();
        }

        public override void createColumns()
        {
            columns.Add("ID", "pub_name");
            columns.Add("City of Origin", "city");
            columns.Add("State of Origin", "state");
            columns.Add("Country of Origin", "country");
        }
    }
}
