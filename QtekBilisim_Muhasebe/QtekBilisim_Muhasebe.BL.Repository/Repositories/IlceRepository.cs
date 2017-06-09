using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Repository.Repositories
{
    public class IlceRepository : Repository<Ilce>, IIlceRepository
    {
        public IlceRepository(QtekBilisim_MuhasebeContext _context) : base(_context)
        {
        }
        public QtekBilisim_MuhasebeContext IlceContext
        {
            get
            {
                return RepositoryContext as QtekBilisim_MuhasebeContext;
            }
        }
    }
}
