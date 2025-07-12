using Pubs_application.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubs_application.ViewModels
{
    public abstract class BaseViewModel
    {
        public pubsEntities db = new pubsEntities();
        public Dictionary<string, string> columns { get; set; }

        public abstract void createColumns();
    }
}
