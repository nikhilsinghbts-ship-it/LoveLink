using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LoveLink.Data;
using LoveLink.Models;

namespace LoveLink.Pages
{
    public class ProposalModel : PageModel
    {
        private readonly LoveLinkDbContext _context;

        public Proposal? Proposal { get; set; }

        public ProposalModel(LoveLinkDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                Proposal = null;
                return;
            }

            Proposal = await _context.Proposals
                .FirstOrDefaultAsync(p => p.UniqueCode == id);
        }
    }
}