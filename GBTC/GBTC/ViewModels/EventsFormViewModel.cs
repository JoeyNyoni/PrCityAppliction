using GBTC.Models;
using System.Collections.Generic;

namespace GBTC.ViewModels
{
    public class EventsFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Type { get; set; }
        public IEnumerable<Type> Types { get; set; }
    }
}