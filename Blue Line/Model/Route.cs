using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blue_Line.Model
{
    internal class Route
    {
        private int _routeId;
        private string _name;
        private string _description;
        private RouteStation _stationDeparture;
        private RouteStation _stationArrival;
        private RouteStation[] stations;
        private DateTime _departureTime;
        private DateTime _ArravialTime;
        private int _regularityDays;

        public Route()
        {

        }
       
    }
}
