using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using GameProjectDemo.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(gamer.NationalityId, gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year);
        }
    }
}
