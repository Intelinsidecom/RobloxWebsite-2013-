using System;

namespace Roblox.EntityFrameworkCore.Factories
{
    public interface IRobloxDtoFactory<TDto, TIndex>
    {
        /// <summary>
        /// Gets the data transfer object associated with the given ID.
        /// </summary>
        /// <param name="id">The ID to fetch the data transfer object by</param>
        /// <returns>The data transfer object associated with the given ID</returns>
        TDto Get(TIndex id);

        /// <summary>
        /// Gets the DTO associated with the given ID, or throws an exception.
        /// </summary>
        /// <param name="id">The ID to fetch the DTO by</param>
        /// <returns>The DTO associated with the given ID</returns>
        /// <exception cref="InvalidOperationException">The DTO with the given ID doesn't exist</exception>
        TDto MustGet(TIndex id);

        /// <summary>
        /// Saves the given DTO to the database.
        /// </summary>
        /// <param name="entity">The DTO to save.</param>
        void Save(TDto entity);

        /// <summary>
        /// Deletes the given DTO from the database.
        /// </summary>
        /// <param name="dto">The DTO to delete.</param>
        void Delete(TDto entity);
    }
}
