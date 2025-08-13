using System;
using Roblox.Databases;

namespace Roblox.EntityFrameworkCore.Factories
{
    /// <summary>
    /// A version of RobloxEntityFactory that's intended to only be used by RobloxEntity.
    /// </summary>
    internal sealed class RobloxEntityFactory<TDto, TIndex, TDatabase> : RobloxDtoFactoryBase<TDto, TIndex, TDatabase>
        where TDto : RobloxDto<TDto, TIndex>, new()
        where TIndex : struct, IEquatable<TIndex>
        where TDatabase : GlobalDatabase<TDatabase>, new()
    {
    }
}

