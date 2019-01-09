using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MahekarusProfile.Models.Apps
{
    public class App
    {
        public string Title { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public string GitHubLink { get; set; }
        public string DALText { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
    }
}