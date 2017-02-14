using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ODX_parser
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      ReadXML();
    }

    private void ReadXML()
    {
      string fileName = @"c:\users\fabster\documents\visual studio 2015\Projects\ODX parser\ODX parser\OdxFiles\ECU_v04_candela8_ODX201_engl.odx";
     // string fileName = @"C:\Users\Fabster\documents\visual studio 2015\Projects\ODX parser\ODX parser\OdxFiles\VCU1.odx";

      XDocument doc = XDocument.Load(fileName);
      XNamespace xsi = @"http://www.w3.org/2001/XMLSchema-instance";
      //All services
      var diagservicenodes = doc.Descendants().Where(d => d.Name == @"DIAG-SERVICE");

      //All requests
      var requests = doc.Descendants().Where(r => r.Name == @"REQUEST");

      foreach (var diagservice in diagservicenodes)
      {

        var servicelongname = diagservice.Descendants().Where(d => d.Name == "LONG-NAME").First().Value;
        var serviceshortname = diagservice.Descendants().Where(d => d.Name == "SHORT-NAME").First().Value;


        //find the request reference of the service
        var requestref =  diagservice.Descendants().Where(s => s.Name == "REQUEST-REF").FirstOrDefault();

        //get the requestid
        string requestrefid = requestref.Attribute("ID-REF").Value;

        //Go to the requestnode
        var requestnode = requests.Where(r => r.Attribute("ID").Value == requestrefid).FirstOrDefault();

        //Todo maybe there is another structure that leads to parameters also

        var test = requestnode.Descendants().Where(p => p.Name == @"PARAM").FirstOrDefault();
        

        //Get the TableKey parameter
       var tablekeyparam = requestnode.Descendants().Where(p => p.Name == "PARAM" && p.Attribute(xsi + "type").Value == "TABLE-KEY").FirstOrDefault();
        
        if (tablekeyparam != null)
        {
          var tablerowref = tablekeyparam.Descendants().Where(p => p.Name == "TABLE-ROW-REF").FirstOrDefault(); 

          if (tablerowref != null)
          {
            var tablekey = tablerowref.Attribute("ID-REF").Value;

            var tablerow = doc.Descendants().Where(r => r.Name == "TABLE-ROW" && r.Attribute("ID").Value == tablekey).FirstOrDefault();

            var structureref = tablerow.Descendants().Where(t => t.Name == "STRUCTURE-REF").FirstOrDefault();

            if (structureref != null)
            {
              string structureid = structureref.Attribute("ID-REF").Value;

              var structure = doc.Descendants().Where(r => r.Name == "STRUCTURE" && r.Attribute("ID").Value == structureid).FirstOrDefault();


              if (structure != null)
              {
                var parameters = structure.Descendants().Where(p => p.Name == "PARAM");

                foreach (var parameter in parameters)
                {

                  var paramlongname = parameter.Descendants().Where(d => d.Name == "LONG-NAME").First().Value;
                  var paramshortname = parameter.Descendants().Where(d => d.Name == "SHORT-NAME").First().Value;

                  string debug = string.Join("   ", servicelongname, paramlongname);

                  Debug.WriteLine(debug);

                  parameter.Descendants().Where(p => p.Name == "DOP-REF").FirstOrDefault();

                }

              }
            } 
          }
          

        }


      }


     // doc.Root.Elements

    }

  }
}
