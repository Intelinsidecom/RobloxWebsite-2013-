using System;

namespace Roblox.EntityFrameworkCore
{
    /// <summary>
    /// New IRobloxEntity without the reliance on a DAL.
    /// The RobloxEntity class will build upon this.
    /// </summary>
    /// <typeparam name="TIndex"></typeparam>
    public interface IRobloxDto<TIndex>
    {
        /// <summary>
        /// The timestamp to mark when the entity was created
        /// </summary>
        DateTime Created { get; }

        /// <summary>
        /// The timestamp to mark when the entity was last updated
        /// </summary>
        DateTime Updated { get; }

        /// <summary>
        /// The ID of the entity
        /// </summary>
        TIndex ID { get; }
    }

    /// <inheritdoc/>
    public interface IRobloxDto<TDto, TIndex> : IRobloxDto<TIndex>, IEquatable<TDto>
    {
    }
}
