using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;

namespace Roblox.Data
{
    public abstract class RobloxDtoFactoryBase<TDto, TIndex, TDatabase>
        where TDto : RobloxDto<TDto, TIndex>, new()
        where TIndex : struct, IEquatable<TIndex>
        where TDatabase : GlobalDatabase<TDatabase>, new()
    {
        // This is a base class for DTO factories
        // Implementation would go here
    }

    // Base DTO class that would be referenced
    public abstract class RobloxDto<TDto, TIndex>
        where TDto : RobloxDto<TDto, TIndex>, new()
        where TIndex : struct, IEquatable<TIndex>
    {
        public TIndex ID { get; set; }
    }
}
