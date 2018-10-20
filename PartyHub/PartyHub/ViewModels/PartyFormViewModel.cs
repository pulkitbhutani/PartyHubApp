using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyHub.ViewModels
{
    public class PartyFormViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Venue { get; set; }
    }
}