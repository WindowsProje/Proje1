using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Repository.Repositories
{
    public class HataKayitRepository : Repository<HataKayit>, IHataKayitRepository
    {
        public HataKayitRepository(QtekBilisim_MuhasebeContext _context) : base(_context)
        {
            if (_context == null) throw new ArgumentNullException();
        }
        public QtekBilisim_MuhasebeContext HataKayitContext
        {
            get
            {
                return RepositoryContext as QtekBilisim_MuhasebeContext;
            }
        }

        public async Task<int> EnBuyukHataKayitIDAsync()
        {
            return await HataKayitContext.HataKayit.MaxAsync(c => c.HataKayitID);
        }
    }
}
