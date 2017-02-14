using System;
using MvvmLight2.Model;
using System.Collections.Generic;

namespace MvvmLight2.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to create design time data

            var item = new DataItem("Welcome to MVVM Light [design]");
            callback(item, null);

    
        }

      public void GetDataList(Action<List<DataItem>, Exception> callback)
      {
          List<DataItem> result = new List<DataItem>();
      result.Add(new DataItem() { xCu = "ECU", serviceName = "Service1", Unit = "mVA", Title = "ParameterA" });
      result.Add(new DataItem() { xCu = "ECU", serviceName = "Service1", Unit = "mVA", Title = "ParameterB" });
      result.Add(new DataItem() { xCu = "ACU", serviceName = "Service2", Unit = "psi", Title = "ParameterC" });
      result.Add(new DataItem() { xCu = "ACU", serviceName = "Service2", Unit = "psi", Title = "ParameterD" });
      result.Add(new DataItem() { xCu = "ERU", serviceName = "Service3", Unit = "C", Title = "ParameterE" });
    }
    }
}