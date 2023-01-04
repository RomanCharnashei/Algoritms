using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Hierarchical
{
    public class MakeHierarchical : IAlgo
    {
        public void DoIt()
        {
            IEnumerable<OrgChart> chart = new List<OrgChart>();

            var orgDictionary = chart.ToDictionary(x => x.Id);

            var root = new OrgChart { Name = "No organizations" };

            foreach (var org in orgDictionary.Values)
            {
                if (org.ParentId.HasValue)
                {
                    if (orgDictionary.TryGetValue(org.ParentId.Value, out OrgChart parent))
                    {
                        parent.Childs.Add(org);
                    }
                }
                else
                {
                    root = org;
                }
            }

            Console.WriteLine($"Result: {root}");
        }
    }
}
