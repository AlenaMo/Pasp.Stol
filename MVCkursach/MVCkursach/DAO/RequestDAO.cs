using MVCkursach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCkursach.DAO
{
    public class RequestDAO
    {

        private PasportBaseEntities entities = new PasportBaseEntities();

        public IEnumerable<Requests> getAllRequest()
        {
            return (from c in entities.Requests where c.State.Equals("uncheck") select c);
        }


        public IEnumerable<Requests> getAllOrdersForUser(int id)
        {
            return (from c in entities.Requests where c.State.Equals("check") select c);
        }

        public bool addRequest(Requests request)
        {
            try
            {
                entities.Requests.Add(request);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

    }
}