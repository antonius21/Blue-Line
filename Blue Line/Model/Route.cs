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
        private Station _stationDeparture;
        private Station _stationArrival;
        private Station[] stations;
        private DateTime _departureTime;
        private DateTime _ArravialTime;
        private DateTime _routeTime;

        public Route()
        {
        }
    }
}
