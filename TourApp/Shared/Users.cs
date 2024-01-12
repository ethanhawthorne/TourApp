using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace TourApp.Shared

{
    public class Users : IdentityUser
    {

        public string FullName { get; set; }
        public int PassPort { get; set; }
        public int Phone {  get; set; }
    }
}
