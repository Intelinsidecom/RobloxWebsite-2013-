using System;
using System.ComponentModel.DataAnnotations;

namespace Roblox.EntityFrameworkCore
{
    /// <summary>
    /// A more slimmed-down version of RobloxEntity.
    /// Excludes all static methods. Intended for use with factories.
    /// </summary>
    public class RobloxDto<TIndex> : IRobloxDto<TIndex>
    {
        #region | Entity Properties |

        public DateTime Created { get; internal set; }
        public DateTime Updated { get; internal set; }

        // Put below Created & Updated to have serialized versions of
        // the entity look less bad.
        [Key]
        public TIndex ID { get; internal set; }

        #endregion | Entity Properties |
    }

    /// <inheritdoc/>
    public class RobloxDto<TDto, TIndex> : RobloxDto<TIndex>, IRobloxDto<TDto, TIndex>
        where TDto : IRobloxDto<TIndex>
        where TIndex : struct, IEquatable<TIndex>
    {
        #region | IEquatable Members |

        public bool Equals(TDto other)
        {
            TIndex id = this.ID;
            TIndex? num = (other != null) ? new TIndex?(other.ID) : null;
            return id.Equals(num.GetValueOrDefault()) & num != null;
        }

        #endregion | IEquatable Members |
    }
}
