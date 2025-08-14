using System;
using System.Linq;
using System.Collections.Generic;
using Roblox.Data;
using Roblox.Caching;
using Roblox.Caching.Interfaces;

using Microsoft.EntityFrameworkCore;


namespace Roblox.EntityFrameworkCore.Factories
{
    public abstract class RobloxDtoFactoryBase<TDto, TIndex, TDatabase>
        where TDto : Roblox.EntityFrameworkCore.RobloxDto<TDto, TIndex>, new()
        where TIndex : struct, IEquatable<TIndex>
        where TDatabase : Roblox.Data.GlobalDatabase<TDatabase>, new()
    {
        // This is a base class for DTO factories
        // Implementation would go here
    }
}
