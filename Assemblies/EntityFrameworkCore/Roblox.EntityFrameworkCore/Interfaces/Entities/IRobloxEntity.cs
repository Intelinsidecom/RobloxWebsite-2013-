namespace Roblox.EntityFrameworkCore
{
    /// <summary>
    /// An interface for all ROBLOX entities.
    /// </summary>
    /// <typeparam name="TEntity">The entity's type.</typeparam>
    /// <typeparam name="TIndex">The type to use for the entity's index.</typeparam>
    public interface IRobloxEntity<TEntity, TIndex> : IRobloxDto<TEntity, TIndex>
    {
        /// <summary>
        /// Creates or updates the entity in the database.
        /// </summary>
        void Save();

        /// <summary>
        /// Deletes the entity from the database.
        /// </summary>
        void Delete();
    }
}
