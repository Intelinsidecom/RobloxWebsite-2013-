// AssetImage.js.  Register the namespace for the control.
Type.registerNamespace('Roblox.Thumbs');

//
// Define the control properties.
//
Roblox.Thumbs.AssetImage = function (element) {
    Roblox.Thumbs.AssetImage.initializeBase(this, [element]);
    this._assetID = 0;
    this._assetVersionID = null;
    this._ov = false;
};

//
// Create the prototype for the control.
//
Roblox.Thumbs.AssetImage.prototype = {

    initialize: function () {
        Roblox.Thumbs.AssetImage.callBaseMethod(this, 'initialize');
        this._webService = Roblox.Thumbs.Asset;
        this._requestThumbnail = Function.createDelegate(this, this.requestThumbnail);
    },

    dispose: function () {
        Roblox.Thumbs.AssetImage.callBaseMethod(this, 'dispose');
    },

    get_assetID: function () {
        return this._assetID;
    },

    set_assetID: function (value) {
        if (this._assetID !== value) {
            this._assetID = value;
            this.raisePropertyChanged('assetID');
        }
    },

    get_assetVersionID: function () {
        return this._assetVersionID;
    },

    set_assetVersionID: function (value) {
        if (this._assetVersionID !== value) {
            this._assetVersionID = value;
            this.raisePropertyChanged('assetVersionID');
        }
    },

    get_ov: function () {
        return this._ov;
    },

    set_ov: function (value) {
        if (this._ov !== value) {
            this._ov = value;
            this.raisePropertyChanged('ov');
        }
    },

    requestThumbnail: function () {
        var style = this.get_element().style;
        var width = style.pixelWidth;
        var height = style.pixelHeight;

        var onSuccess = function (result, context) { context._onUrl(result); };
        var onError = function (result, context) { context._onError(result); };

        this._webService.RequestThumbnail_v2(this._assetID, this._assetVersionID, width, height, this._fileExtension, this._thumbnailFormatID, this._ov, onSuccess, onError, this);
    }
};

// Optional descriptor for JSON serialization.
Roblox.Thumbs.AssetImage.descriptor = {
    properties: []
};

// Register the class as a type that inherits from Sys.UI.Control.
Roblox.Thumbs.AssetImage.registerClass('Roblox.Thumbs.AssetImage', Roblox.Thumbs.Image);

Roblox.Thumbs.AssetImage.updateUrl = function(componentID) {
    /// <summary>
    /// This static function (that is intended to be called from script emitted
    /// on the server)
    /// </summary>
    var a = $find(componentID);
    if (a != null || a != undefined) {
        a._onUpdate();
    }
};

Roblox.Thumbs.AssetImage.mediaPlayer = null;
Roblox.Thumbs.AssetImage.isInitialized = false;
Roblox.Thumbs.AssetImage.currentlyPlayingAsset = null;
Roblox.Thumbs.AssetImage.InitMediaPlayer = function () {
    if (typeof jQuery !== "undefined" && !Roblox.Thumbs.AssetImage.isInitialized) {
        Roblox.Thumbs.AssetImage.isInitialized = true;
        $(function () {
            $(document).on("click", "div.MediaPlayerIcon", function (e) {
                var assetButton = $(e.target);
                assetButton.mediaUrl = assetButton.attr("data-mediathumb-url");

                /// <summary>
                /// Determines if the asset button and the given asset button are the same asset.
                /// </summary>
                assetButton.hasSameMediaAs = function (other) {
                    return assetButton.mediaUrl === other.mediaUrl;
                };

                /// <summary>
                /// Plays or resumes the asset button's media and updates the button's visuals.
                /// </summary>
                assetButton.play = function () {
                    if (Roblox.Thumbs.AssetImage.currentlyPlayingAsset === null ||
                        !Roblox.Thumbs.AssetImage.currentlyPlayingAsset.hasSameMediaAs(assetButton)) {

                        // If another asset is playing then pause it first.
                        if (Roblox.Thumbs.AssetImage.currentlyPlayingAsset != null) {
                            Roblox.Thumbs.AssetImage.currentlyPlayingAsset.stop();
                        }

                        Roblox.Thumbs.AssetImage.mediaPlayer.jPlayer("setMedia", { mp3: assetButton.mediaUrl });
                        Roblox.Thumbs.AssetImage.currentlyPlayingAsset = assetButton;

                        Roblox.Thumbs.AssetImage.mediaPlayer.on($.jPlayer.event.ended, assetButton.onJPlayerEnded);
                        Roblox.Thumbs.AssetImage.mediaPlayer.on($.jPlayer.event.error, assetButton.onJPlayerError);
                    }

                    Roblox.Thumbs.AssetImage.mediaPlayer.jPlayer("play");
                    assetButton.removeClass("Play").addClass("Pause");
                };

                /// <summary>
                /// Stops the asset button's media and resets the button.
                /// </summary>
                assetButton.stop = function () {
                    if (Roblox.Thumbs.AssetImage.currentlyPlayingAsset.hasSameMediaAs(assetButton)) {

                        Roblox.Thumbs.AssetImage.currentlyPlayingAsset = null;
                        Roblox.Thumbs.AssetImage.mediaPlayer.jPlayer("clearMedia");
                        Roblox.Thumbs.AssetImage.mediaPlayer.off($.jPlayer.event.ended);
                        Roblox.Thumbs.AssetImage.mediaPlayer.off($.jPlayer.event.error);

                        assetButton.removeClass("Pause").addClass("Play");
                    }
                };

                /// <summary>
                /// Pauses the asset button's media and changes the button's visuals.
                /// </summary>
                assetButton.pause = function () {
                    if (Roblox.Thumbs.AssetImage.currentlyPlayingAsset.hasSameMediaAs(assetButton)) {
                        Roblox.Thumbs.AssetImage.mediaPlayer.jPlayer("pause");
                        assetButton.removeClass("Pause").addClass("Play");
                    }
                }

                /// <summary>
                /// Handles the jPlayer error event.
                /// </summary>
                assetButton.onJPlayerError = function () {
                    assetButton.stop();
                };

                /// <summary>
                /// Handles the jPlayer ended event.
                /// </summary>
                assetButton.onJPlayerEnded = function () {
                    assetButton.stop();
                };

                // If the media player isn't yet initialized then
                // initialize it and begin playing when it's ready.
                if (Roblox.Thumbs.AssetImage.mediaPlayer == null) {
                    Roblox.Thumbs.AssetImage.mediaPlayer = $("<div id='MediaPlayerSingleton'></div>").appendTo("body").jPlayer({
                        swfPath: '/js/jPlayer/2.9.2/jquery.jplayer.swf',
                        solution: "html, flash",
                        supplied: "mp3",
                        wmode: "transparent",
                        errorAlerts: false,
                        warningAlerts: false,
                        ready: function (event) {
                            assetButton.play();
                        }
                    });
                }

                else { // Otherwise, play or pause normally.
                    if (assetButton.hasClass("Pause")) {
                        assetButton.pause();
                    }
                    else {
                        assetButton.play();
                    }
                }
            });
        });
    }
}