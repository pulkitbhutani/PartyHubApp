using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PartyHub.Models;

namespace PartyHub.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Party> UpcomingParties { get; set; }
    }
}