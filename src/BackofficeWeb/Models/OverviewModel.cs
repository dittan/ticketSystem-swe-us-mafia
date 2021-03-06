﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystemEngine;

namespace BackofficeWeb.Models
{
    public class OverviewModel
    {
        public List<Venue> venues = new List<Venue>();
        public List<TicketEvent> events = new List<TicketEvent>();
        public List<TicketEventDate> dates = new List<TicketEventDate>();
    }
}
