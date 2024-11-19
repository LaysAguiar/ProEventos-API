using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.API.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventAdress { get; set; }
        public string EventDate { get; set; }
        public string EventTheme { get; set; }
        public int QuantityPeople { get; set; }
        public string EventLote { get; set; }
        public string ImageURL { get; set; }    

    }
}