;// bundle: iframelogin___076db2e388289a45151d01d31ad7e78e
;// files: jquery.ba-postmessage.js, iFrameLogin.js

;// jquery.ba-postmessage.js
/*!
 * jQuery postMessage - v0.5 - 9/11/2009
 * http://benalman.com/projects/jquery-postmessage-plugin/
 * 
 * Copyright (c) 2009 "Cowboy" Ben Alman
 * Dual licensed under the MIT and GPL licenses.
 * http://benalman.com/about/license/
 */

// Script: jQuery postMessage: Cross-domain scripting goodness
//
// *Version: 0.5, Last updated: 9/11/2009*
// 
// Project Home - http://benalman.com/projects/jquery-postmessage-plugin/
// GitHub       - http://github.com/cowboy/jquery-postmessage/
// Source       - http://github.com/cowboy/jquery-postmessage/raw/master/jquery.ba-postmessage.js
// (Minified)   - http://github.com/cowboy/jquery-postmessage/raw/master/jquery.ba-postmessage.min.js (0.9kb)
// 
// About: License
// 
// Copyright (c) 2009 "Cowboy" Ben Alman,
// Dual licensed under the MIT and GPL licenses.
// http://benalman.com/about/license/
// 
// About: Examples
// 
// This working example, complete with fully commented code, illustrates one
// way in which this plugin can be used.
// 
// Iframe resizing - http://benalman.com/code/projects/jquery-postmessage/examples/iframe/
// 
// About: Support and Testing
// 
// Information about what version or versions of jQuery this plugin has been
// tested with and what browsers it has been tested in.
// 
// jQuery Versions - 1.3.2
// Browsers Tested - Internet Explorer 6-8, Firefox 3, Safari 3-4, Chrome, Opera 9.
// 
// About: Release History
// 
// 0.5 - (9/11/2009) Improved cache-busting
// 0.4 - (8/25/2009) Initial release

