using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TunngleSharp.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TunngleWebClient web = new TunngleWebClient();
            web.Refresh();
            foreach (ExportNetwork network in web.Export.Network)
            {
                Console.WriteLine("{0}: {1}. {2}/{3} users.",
                    network.Category.Trim(), network.NetworkName.Trim(), network.UserCount.Trim(), network.UserMax.Trim());
            }
        }
    }
}
