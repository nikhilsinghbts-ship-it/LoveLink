using System.Collections.Concurrent;
using LoveLink.Models;

namespace LoveLink.Services
{
    public class ProposalStore
    {
        private readonly ConcurrentDictionary<string, Proposal> _proposals = new();

        public void Add(Proposal proposal)
        {
            _proposals[proposal.UniqueCode] = proposal;
        }

        public Proposal? Get(string id)
        {
            _proposals.TryGetValue(id, out var proposal);
            return proposal;
        }
    }
}