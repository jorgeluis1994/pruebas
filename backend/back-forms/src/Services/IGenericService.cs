using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace back_forms.src.Services
{
    public interface IGenericService<T>
    {
       Task<ActionResult<IEnumerable<T>>>  GetAll();
        
    }
}