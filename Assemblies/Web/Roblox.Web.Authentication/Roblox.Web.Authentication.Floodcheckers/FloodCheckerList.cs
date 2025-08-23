using System.Collections.Generic;
using Roblox.FloodCheckers.Core;

namespace Roblox.FloodCheckers
{
    // Composite flood checker that aggregates multiple checkers
    public class FloodCheckerList : List<IFloodChecker>, IFloodChecker
    {
        public bool IsFlooded()
        {
            foreach (var checker in this)
            {
                if (checker != null && checker.IsFlooded())
                {
                    return true;
                }
            }
            return false;
        }

        public void UpdateCount()
        {
            foreach (var checker in this)
            {
                checker?.UpdateCount();
            }
        }

        public void Reset()
        {
            foreach (var checker in this)
            {
                checker?.Reset();
            }
        }

        public IFloodCheckerStatus Check()
        {
            // Return the first non-null status that indicates flooded; otherwise return last status
            IFloodCheckerStatus last = null;
            foreach (var checker in this)
            {
                var status = checker?.Check();
                if (status != null)
                {
                    last = status;
                    if (status.IsFlooded)
                    {
                        return status;
                    }
                }
            }
            return last;
        }

        public int GetCount()
        {
            int total = 0;
            foreach (var checker in this)
            {
                if (checker != null)
                {
                    total += checker.GetCount();
                }
            }
            return total;
        }

        public int GetCountOverLimit()
        {
            int over = 0;
            foreach (var checker in this)
            {
                if (checker != null)
                {
                    over += checker.GetCountOverLimit();
                }
            }
            return over;
        }
    }
}
