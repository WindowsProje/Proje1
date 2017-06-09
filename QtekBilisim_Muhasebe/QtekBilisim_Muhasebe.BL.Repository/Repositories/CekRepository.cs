﻿using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Repository.Repositories
{
    public class CekRepository : Repository<Cek>, ICekRepository
    {
        public CekRepository(QtekBilisim_MuhasebeContext _context) : base(_context)
        {
            if (_context == null) throw new ArgumentNullException();
        }
        public QtekBilisim_MuhasebeContext CekContext
        {
            get
            {
                return RepositoryContext as QtekBilisim_MuhasebeContext;
            }
        }
    }
}