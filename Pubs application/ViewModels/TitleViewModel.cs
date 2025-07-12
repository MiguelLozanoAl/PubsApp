using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubs_application.ViewModels
{
    internal class TitleViewModel : BaseViewModel
    {
        public TitleViewModel()
        {
            columns = new Dictionary<string, string>();
            createColumns();
        }

        public override void createColumns()
        {
            columns.Add("ID", "title_id");
            columns.Add("Title", "title1");
            columns.Add("Type", "type");
            columns.Add("Publisher ID", "pub_id");
            columns.Add("Price", "price");
            columns.Add("Date of Publication", "pubdate");
        }
    }
}