(function($){
  '$:nomunge'; // Used by YUI compressor.
  
  // A few vars used in non-awesome browsers.
  var interval_id,
    last_hash,
    cache_bust = 1,
    
    // A var used in awesome browsers.
    rm_callback,
    
    // A few convenient shortcuts.
    window = this,
    FALSE = !1,
    
    // Reused internal strings.
    postMessage = 'postMessage',
    addEventListener = 'addEventListener',
    
    p_receiveMessage,
    
    // I couldn't get window.postMessage to actually work in Opera 9.64!
    has_postMessage = window[postMessage] && !$.browser.opera;
  
  // Method: jQuery.postMessage
  // 
  // This method will call window.postMessage if available, setting the
  // targetOrigin parameter to the base of the target_url parameter for maximum
  // security in browsers that support it. If window.postMessage is not available,
  // the target window's location.hash will be used to pass the message. If an
  // object is passed as the message param, it will be serialized into a string
  // using the jQuery.param method.
  // 
  // Usage:
  // 
  // > jQuery.postMessage( message, target_url [, target ] );
  // 
  // Arguments:
  // 
  //  message - (String) A message to be passed to the other frame.
  //  message - (Object) An object to be serialized into a params string, using
  //    the jQuery.param method.
  //  target_url - (String) The URL of the other frame this window is
  //    attempting to communicate with. This must be the exact URL (including
  //    any query string) of the other window for this script to work in
  //    browsers that don't support window.postMessage.
  //  target - (Object) A reference to the other frame this window is
  //    attempting to communicate with. If omitted, defaults to `parent`.
  // 
  // Returns:
  // 
  //  Nothing.
  
  $[postMessage] = function( message, target_url, target ) {
    if ( !target_url ) { return; }
    
    // Serialize the message if not a string. Note that this is the only real
    // jQuery dependency for this script. If removed, this script could be
    // written as very basic JavaScript.
    message = typeof message === 'string' ? message : $.param( message );
    
    // Default to parent if unspecified.
    target = target || parent;
    
    if ( has_postMessage ) {
      // The browser supports window.postMessage, so call it with a targetOrigin
      // set appropriately, based on the target_url parameter.
      target[postMessage]( message, target_url.replace( /([^:]+:\/\/[^\/]+).*/, '$1' ) );
      
    } else if ( target_url ) {
      // The browser does not support window.postMessage, so set the location
      // of the target to target_url#message. A bit ugly, but it works! A cache
      // bust parameter is added to ensure that repeat messages trigger the
      // callback.
      target.location = target_url.replace( /#.*$/, '' ) + '#' + (+new Date) + (cache_bust++) + '&' + message;
    }
  };
  
  // Method: jQuery.receiveMessage
  // 
  // Register a single callback for either a window.postMessage call, if
  // supported, or if unsupported, for any change in the current window
  // location.hash. If window.postMessage is supported and source_origin is
  // specified, the source window will be checked against this for maximum
  // security. If window.postMessage is unsupported, a polling loop will be
  // started to watch for changes to the location.hash.
  // 
  // Note that for simplicity's sake, only a single callback can be registered
  // at one time. Passing no params will unbind this event (or stop the polling
  // loop), and calling this method a second time with another callback will
  // unbind the event (or stop the polling loop) first, before binding the new
  // callback.
  // 
  // Also note that if window.postMessage is available, the optional
  // source_origin param will be used to test the event.origin property. From
  // the MDC window.postMessage docs: This string is the concatenation of the
  // protocol and "://", the host name if one exists, and ":" followed by a port
  // number if a port is present and differs from the default port for the given
  // protocol. Examples of typical origins are https://example.org (implying
  // port 443), http://example.net (implying port 80), and http://example.com:8080.
  // 
  // Usage:
  // 
  // > jQuery.receiveMessage( callback [, source_origin ] [, delay ] );
  // 
  // Arguments:
  // 
  //  callback - (Function) This callback will execute whenever a <jQuery.postMessage>
  //    message is received, provided the source_origin matches. If callback is
  //    omitted, any existing receiveMessage event bind or polling loop will be
  //    canceled.
  //  source_origin - (String) If window.postMessage is available and this value
  //    is not equal to the event.origin property, the callback will not be
  //    called.
  //  source_origin - (Function) If window.postMessage is available and this
  //    function returns false when passed the event.origin property, the
  //    callback will not be called.
  //  delay - (Number) An optional zero-or-greater delay in milliseconds at
  //    which the polling loop will execute (for browser that don't support
  //    window.postMessage). If omitted, defaults to 100.
  // 
  // Returns:
  // 
  //  Nothing!
  
  $.receiveMessage = p_receiveMessage = function( callback, source_origin, delay ) {
    if ( has_postMessage ) {
      // Since the browser supports window.postMessage, the callback will be
      // bound to the actual event associated with window.postMessage.
      
      if ( callback ) {
        // Unbind an existing callback if it exists.
        rm_callback && p_receiveMessage();
        
        // Bind the callback. A reference to the callback is stored for ease of
        // unbinding.
        rm_callback = function(e) {
          if ( ( typeof source_origin === 'string' && e.origin !== source_origin )
            || ( $.isFunction( source_origin ) && source_origin( e.origin ) === FALSE ) ) {
            return FALSE;
          }
          callback( e );
        };
      }
      
      if ( window[addEventListener] ) {
        window[ callback ? addEventListener : 'removeEventListener' ]( 'message', rm_callback, FALSE );
      } else {
        window[ callback ? 'attachEvent' : 'detachEvent' ]( 'onmessage', rm_callback );
      }
      
    } else {
      // Since the browser sucks, a polling loop will be started, and the
      // callback will be called whenever the location.hash changes.
      
      interval_id && clearInterval( interval_id );
      interval_id = null;
      
      if ( callback ) {
        delay = typeof source_origin === 'number'
          ? source_origin
          : typeof delay === 'number'
            ? delay
            : 100;
        
        interval_id = setInterval(function(){
          var hash = document.location.hash,
            re = /^#?\d+&/;
          if ( hash !== last_hash && re.test( hash ) ) {
            last_hash = hash;
            callback({ data: hash.replace( re, '' ) });
          }
        }, delay );
      }
    }
  };
  
})(jQuery);


;// iFrameLogin.js
if (typeof Roblox === "undefined") {
	Roblox = {};
}

Roblox.iFrameLogin = new function () {
    var ChallengeOrResponseMissingCode = "1";
    var UnableToVerifyCaptchaCode = "2";
    var ErrorOccurredCode = "3";
    var RequireTwoFactorAuthCode = "4";
    var FeatureDisabledCode = "5";
    var CaptchaChangedCode = "6";
    var IncorrectCredentialCode = "7";
    var CaptchaValidationError = "8";

    function init() {
        var requireRedirect = $(document.body).data("redirecttohttp");
        var captchaOn = $(document.body).data("captchaon");
        var holdOnAnotherEnter = false;
        var inValidUserName = true;

        var resizeParent = function (size) {
            var parentUrl = $(document.body).data("parent-url");
            $.postMessage('resize,' + size, parentUrl, parent);
        };

        //Resize div if Captcha is ON
        if (captchaOn) {
            resizeParent('265px');
        } else {
            resizeParent('128px');
        }

        var showLoggingIn = function (displayLoggingIn) {
            if (displayLoggingIn) {
                $('#LoginButton').hide();
                $('#LoggingInStatus').show();
            } else {
                $('#LoginButton').show();
                $('#LoggingInStatus').hide();
            }
        };

        var validateInputs = function () {
            var invalid = false;
            var inputs = [$('#Password'), $('#UserName')];
            if (captchaOn)
                inputs.push($('#recaptcha_response_field'));
            jQuery.each(inputs, function () {
                var $input = $(this);
                if ($input.val() == '') {
                    displayInputError($input, true);
                    invalid = true;
                } else
                    displayInputError($input, false);
            });
            return invalid;
        };

        var displayInputError = function (div, mode) {
            holdOnAnotherEnter = false;
            showLoggingIn(false);
            if (mode)
                div.css({ 'background-color': '#FDD' });
            else
                div.css({ 'background-color': 'white' });
        };

        var submitLogin = function () {
            //Validate Inputs
            if (validateInputs())
                return false;
            if (inValidUserName) {
                displayInputError($('#UserName'), true);
                return false;
            }
            holdOnAnotherEnter = true;
            showLoggingIn(true);
            var password = ($('#Password').val());
            var userName = ($('#UserName').val());
            var ch = '';
            var resp = '';
            if (captchaOn) {
                ch = $('#recaptcha_challenge_field').val();
                resp = $('#recaptcha_response_field').val();
                if (ch == "" || resp == "") {
                    displayInputError($('#recaptcha_response_field'), true);
                    return false;
                }
            }
            if (captchaOn)
                $('#Captcha_upBadCaptcha').text("");
            var onSuccess = onError = function (result, context) {
                if (result.IsValid) {
                    var topUrl;
                    //Redirect based on http/https
                    if (requireRedirect) {
                        topUrl = $(document.body).data("parent-url");
                    } else {
                        topUrl = window.parent.location.href;
                    }
                    if (topUrl.indexOf('#') != -1)
                        topUrl = window.parent.location.href.split('#')[0];
                    if (topUrl.indexOf('?') == -1)
                        topUrl += "?nl=true";
                    else
                        topUrl += "&nl=true";
                    window.parent.location = topUrl;
                    
                } else {
                    //Reload Page if Captcha control changed
                    if (result.ErrorCode.indexOf(CaptchaChangedCode) != -1) {
                        if (userName != '' && window.location.href.indexOf('username') == -1) {
                            window.location.href = window.location.href + '&username=' + userName;
                        } else
                            window.location.reload();
                        return false;
                    }
                    //Handle the Failure Response
                    if (result.ErrorCode.indexOf(RequireTwoFactorAuthCode) != -1) {
                        window.parent.location = "/login/twofactorauth?username=" + encodeURIComponent(userName);
                    }
                    if (result.ErrorCode.indexOf(IncorrectCredentialCode) != -1) {
                        displayInputError($('#Password'), true);
                        $("#NotAMemberLink").hide();
                        $("#ForgotPasswordLink").show();
                    } else if (result.ErrorCode.indexOf(ErrorOccurredCode) != -1) {
                        resizeParent('145px');
                        $('#ErrorMessage').text(result.Message);
                    } else if (result.ErrorCode.indexOf(FeatureDisabledCode) != -1) {
                        $('#ErrorMessage').text(result.Message);
                    }
                    //Else all other errors are to do with Captcha -if(result.Message == 'incorrect-captcha-sol')						
                    else {
                        //Increase size of the window to display the error message:
                        resizeParent('280px');
                        displayInputError($('#Password'), false);
                        $('#Captcha_upBadCaptcha').show();
                        $('#Captcha_upBadCaptcha').css("color", "red");
                        if (result.Message == 'incorrect-captcha-sol')
                            $('#Captcha_upBadCaptcha').text(Roblox.iFrameLogin.Resources.invalidCaptchaEntry);
                        else
                            $('#Captcha_upBadCaptcha').text(result.Message);
                    }
                    if (captchaOn) {
                        Recaptcha.reload("t"); // Required to avoid Captcha control from overriding focus()
                    }
                    $('#Password').val("");
                    $('#Password').focus();
                    holdOnAnotherEnter = false;
                    showLoggingIn(false);
                    return false;
                }
            }
            Roblox.Website.Services.Secure.LoginService.ValidateLogin(userName, password, captchaOn, ch, resp, onSuccess, onError);
        };

        var verifyUserName = function () {
            var userName = $('#UserName').val();
            //Trim whitespaces in the UserName
            userName = userName.replace(/ /g, '');
            $('#UserName').val(userName);
            var onSuccess = onError = function (result, context) {
                displayInputError($('#UserName'), !result.success);
                inValidUserName = !result.success;
                if (!result.success) {
                    $("#NotAMemberLink").show();
                    $("#ForgotPasswordLink").hide();
                }
            };
            if (userName != "")
                $.ajax({
                    type: "GET",
                    url: "/UserCheck/doesusernameexist?username=" + userName,
                    success: onSuccess,
                    error: onError
                });
        };

        $('#LoginButton').click(function () {
            submitLogin();
        });

        $('#UserName').blur(function () {
            verifyUserName();
        });

        $(document).keydown(function (event) {
            if (event.which == 13 && !holdOnAnotherEnter) {
                submitLogin();
                return false;
            }
        });
        $(function () {
            var tabindex = 1;
            $('input,select').each(function () {
                if (this.type != 'hidden') {
                    var $input = $(this);
                    $input.attr('tabindex', tabindex);
                    tabindex++;
                }
            });
        });
        //If page is reloaded with UserName, then User is Valid
        $(function () {
            if ($('#UserName').val() != '' || $('#UserName').val() != undefined);
            inValidUserName = false;
        });
        //Fix captcha CSS
        $(function () {
            $('#CaptchaContainer').css({ 'margin-left': '0', 'margin-top': '8px', 'width': 'none' });
        });
    }

    return { init: init };
}
