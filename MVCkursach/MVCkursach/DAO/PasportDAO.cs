using MVCkursach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCkursach.DAO
{
    public class PasportDAO
    {
        private PasportBaseEntities entities = new PasportBaseEntities();

        public IEnumerable<Pasports> getAllPasport()
        {
            return (from x in entities.Pasports select x);
        }

        public Pasports getPasport(int id)
        {
            return (from c in entities.Pasports where c.Id == id select c).FirstOrDefault();
        }

        public bool addDocument(Pasports pasport)
        {
            try
            {
                entities.Pasports.Add(pasport);
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