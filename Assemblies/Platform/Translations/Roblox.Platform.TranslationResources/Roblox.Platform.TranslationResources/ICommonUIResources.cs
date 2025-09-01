using System;
using System.Collections.Generic;
using Roblox.Platform.TranslationResources.CommonUI;
namespace Roblox.Platform.TranslationResources {
    public interface ICommonUIResources : ITranslationResourcesNamespacesGroup

{
	IControlsResources Controls { get; }

	IFeaturesResources Features { get; }

	IMessagesResources Messages { get; }
}


}


