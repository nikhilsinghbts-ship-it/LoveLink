using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoveLink.Pages
{
    public class ShareModel : PageModel
    {
        public string ProposalLink { get; set; } = "";

        public void OnGet(string id)
        {
            ProposalLink = $"{Request.Scheme}://{Request.Host}/Proposal?id={id}";
        }
    }
}