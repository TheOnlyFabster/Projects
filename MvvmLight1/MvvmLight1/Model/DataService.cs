using System;
using System.Collections.Generic;

namespace MvvmLight1.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new DataItem("Welcome to MVVM Light");
            callback(item, null);
        }


        public void GetDTCList(Action<List<DTCItem>, Exception> callback)
        {
            throw new NotImplementedException();
        }
    }
}