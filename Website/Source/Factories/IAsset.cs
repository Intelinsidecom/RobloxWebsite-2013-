using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roblox.Assets
{
    public interface IAsset
    {
        int Id { get; }
        string Name { get; }
        string Description { get; }
        int CreatorId { get; }
        DateTime Created { get; }
        DateTime Updated { get; }
        bool IsPublic { get; }
    }
}
