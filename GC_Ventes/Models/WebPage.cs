using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class WebPage
    {
        public WebPage()
        {
            WebDroitUsers = new HashSet<WebDroitUser>();
        }

        public int Id { get; set; }
        public string Page { get; set; }

        public virtual ICollection<WebDroitUser> WebDroitUsers { get; set; }
    }
}
