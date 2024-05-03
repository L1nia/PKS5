using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PKS5;
using PKS5.Modules;

namespace PKS5.Pages
{
    public class LecturerModel : PageModel
    {
        private readonly Pks5Context _context;

        public LecturerModel(Pks5Context context)
        {
            _context = context;
        }

        public IActionResult Show()
        {
            var lecturer = _context.Lecturers.ToList();
            ViewData["Lecturer"] = lecturer;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string firstname, string middleName, string lastName, string subject, string department)
        {
            var lecturers = await _context.Lecturers
                .Where(l => l.Firstname == firstname && l.Middlename == middleName && l.Lastname == lastName && l.Subject == subject && l.Department == department)
                .ToListAsync();

            return new JsonResult(lecturers);
        }
    }
}

