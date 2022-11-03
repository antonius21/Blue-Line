using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blue_Line.Model
{
    internal class TrainStation
    {
        private int _stationId;
        private string _stationName;
        private string _stationCity;
        private string _stationRegion;
        private string _stationDepartment;
        private int[] platform;

        public TrainStation()
        {

        }

        public TrainStation(string stationName, string stationCity, string stationRegion, string stationDepartment, int[] platform)
        {
            _stationName = stationName ?? throw new ArgumentNullException(nameof(stationName));
            _stationCity = stationCity ?? throw new ArgumentNullException(nameof(stationCity));
            _stationRegion = stationRegion ?? throw new ArgumentNullException(nameof(stationRegion));
            _stationDepartment = stationDepartment ?? throw new ArgumentNullException(nameof(stationDepartment));
            this.platform = platform ?? throw new ArgumentNullException(nameof(platform));
        }

        public void ChangingParametrs(string ParametrName, string Parametr)
        {
            if(ParametrName == "stationName")
            {
                ChangeStationName(Parametr);
            }else
            {
                if (ParametrName == "CityName")
                {
                    ChangeStationCityName(Parametr);
                }
                else
                {
                    ChangeStationDepartment(Parametr);
                }
            }
        }


        private void ChangeStationName(string NewName)
        {
            this._stationName = NewName;
        }

        private void ChangeStationCityName(string NewNameCity)
        {
            this._stationCity = NewNameCity;
        }
        private void ChangeStationDepartment(string NewDepartment)
        {
            this._stationDepartment = NewDepartment;
        }

    }
}
