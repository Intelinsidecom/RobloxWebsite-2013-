using System;
using System.Collections.Generic;
using System.Text;

namespace Roblox.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Internal interface for unit tests.
    /// </summary>
    /// <typeparam name="TIndex"></typeparam>
    internal interface IEnumeratorEntity<TIndex> : IRobloxDto<TIndex>
    {
        string Value { get; set; }
    }
}
