using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PKS5.Modules;
using PKS5;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PKS5.Pages 
{ 
     class LoginModel : PageModel
    { 
        private readonly Pks5Context _context;

        public LoginModel(Pks5Context context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return Page();
        }

        public async Task<IActionResult> Login([Bind("Login,Password")] Student student)
        {
            if (!ModelState.IsValid) return BadRequest();

            var user = await _context.Students.FirstOrDefaultAsync(c => c.Login == student.Login && c.Password == student.Password);

            if (user == null)
            {
                return RedirectToAction("Login");
            }

            TempData["Login"] = student.Login;

            return RedirectToPage("Profile", new { id = user.Id });
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public bool StudentExists(long id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}
