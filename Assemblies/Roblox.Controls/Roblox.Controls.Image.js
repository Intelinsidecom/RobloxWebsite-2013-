

Type.registerNamespace('Roblox.Controls.Image');


Roblox.Controls.Image.IE6Hack = function(element) {
    var imageElement = element.getElementsByTagName("img")[0];
    var src = imageElement.src;
    imageElement.src = imageElement.blankUrl;
    imageElement.runtimeStyle.filter = "progid:DXImageTransform.Microsoft.AlphaImageLoader(sizingMethod='crop', src='" + src + "')";
};

Roblox.Controls.Image.SetImageSrc = function(element, src) {
    var imageElement = element.getElementsByTagName("img")[0];
    if (imageElement.blankUrl) {
        imageElement.runtimeStyle.filter = "progid:DXImageTransform.Microsoft.AlphaImageLoader(sizingMethod='crop', src='" + src + "')";
    }
    else {
        imageElement.src = src;
    }
};

Roblox.Controls.Image.IsBadImage = function(img) {

    if (!img.complete) {
        return false;
    }

    if (typeof img.naturalWidth != "undefined" && img.naturalWidth === 0) {
        return false;
    }

    // No other way of checking: assume it's ok.
    return true;

};

Roblox.Controls.Image.ErrorUrl = "";

Roblox.Controls.Image.OnError = function(img) {
    if (Roblox.Controls.Image.IsBadImage(img)) {
        var xmlhttp = new XMLHttpRequest();
        var url = img.src;
        xmlhttp.open("POST", Roblox.Controls.Image.ErrorUrl, true);
        xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
        xmlhttp.setRequestHeader("Content-length", url.length);
        xmlhttp.setRequestHeader("Connection", "close");
        xmlhttp.send(url);
    }

    return false;
};
