using System;
using System.Collections.Generic;
using MvvmLight1.Model;

namespace MvvmLight1.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to create design time data

            var item = new DataItem("Welcome to MVVM Light [design]");
            callback(item, null);
        }

        public void GetDTCList(Action<List<DTCItem>, Exception> callback)
        {
            List<DTCItem> DTCItems = new List<DTCItem>();

            DTCItems.Add(new DTCItem
            {
                Expanded = true,
                Name = "First name",
                Source = "ECU",
                SubItems = new List<DTCSubItem>() { new DTCSubItem { Boost = "5", CoolantTemp = "40" } }
            });

            DTCItems.Add(new DTCItem
            {
                Expanded = true,
                Name = "Second name",
                Source = "ECU",
                SubItems = new List<DTCSubItem>() { new DTCSubItem { Boost = "3", CoolantTemp = "50" } }
            });

            DTCItems.Add(new DTCItem
            {
                Expanded = true,
                Name = "Third name",
                Source = "ECU",
                SubItems = new List<DTCSubItem>() { new DTCSubItem { Boost = "2", CoolantTemp = "60" } }
            });

            callback(DTCItems, null);
        }
    }
}