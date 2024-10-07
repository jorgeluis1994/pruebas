using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace back_forms.src.Repositories.Imp
{
    public class Productos<dynamic> : IGenericRepository<dynamic>
    {
        public Task<ActionResult<IEnumerable<dynamic>>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}