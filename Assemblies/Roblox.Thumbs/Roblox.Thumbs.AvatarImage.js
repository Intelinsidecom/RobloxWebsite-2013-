// AvatarImage.js.  Register the namespace for the control.
Type.registerNamespace('Roblox.Thumbs');

//
// Define the control properties.
//
Roblox.Thumbs.AvatarImage = function (element) {
    Roblox.Thumbs.AvatarImage.initializeBase(this, [element]);
    this._userID = 0;
};

//
// Create the prototype for the control.
//
Roblox.Thumbs.AvatarImage.prototype = {

    initialize: function () {
        Roblox.Thumbs.AvatarImage.callBaseMethod(this, 'initialize');
        this._webService = Roblox.Thumbs.Avatar;
        this._requestThumbnail = Function.createDelegate(this, this.requestThumbnail);
    },

    dispose: function () {
        Roblox.Thumbs.AvatarImage.callBaseMethod(this, 'dispose');
    },

    get_userID: function () {
        return this._userID;
    },

    set_userID: function (value) {
        if (this._userID !== value) {
            this._userID = value;
            this.raisePropertyChanged('userID');
        }
    },

    requestThumbnail: function () {
        var style = this.get_element().style;
        var width = style.pixelWidth;
        var height = style.pixelHeight;

        var onSuccess = function (result, context) { context._onUrl(result); };
        var onError = function (result, context) { context._onError(result); };

        this._webService.RequestThumbnail(this._userID, width, height, this._fileExtension, this._thumbnailFormatID, false, onSuccess, onError, this);
    }
};

// Optional descriptor for JSON serialization.
Roblox.Thumbs.AvatarImage.descriptor = {
    properties: []
};

// Register the class as a type that inherits from Sys.UI.Control.
Roblox.Thumbs.AvatarImage.registerClass('Roblox.Thumbs.AvatarImage', Roblox.Thumbs.Image);

Roblox.Thumbs.AvatarImage.updateUrl = function (componentID) {
    /// <summary>
    /// This static function (that is intended to be called from script emitted
    /// on the server)
    /// </summary>
    var a = $find(componentID);
    if (a) a._onUpdate();
};