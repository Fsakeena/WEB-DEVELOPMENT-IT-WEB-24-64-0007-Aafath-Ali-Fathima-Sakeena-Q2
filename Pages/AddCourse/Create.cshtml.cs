using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Data;

namespace WebApplication2.Pages.AddCourse
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication2Context _context;

        public CreateModel(WebApplication2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public course Course { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            // Validate ModelState
            if (!ModelState.IsValid || _context.course == null || Course == null)
            {
                return Page();
            }

            // Add new course without setting CourseId manually
            _context.course.Add(Course);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
