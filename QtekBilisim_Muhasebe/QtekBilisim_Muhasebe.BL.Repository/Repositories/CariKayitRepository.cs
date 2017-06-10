using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Repository.Repositories
{
    public class CariKayitRepository : Repository<CariKayit>, ICariKayitRepository
    {
        public CariKayitRepository(QtekBilisim_MuhasebeContext _context) : base(_context)
        {
            if (_context == null) throw new ArgumentNullException();
        }
        public QtekBilisim_MuhasebeContext CariKayitContext
        {
            get
            {
                return RepositoryContext as QtekBilisim_MuhasebeContext;
            }
        }

        public string CariKodGetir()
        {
            var temp = CariKayitContext.Set<CariKayit>().FirstOrDefault();
            if (temp != null)
            {
                int id = CariKayitContext.Set<CariKayit>().Max(m => m.CariID);
                return "CR" + (id + 1).ToString("###");
            }
            else
            {
                return "CR001";
            }
        }
    }
}
