using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LoveLink.Data;
using LoveLink.Models;

namespace LoveLink.Pages
{
    public class CreateModel : PageModel
    {
        private readonly LoveLinkDbContext _context;

        public CreateModel(LoveLinkDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string YourName { get; set; } = "";

        [BindProperty]
        public string RecipientName { get; set; } = "";

        [BindProperty]
        public string Title { get; set; } = "";

        [BindProperty]
        public string Letter { get; set; } = "";

        [BindProperty]
        public string Password { get; set; } = "";

        [BindProperty]
        public string Theme { get; set; } = "pink";

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string uniqueCode = Guid.NewGuid()
                .ToString("N")
                .Substring(0, 10)
                .ToUpper();

            var proposal = new Proposal
            {
                UniqueCode = uniqueCode,
                YourName = YourName,
                RecipientName = RecipientName,
                Title = Title,
                Letter = Letter,
                Password = Password,
                Theme = Theme,
                CreatedAt = DateTime.Now
            };

            _context.Proposals.Add(proposal);

            await _context.SaveChangesAsync();

            return RedirectToPage("/Share", new { id = uniqueCode });
        }
    }
}