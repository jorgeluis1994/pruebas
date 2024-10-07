using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_forms.src.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace back_forms.src.Services.Imp
{
    public class UserService<dynamic> : IGenericService<dynamic>
    {

        private readonly IGenericRepository<dynamic> _userService;
        public UserService(IGenericRepository<dynamic> userService){
            _userService = userService;
        }

        public Task<ActionResult<IEnumerable<dynamic>>> GetAll()
        {
            var data = _userService.GetAll();
            throw new NotImplementedException();
        }
    }

}