using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ODX_parser
{
  public class ODXReader
  {
    private XNamespace _xsi = @"http://www.w3.org/2001/XMLSchema-instance";

    public ODXReader(XDocument odx)
    {


    }

    public IEnumerable<XElement> ReadAllDiagServices(XDocument odx)
    {
      return odx.Descendants().Where(d => d.Name == @"DIAG-SERVICE");
    }

    private Tuple<string, string> 
  }
}
