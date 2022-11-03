using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blue_Line.Model
{
    internal class RouteStation : TrainStation
    {
        public RouteStation()
        {
        }

        public RouteStation(string stationName, string stationCity, string stationRegion, string stationDepartment, int[] platform) : base(stationName, stationCity, stationRegion, stationDepartment, platform)
        {
        }
    }
}
