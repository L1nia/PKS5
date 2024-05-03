using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PKS5.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly Pks5Context _context;

        public ProfileModel(Pks5Context context)
        {
            _context = context;
        }

    }
}
