using System;
using System.Collections.Generic;
using System.ServiceModel;
using ServiceRest_085_IfanRizky;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerConfigRest_085_IfanRizky
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObjek = null;

            try
            {
                hostObjek = new ServiceHost(typeof(TI_UMY));
                hostObjek.Open();
                Console.WriteLine("Server Ready");
                Console.ReadLine();
                hostObjek.Close();
            }

            catch (Exception ex)
            {
                hostObjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
