using Roblox.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Roblox.EntityFrameworkCore.Entities
{
    /// <summary>
    /// An entity that tries to serve the purpose of a data-bound enum.
    /// </summary>
    public abstract class EnumeratorEntity<TEntity, TIndex> : IRobloxEntity<TEntity, TIndex>, IEnumeratorEntity<TIndex>
        where TEntity : EnumeratorEntity<TEntity, TIndex>, new()
        where TIndex : struct, IEquatable<TIndex>
    {
        #region | Properties |

        /// <summary>
        /// The value assigned to the enum.
        /// </summary>
        [Required]
        public string Value { get; set; }

        public DateTime Created => throw new NotImplementedException();

        public DateTime Updated => throw new NotImplementedException();

        public TIndex ID => throw new NotImplementedException();

        #endregion | Properties |

        #region | CRUD Methods |

        /// <summary>
        /// Gets the entity by Value.
        /// </summary>
        /// <param name="value">The Value associated with the desired entity</param>
        /// <returns>The entity with the given Value</returns>
        public static TEntity Get(string value)
        {
            TEntity result = null;


            return result;
        }

        /// <summary>
        /// Creates a new entity.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The created entity</returns>
        public static TEntity CreateNew(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value));

            var result = new TEntity
            {
                Value = value
            };
            result.Save();

            return result;
        }
        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public bool Equals(TEntity other)
        {
            throw new NotImplementedException();
        }

        #endregion | CRUD Methods |
    }
}
