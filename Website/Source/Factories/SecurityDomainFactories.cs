using System;
using Roblox.EventLog;
using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication
{
    /// <summary>
    /// Represents a set of factories for the security domain.
    /// </summary>
    public class SecurityDomainFactories : DomainFactoriesBase
    {
        /// <summary>
        /// Gets the logger.
        /// </summary>
        public virtual ILogger Logger { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityDomainFactories" /> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public SecurityDomainFactories(ILogger logger)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
