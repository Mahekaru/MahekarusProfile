using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.CRUD
{
    public class GamesData
    {
        public int ID { get; set; }
        public string GameName { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}