using MVCkursach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCkursach.DAO
{
    public class VidDAO
    {
        PasportBaseEntities  entities = new PasportBaseEntities();

        public IEnumerable<VidDocs> getAllDoc()
        {
            return (from c in entities.VidDocs select c);
        }
    }
}