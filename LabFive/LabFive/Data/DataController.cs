using System;
using System.Collections.Generic;

namespace LabFive
{
    [Serializable]
    static class DataController
    {
        //data
        public static List<Data> _dataToShow;
        private static List<Data> _data;

        //constructors
        static DataController()
        {
            _data = new List<Data>();
            _dataToShow = new List<Data>();
        }
    }
}
