;// bundle: master___82247b37c29d874ced111411827e2532
;// files: roblox.js, jquery.json-2.2.js, jquery.simplemodal-1.3.5.js, jquery.tipsy.js, AjaxAvatarThumbnail.js, extensions/string.js, StringTruncator.js, json2.js, webkit.js, GoogleAnalytics/GoogleAnalyticsEvents.js, MasterPageUI.js, jquery.cookie.js, jquery.jsoncookie.js, JSErrorTracker.js, RobloxEventManager.js, RobloxEventListener.js, GoogleEventListener.js, MongoEventListener.js, SiteTouchEvent.js, jPlayer/2.4.0/jquery.jplayer.js, XsrfToken.js, jquery.ba-postmessage.js, parentFrameLogin.js, DropDownNav.js, UpsellAdModal.js

;// roblox.js
(function (window, undefined) {

    var document = window.document,
        firstScript = document.getElementsByTagName('script')[0],
        isString = function (o) {
            return typeof o == 'string';
        },
        isArray = function (o) {
            return Object.prototype.toString.call(o) == '[object Array]';
        },
        isFunction = function (o) {
            return Object.prototype.toString.call(o) == '[object Function]';
        },
        resourceMap = {},
        config = {
            baseUrl: '',
            modulePath: '/js/modules',
            paths: {},
            externalResources: []
        };


    function deepGet(object, property) {
        var parts = property.split('.');
        for (property = parts.shift(); parts.length > 0; object = object[property], property = parts.shift()) {
            if (object[property] === undefined)
                return undefined;
        }
        return object[property];
    }

    function deepSet(object, property, value) {
        var parts = property.split('.');
        for (property = parts.shift(); parts.length > 0; object = object[property], property = parts.shift()) {
            if (object[property] === undefined)
                object[property] = {};
        }
        object[property] = value;
    }

    function loadCss(href, onload) {
        var link = document.createElement('link');
        link.href = href;
        link.rel = 'stylesheet';
        link.type = 'text/css';
        firstScript.parentNode.insertBefore(link, firstScript);
        onload();
    }

    function loadJs(src, onload) {
        var script = document.createElement('script');
        script.type = 'text/javascript';
        script.src = src;
        script.onload = script.onreadystatechange = function () {
            if (!script.readyState || script.readyState == 'loaded' || script.readyState == 'complete') {
                onload();

                // Handle memory leak in IE
                script.onload = script.onreadystatechange = null;
            }
        };
        firstScript.parentNode.insertBefore(script, firstScript);
    }

    function getExtension(url) {
        return url.split('.').pop().split('?').shift();
    }

    function getResourceName(url) {
        // Check if it's already a name
        if (url.indexOf('.js') < 0)
            return url;

        // Pull out the name if it's a module
        if (url.indexOf(config.modulePath) >= 0)
            return url.split(config.modulePath + '/').pop().split('.').shift().replace('/', '.');

        // Check paths config
        for (var name in config.paths) {
            if (config.paths[name] == url)
                return name;
        }

        // Resource isn't a module, use url for name
        return url;
    }

    function getResourceUrl(name) {
        // Check if it's already a url
        if (name.indexOf('.js') >= 0 || name.indexOf('.css') >= 0)
            return name;

        return config.paths[name] || config.baseUrl + config.modulePath + '/' + name.replace('.', '/') + '.js';
    }

    function getModules(resources) {
        var module, modules = [];
        for (var i = 0; i < resources.length; i++) {
            module = deepGet(Roblox, getResourceName(resources[i]));
            if (module !== undefined)
                modules.push(module);
        }
        return modules;
    }

    function resolveResource(name) {
        var resource = resourceMap[name];
        if (!resource.loaded || !resource.depsLoaded)
            return;

        // Notify listeners
        while (resource.listeners.length > 0) {
            (resource.listeners.shift())();
        }
    }

    function loadResource(nameOrUrl, onload) {
        if (!isString(nameOrUrl) || config.externalResources.toString().indexOf(nameOrUrl) >= 0)
            return onload();

        var name = getResourceName(nameOrUrl);
        if (resourceMap[name] === undefined) {
            resourceMap[name] = {
                loaded: false,
                depsLoaded: true,
                listeners: []
            };
            resourceMap[name].listeners.push(onload);

            var url = getResourceUrl(name),
                load = getExtension(url) == 'css' ? loadCss : loadJs;
            load(url, function () {
                resourceMap[name].loaded = true;
                resolveResource(name);
            });
        }
        else {
            // Wait for resource to load
            resourceMap[name].listeners.push(onload);
            resolveResource(name);
        }
    }

    function loadResourceChain(urls, onload) {
        var first = urls.shift(),
            chainload = (urls.length == 0) ? onload : function () { loadResourceChain(urls, onload) };

        loadResource(first, chainload);
    }

    /**
    *
    *  Ensures all dependencies are loaded before executing the callback
    *
    *  @param {String|Array} - One or more dependencies to wait for
    *  @param {Function} - The callback to execute when all dependencies are ready
    *
    **/
    function require(dependencies, onready) {
        if (!isArray(dependencies))
            dependencies = [dependencies];

        var onload = function () {
            onready.apply(null, getModules(dependencies));
        };

        // Load resources from copy array
        loadResourceChain(dependencies.slice(0), onload);
    }

    /**
    *
    *  Defines a module onto the global Roblox object
    *
    *  @param {String} - The name of the module (MUST correlate to path in modules folder, i.e. modules/Pagelets/BestFriends.js would be named Pagelets.BestFriends)
    *  @param {String|Array} - An optional list of dependencies
    *  @param {Function} - Factory function to create the module
    *
    **/
    function define(name, dependencies, factory) {
        // Check for no dependency alternate syntax
        if (isFunction(dependencies)) {
            factory = dependencies;
            dependencies = [];
        }
        else if (!isArray(dependencies)) {
            dependencies = [dependencies];
        }

        resourceMap[name] = resourceMap[name] || { loaded: true, listeners: [] };
        resourceMap[name].depsLoaded = false;
        resourceMap[name].listeners.unshift(function () {
            // Add module to Roblox object
            deepSet(Roblox, name, factory.apply(null, getModules(dependencies)));
        });

        require(dependencies, function () {
            resourceMap[name].depsLoaded = true;
            resolveResource(name);
        });
    }

    if (typeof Roblox === 'undefined') {
        Roblox = {};

        Roblox.config = config;
        Roblox.require = require;
        Roblox.define = define;
    }

})(window);

;// jquery.json-2.2.js
/*
 * jQuery JSON Plugin
 * version: 2.1 (2009-08-14)
 *
 * This document is licensed as free software under the terms of the
 * MIT License: http://www.opensource.org/licenses/mit-license.php
 *
 * Brantley Harris wrote this plugin. It is based somewhat on the JSON.org 
 * website's http://www.json.org/json2.js, which proclaims:
 * "NO WARRANTY EXPRESSED OR IMPLIED. USE AT YOUR OWN RISK.", a sentiment that
 * I uphold.
 *
 * It is also influenced heavily by MochiKit's serializeJSON, which is 
 * copyrighted 2005 by Bob Ippolito.
 */
 
(function($) {
    /** jQuery.toJSON( json-serializble )
        Converts the given argument into a JSON respresentation.

        If an object has a "toJSON" function, that will be used to get the representation.
        Non-integer/string keys are skipped in the object, as are keys that point to a function.

        json-serializble:
            The *thing* to be converted.
     **/
    $.toJSON = function(o)
    {
        if (typeof(JSON) == 'object' && JSON.stringify)
            return JSON.stringify(o);
        
        var type = typeof(o);
    
        if (o === null)
            return "null";
    
        if (type == "undefined")
            return undefined;
        
        if (type == "number" || type == "boolean")
            return o + "";
    
        if (type == "string")
            return $.quoteString(o);
    
        if (type == 'object')
        {
            if (typeof o.toJSON == "function") 
                return $.toJSON( o.toJSON() );
            
            if (o.constructor === Date)
            {
                var month = o.getUTCMonth() + 1;
                if (month < 10) month = '0' + month;

                var day = o.getUTCDate();
                if (day < 10) day = '0' + day;

                var year = o.getUTCFullYear();
                
                var hours = o.getUTCHours();
                if (hours < 10) hours = '0' + hours;
                
                var minutes = o.getUTCMinutes();
                if (minutes < 10) minutes = '0' + minutes;
                
                var seconds = o.getUTCSeconds();
                if (seconds < 10) seconds = '0' + seconds;
                
                var milli = o.getUTCMilliseconds();
                if (milli < 100) milli = '0' + milli;
                if (milli < 10) milli = '0' + milli;

                return '"' + year + '-' + month + '-' + day + 'T' +
                             hours + ':' + minutes + ':' + seconds + 
                             '.' + milli + 'Z"'; 
            }

            if (o.constructor === Array) 
            {
                var ret = [];
                for (var i = 0; i < o.length; i++)
                    ret.push( $.toJSON(o[i]) || "null" );

                return "[" + ret.join(",") + "]";
            }
        
            var pairs = [];
            for (var k in o) {
                var name;
                var type = typeof k;

                if (type == "number")
                    name = '"' + k + '"';
                else if (type == "string")
                    name = $.quoteString(k);
                else
                    continue;  //skip non-string or number keys
            
                if (typeof o[k] == "function") 
                    continue;  //skip pairs where the value is a function.
            
                var val = $.toJSON(o[k]);
            
                pairs.push(name + ":" + val);
            }

            return "{" + pairs.join(", ") + "}";
        }
    };

    /** jQuery.evalJSON(src)
        Evaluates a given piece of json source.
     **/
    $.evalJSON = function(src)
    {
        if (typeof(JSON) == 'object' && JSON.parse)
            return JSON.parse(src);
        return eval("(" + src + ")");
    };
    
    /** jQuery.secureEvalJSON(src)
        Evals JSON in a way that is *more* secure.
    **/
    $.secureEvalJSON = function(src)
    {
        if (typeof(JSON) == 'object' && JSON.parse)
            return JSON.parse(src);
        
        var filtered = src;
        filtered = filtered.replace(/\\["\\\/bfnrtu]/g, '@');
        filtered = filtered.replace(/"[^"\\\n\r]*"|true|false|null|-?\d+(?:\.\d*)?(?:[eE][+\-]?\d+)?/g, ']');
        filtered = filtered.replace(/(?:^|:|,)(?:\s*\[)+/g, '');
        
        if (/^[\],:{}\s]*$/.test(filtered))
            return eval("(" + src + ")");
        else
            throw new SyntaxError("Error parsing JSON, source is not valid.");
    };

    /** jQuery.quoteString(string)
        Returns a string-repr of a string, escaping quotes intelligently.  
        Mostly a support function for toJSON.
    
        Examples:
            >>> jQuery.quoteString("apple")
            "apple"
        
            >>> jQuery.quoteString('"Where are we going?", she asked.')
            "\"Where are we going?\", she asked."
     **/
    $.quoteString = function(string)
    {
        if (string.match(_escapeable))
        {
            return '"' + string.replace(_escapeable, function (a) 
            {
                var c = _meta[a];
                if (typeof c === 'string') return c;
                c = a.charCodeAt();
                return '\\u00' + Math.floor(c / 16).toString(16) + (c % 16).toString(16);
            }) + '"';
        }
        return '"' + string + '"';
    };
    
    var _escapeable = /["\\\x00-\x1f\x7f-\x9f]/g;
    
    var _meta = {
        '\b': '\\b',
        '\t': '\\t',
        '\n': '\\n',
        '\f': '\\f',
        '\r': '\\r',
        '"' : '\\"',
        '\\': '\\\\'
    };
})(jQuery);


;// jquery.simplemodal-1.3.5.js
// THIS IS MANUALLY CUSTOMIZED TO WORK WITH jQuery 1.11 !!!
// http://stackoverflow.com/questions/12046242/simple-modal-jquery-1-8-0-and-ie9/18022855#18022855
// I pulled the latest from his github at https://github.com/ericmmartin/simplemodal and then applied the fix from stackoverflow

/*
 * SimpleModal @VERSION - jQuery Plugin
 * http://simplemodal.com/
 * Copyright (c) 2013 Eric Martin
 * Licensed under MIT and GPL
 * Date:
 */

/**
 * SimpleModal is a lightweight jQuery plugin that provides a simple
 * interface to create a modal dialog.
 *
 * The goal of SimpleModal is to provide developers with a cross-browser
 * overlay and container that will be populated with data provided to
 * SimpleModal.
 *
 * There are two ways to call SimpleModal:
 * 1) As a chained function on a jQuery object, like $('#myDiv').modal();.
 * This call would place the DOM object, #myDiv, inside a modal dialog.
 * Chaining requires a jQuery object. An optional options object can be
 * passed as a parameter.
 *
 * @example $('<div>my data</div>').modal({options});
 * @example $('#myDiv').modal({options});
 * @example jQueryObject.modal({options});
 *
 * 2) As a stand-alone function, like $.modal(data). The data parameter
 * is required and an optional options object can be passed as a second
 * parameter. This method provides more flexibility in the types of data
 * that are allowed. The data could be a DOM object, a jQuery object, HTML
 * or a string.
 *
 * @example $.modal('<div>my data</div>', {options});
 * @example $.modal('my data', {options});
 * @example $.modal($('#myDiv'), {options});
 * @example $.modal(jQueryObject, {options});
 * @example $.modal(document.getElementById('myDiv'), {options});
 *
 * A SimpleModal call can contain multiple elements, but only one modal
 * dialog can be created at a time. Which means that all of the matched
 * elements will be displayed within the modal container.
 *
 * SimpleModal internally sets the CSS needed to display the modal dialog
 * properly in all browsers, yet provides the developer with the flexibility
 * to easily control the look and feel. The styling for SimpleModal can be
 * done through external stylesheets, or through SimpleModal, using the
 * overlayCss, containerCss, and dataCss options.
 *
 * SimpleModal has been tested in the following browsers:
 * - IE 6+
 * - Firefox 2+
 * - Opera 9+
 * - Safari 3+
 * - Chrome 1+
 *
 * @name SimpleModal
 * @type jQuery
 * @requires jQuery v1.3
 * @cat Plugins/Windows and Overlays
 * @author Eric Martin (http://ericmmartin.com)
 * @version @VERSION
 */

; (function (factory) {
    if (typeof define === 'function' && define.amd) {
        // AMD. Register as an anonymous module.
        define(['jquery'], factory);
    } else {
        // Browser globals
        factory(jQuery);
    }
}
(function ($) {
    var d = [],
		doc = $(document),
		ua = navigator.userAgent.toLowerCase(),
		wndw = $(window),
		w = [];

    var browser = {
        ieQuirks: null,
        msie: /msie/.test(ua) && !/opera/.test(ua),
        opera: /opera/.test(ua)
    };
    browser.ie6 = browser.msie && /msie 6./.test(ua) && typeof window['XMLHttpRequest'] !== 'object';
    browser.ie7 = browser.msie && /msie 7.0/.test(ua);
    browser.boxModel = (document.compatMode === "CSS1Compat");

    /*
	 * Create and display a modal dialog.
	 *
	 * @param {string, object} data A string, jQuery object or DOM object
	 * @param {object} [options] An optional object containing options overrides
	 */
    $.modal = function (data, options) {
        return $.modal.impl.init(data, options);
    };

    /*
	 * Close the modal dialog.
	 */
    $.modal.close = function () {
        $.modal.impl.close();
    };

    /*
	 * Set focus on first or last visible input in the modal dialog. To focus on the last
	 * element, call $.modal.focus('last'). If no input elements are found, focus is placed
	 * on the data wrapper element.
	 */
    $.modal.focus = function (pos) {
        $.modal.impl.focus(pos);
    };

    /*
	 * Determine and set the dimensions of the modal dialog container.
	 * setPosition() is called if the autoPosition option is true.
	 */
    $.modal.setContainerDimensions = function () {
        $.modal.impl.setContainerDimensions();
    };

    /*
	 * Re-position the modal dialog.
	 */
    $.modal.setPosition = function () {
        $.modal.impl.setPosition();
    };

    /*
	 * Update the modal dialog. If new dimensions are passed, they will be used to determine
	 * the dimensions of the container.
	 *
	 * setContainerDimensions() is called, which in turn calls setPosition(), if enabled.
	 * Lastly, focus() is called is the focus option is true.
	 */
    $.modal.update = function (height, width) {
        $.modal.impl.update(height, width);
    };

    /*
	 * Chained function to create a modal dialog.
	 *
	 * @param {object} [options] An optional object containing options overrides
	 */
    $.fn.modal = function (options) {
        return $.modal.impl.init(this, options);
    };

    /*
	 * SimpleModal default options
	 *
	 * appendTo:		(String:'body') The jQuery selector to append the elements to. For .NET, use 'form'.
	 * focus:			(Boolean:true) Focus in the first visible, enabled element?
	 * opacity:			(Number:50) The opacity value for the overlay div, from 0 - 100
	 * overlayId:		(String:'simplemodal-overlay') The DOM element id for the overlay div
	 * overlayCss:		(Object:{}) The CSS styling for the overlay div
	 * containerId:		(String:'simplemodal-container') The DOM element id for the container div
	 * containerCss:	(Object:{}) The CSS styling for the container div
	 * dataId:			(String:'simplemodal-data') The DOM element id for the data div
	 * dataCss:			(Object:{}) The CSS styling for the data div
	 * minHeight:		(Number:null) The minimum height for the container
	 * minWidth:		(Number:null) The minimum width for the container
	 * maxHeight:		(Number:null) The maximum height for the container. If not specified, the window height is used.
	 * maxWidth:		(Number:null) The maximum width for the container. If not specified, the window width is used.
	 * autoResize:		(Boolean:false) Automatically resize the container if it exceeds the browser window dimensions?
	 * autoPosition:	(Boolean:true) Automatically position the container upon creation and on window resize?
	 * zIndex:			(Number: 1000) Starting z-index value
	 * close:			(Boolean:true) If true, closeHTML, escClose and overClose will be used if set.
	 							If false, none of them will be used.
	 * closeHTML:		(String:'<a class="modalCloseImg" title="Close"></a>') The HTML for the default close link.
								SimpleModal will automatically add the closeClass to this element.
	 * closeClass:		(String:'simplemodal-close') The CSS class used to bind to the close event
	 * escClose:		(Boolean:true) Allow Esc keypress to close the dialog?
	 * overlayClose:	(Boolean:false) Allow click on overlay to close the dialog?
	 * fixed:			(Boolean:true) If true, the container will use a fixed position. If false, it will use a
								absolute position (the dialog will scroll with the page)
	 * position:		(Array:null) Position of container [top, left]. Can be number of pixels or percentage
	 * persist:			(Boolean:false) Persist the data across modal calls? Only used for existing
								DOM elements. If true, the data will be maintained across modal calls, if false,
								the data will be reverted to its original state.
	 * modal:			(Boolean:true) User will be unable to interact with the page below the modal or tab away from the dialog.
								If false, the overlay, iframe, and certain events will be disabled allowing the user to interact
								with the page below the dialog.
	 * onOpen:			(Function:null) The callback function used in place of SimpleModal's open
	 * onShow:			(Function:null) The callback function used after the modal dialog has opened
	 * onClose:			(Function:null) The callback function used in place of SimpleModal's close
	 */
    $.modal.defaults = {
        appendTo: 'body',
        focus: true,
        opacity: 50,
        overlayId: 'simplemodal-overlay',
        overlayCss: {},
        containerId: 'simplemodal-container',
        containerCss: {},
        dataId: 'simplemodal-data',
        dataCss: {},
        minHeight: null,
        minWidth: null,
        maxHeight: null,
        maxWidth: null,
        autoResize: false,
        autoPosition: true,
        zIndex: 1000,
        close: true,
        closeHTML: '<a class="modalCloseImg" title="Close"></a>',
        closeClass: 'simplemodal-close',
        escClose: true,
        overlayClose: false,
        fixed: true,
        position: null,
        persist: false,
        modal: true,
        onOpen: null,
        onShow: null,
        onClose: null
    };

    /*
	 * Main modal object
	 * o = options
	 */
    $.modal.impl = {
        /*
		 * Contains the modal dialog elements and is the object passed
		 * back to the callback (onOpen, onShow, onClose) functions
		 */
        d: {},
        /*
		 * Initialize the modal dialog
		 */
        init: function (data, options) {
            var s = this;

            // don't allow multiple calls
            if (s.d.data) {
                return false;
            }

            // browser.ieQuirks = browser.msie && !browser.boxModel;
            browser.ieQuirks = browser.msie && !($.support.boxModel === undefined) && !$.support.boxModel;

            // merge defaults and user options
            s.o = $.extend({}, $.modal.defaults, options);

            // keep track of z-index
            s.zIndex = s.o.zIndex;

            // set the onClose callback flag
            s.occb = false;

            // determine how to handle the data based on its type
            if (typeof data === 'object') {
                // convert DOM object to a jQuery object
                data = data instanceof $ ? data : $(data);
                s.d.placeholder = false;

                // if the object came from the DOM, keep track of its parent
                if (data.parent().parent().size() > 0) {
                    data.before($('<span></span>')
						.attr('id', 'simplemodal-placeholder')
						.css({ display: 'none' }));

                    s.d.placeholder = true;
                    s.display = data.css('display');

                    // persist changes? if not, make a clone of the element
                    if (!s.o.persist) {
                        s.d.orig = data.clone(true);
                    }
                }
            }
            else if (typeof data === 'string' || typeof data === 'number') {
                // just insert the data as innerHTML
                data = $('<div></div>').html(data);
            }
            else {
                // unsupported data type!
                alert('SimpleModal Error: Unsupported data type: ' + typeof data);
                return s;
            }

            // create the modal overlay, container and, if necessary, iframe
            s.create(data);
            data = null;

            // display the modal dialog
            s.open();

            // useful for adding events/manipulating data in the modal dialog
            if ($.isFunction(s.o.onShow)) {
                s.o.onShow.apply(s, [s.d]);
            }

            // don't break the chain =)
            return s;
        },
        /*
		 * Create and add the modal overlay and container to the page
		 */
        create: function (data) {
            var s = this;

            // get the window properties
            s.getDimensions();

            // add an iframe to prevent select options from bleeding through
            if (s.o.modal && browser.ie6) {
                s.d.iframe = $('<iframe src="javascript:false;"></iframe>')
					.css($.extend(s.o.iframeCss, {
					    display: 'none',
					    opacity: 0,
					    position: 'fixed',
					    height: w[0],
					    width: w[1],
					    zIndex: s.o.zIndex,
					    top: 0,
					    left: 0
					}))
					.appendTo(s.o.appendTo);
            }

            // create the overlay
            s.d.overlay = $('<div></div>')
				.attr('id', s.o.overlayId)
				.addClass('simplemodal-overlay')
				.css($.extend(s.o.overlayCss, {
				    display: 'none',
				    opacity: s.o.opacity / 100,
				    height: s.o.modal ? d[0] : 0,
				    width: s.o.modal ? d[1] : 0,
				    position: 'fixed',
				    left: 0,
				    top: 0,
				    zIndex: s.o.zIndex + 1
				}))
				.appendTo(s.o.appendTo);

            // create the container
            s.d.container = $('<div></div>')
				.attr('id', s.o.containerId)
				.addClass('simplemodal-container')
				.css($.extend(
					{ position: s.o.fixed ? 'fixed' : 'absolute' },
					s.o.containerCss,
					{ display: 'none', zIndex: s.o.zIndex + 2 }
				))
				.append(s.o.close && s.o.closeHTML
					? $(s.o.closeHTML).addClass(s.o.closeClass)
					: '')
				.appendTo(s.o.appendTo);

            s.d.wrap = $('<div></div>')
				.attr('tabIndex', -1)
				.addClass('simplemodal-wrap')
				.css({ height: '100%', outline: 0, width: '100%' })
				.appendTo(s.d.container);

            // add styling and attributes to the data
            // append to body to get correct dimensions, then move to wrap
            s.d.data = data
				.attr('id', data.attr('id') || s.o.dataId)
				.addClass('simplemodal-data')
				.css($.extend(s.o.dataCss, {
				    display: 'none'
				}))
				.appendTo('body');
            data = null;

            s.setContainerDimensions();
            s.d.data.appendTo(s.d.wrap);

            // fix issues with IE
            if (browser.ie6 || browser.ieQuirks) {
                s.fixIE();
            }
        },
        /*
		 * Bind events
		 */
        bindEvents: function () {
            var s = this;

            // bind the close event to any element with the closeClass class
            $('.' + s.o.closeClass).bind('click.simplemodal', function (e) {
                e.preventDefault();
                s.close();
            });

            // bind the overlay click to the close function, if enabled
            if (s.o.modal && s.o.close && s.o.overlayClose) {
                s.d.overlay.bind('click.simplemodal', function (e) {
                    e.preventDefault();
                    s.close();
                });
            }

            // bind keydown events
            doc.bind('keydown.simplemodal', function (e) {
                if (s.o.modal && e.keyCode === 9) { // TAB
                    s.watchTab(e);
                }
                else if ((s.o.close && s.o.escClose) && e.keyCode === 27) { // ESC
                    e.preventDefault();
                    s.close();
                }
            });

            // update window size
            wndw.bind('resize.simplemodal orientationchange.simplemodal', function () {
                // redetermine the window width/height
                s.getDimensions();

                // reposition the dialog
                s.o.autoResize ? s.setContainerDimensions() : s.o.autoPosition && s.setPosition();

                if (browser.ie6 || browser.ieQuirks) {
                    s.fixIE();
                }
                else if (s.o.modal) {
                    // update the iframe & overlay
                    s.d.iframe && s.d.iframe.css({ height: w[0], width: w[1] });
                    s.d.overlay.css({ height: d[0], width: d[1] });
                }
            });
        },
        /*
		 * Unbind events
		 */
        unbindEvents: function () {
            $('.' + this.o.closeClass).unbind('click.simplemodal');
            doc.unbind('keydown.simplemodal');
            wndw.unbind('.simplemodal');
            this.d.overlay.unbind('click.simplemodal');
        },
        /*
		 * Fix issues in IE6 and IE7 in quirks mode
		 */
        fixIE: function () {
            var s = this, p = s.o.position;

            // simulate fixed position - adapted from BlockUI
            $.each([s.d.iframe || null, !s.o.modal ? null : s.d.overlay, s.d.container.css('position') === 'fixed' ? s.d.container : null], function (i, el) {
                if (el) {
                    var bch = 'document.body.clientHeight', bcw = 'document.body.clientWidth',
						bsh = 'document.body.scrollHeight', bsl = 'document.body.scrollLeft',
						bst = 'document.body.scrollTop', bsw = 'document.body.scrollWidth',
						ch = 'document.documentElement.clientHeight', cw = 'document.documentElement.clientWidth',
						sl = 'document.documentElement.scrollLeft', st = 'document.documentElement.scrollTop',
						s = el[0].style;

                    s.position = 'absolute';
                    if (i < 2) {
                        s.removeExpression('height');
                        s.removeExpression('width');
                        s.setExpression('height', '' + bsh + ' > ' + bch + ' ? ' + bsh + ' : ' + bch + ' + "px"');
                        s.setExpression('width', '' + bsw + ' > ' + bcw + ' ? ' + bsw + ' : ' + bcw + ' + "px"');
                    }
                    else {
                        var te, le;
                        if (p && p.constructor === Array) {
                            var top = p[0]
								? typeof p[0] === 'number' ? p[0].toString() : p[0].replace(/px/, '')
								: el.css('top').replace(/px/, '');
                            te = top.indexOf('%') === -1
								? top + ' + (t = ' + st + ' ? ' + st + ' : ' + bst + ') + "px"'
								: parseInt(top.replace(/%/, '')) + ' * ((' + ch + ' || ' + bch + ') / 100) + (t = ' + st + ' ? ' + st + ' : ' + bst + ') + "px"';

                            if (p[1]) {
                                var left = typeof p[1] === 'number' ? p[1].toString() : p[1].replace(/px/, '');
                                le = left.indexOf('%') === -1
									? left + ' + (t = ' + sl + ' ? ' + sl + ' : ' + bsl + ') + "px"'
									: parseInt(left.replace(/%/, '')) + ' * ((' + cw + ' || ' + bcw + ') / 100) + (t = ' + sl + ' ? ' + sl + ' : ' + bsl + ') + "px"';
                            }
                        }
                        else {
                            te = '(' + ch + ' || ' + bch + ') / 2 - (this.offsetHeight / 2) + (t = ' + st + ' ? ' + st + ' : ' + bst + ') + "px"';
                            le = '(' + cw + ' || ' + bcw + ') / 2 - (this.offsetWidth / 2) + (t = ' + sl + ' ? ' + sl + ' : ' + bsl + ') + "px"';
                        }
                        s.removeExpression('top');
                        s.removeExpression('left');
                        s.setExpression('top', te);
                        s.setExpression('left', le);
                    }
                }
            });
        },
        /*
		 * Place focus on the first or last visible input
		 */
        focus: function (pos) {
            var s = this, p = pos && $.inArray(pos, ['first', 'last']) !== -1 ? pos : 'first';

            // focus on dialog or the first visible/enabled input element
            var input = $(':input:enabled:visible:' + p, s.d.wrap);
            setTimeout(function () {
                input.length > 0 ? input.focus() : s.d.wrap.focus();
            }, 10);
        },
        getDimensions: function () {
            // fix a jQuery bug with determining the window height - use innerHeight if available
            var s = this,
				h = typeof window.innerHeight === 'undefined' ? wndw.height() : window.innerHeight;

            d = [doc.height(), doc.width()];
            w = [h, wndw.width()];
        },
        getVal: function (v, d) {
            return v ? (typeof v === 'number' ? v
					: v === 'auto' ? 0
					: v.indexOf('%') > 0 ? ((parseInt(v.replace(/%/, '')) / 100) * (d === 'h' ? w[0] : w[1]))
					: parseInt(v.replace(/px/, '')))
				: null;
        },
        /*
		 * Update the container. Set new dimensions, if provided.
		 * Focus, if enabled. Re-bind events.
		 */
        update: function (height, width) {
            var s = this;

            // prevent update if dialog does not exist
            if (!s.d.data) {
                return false;
            }

            // reset orig values
            s.d.origHeight = s.getVal(height, 'h');
            s.d.origWidth = s.getVal(width, 'w');

            // hide data to prevent screen flicker
            s.d.data.hide();
            height && s.d.container.css('height', height);
            width && s.d.container.css('width', width);
            s.setContainerDimensions();
            s.d.data.show();
            s.o.focus && s.focus();

            // rebind events
            s.unbindEvents();
            s.bindEvents();
        },
        setContainerDimensions: function () {
            var s = this,
				badIE = browser.ie6 || browser.ie7;

            // get the dimensions for the container and data
            var ch = s.d.origHeight ? s.d.origHeight : browser.opera ? s.d.container.height() : s.getVal(badIE ? s.d.container[0].currentStyle['height'] : s.d.container.css('height'), 'h'),
				cw = s.d.origWidth ? s.d.origWidth : browser.opera ? s.d.container.width() : s.getVal(badIE ? s.d.container[0].currentStyle['width'] : s.d.container.css('width'), 'w'),
				dh = s.d.data.outerHeight(true), dw = s.d.data.outerWidth(true);

            s.d.origHeight = s.d.origHeight || ch;
            s.d.origWidth = s.d.origWidth || cw;

            // mxoh = max option height, mxow = max option width
            var mxoh = s.o.maxHeight ? s.getVal(s.o.maxHeight, 'h') : null,
				mxow = s.o.maxWidth ? s.getVal(s.o.maxWidth, 'w') : null,
				mh = mxoh && mxoh < w[0] ? mxoh : w[0],
				mw = mxow && mxow < w[1] ? mxow : w[1];

            // moh = min option height
            var moh = s.o.minHeight ? s.getVal(s.o.minHeight, 'h') : 'auto';
            if (!ch) {
                if (!dh) { ch = moh; }
                else {
                    if (dh > mh) { ch = mh; }
                    else if (s.o.minHeight && moh !== 'auto' && dh < moh) { ch = moh; }
                    else { ch = dh; }
                }
            }
            else {
                ch = s.o.autoResize && ch > mh ? mh : ch < moh ? moh : ch;
            }

            // mow = min option width
            var mow = s.o.minWidth ? s.getVal(s.o.minWidth, 'w') : 'auto';
            if (!cw) {
                if (!dw) { cw = mow; }
                else {
                    if (dw > mw) { cw = mw; }
                    else if (s.o.minWidth && mow !== 'auto' && dw < mow) { cw = mow; }
                    else { cw = dw; }
                }
            }
            else {
                cw = s.o.autoResize && cw > mw ? mw : cw < mow ? mow : cw;
            }

            s.d.container.css({ height: ch, width: cw });
            s.d.wrap.css({ overflow: (dh > ch || dw > cw) ? 'auto' : 'visible' });
            s.o.autoPosition && s.setPosition();
        },
        setPosition: function () {
            var s = this, top, left,
				hc = (w[0] / 2) - (s.d.container.outerHeight(true) / 2),
				vc = (w[1] / 2) - (s.d.container.outerWidth(true) / 2),
				st = s.d.container.css('position') !== 'fixed' ? wndw.scrollTop() : 0;

            if (s.o.position && Object.prototype.toString.call(s.o.position) === '[object Array]') {
                top = st + (s.o.position[0] || hc);
                left = s.o.position[1] || vc;
            } else {
                top = st + hc;
                left = vc;
            }
            s.d.container.css({ left: left, top: top });
        },
        watchTab: function (e) {
            var s = this;

            if ($(e.target).parents('.simplemodal-container').length > 0) {
                // save the list of inputs
                s.inputs = $(':input:enabled:visible:first, :input:enabled:visible:last', s.d.data[0]);

                // if it's the first or last tabbable element, refocus
                if ((!e.shiftKey && e.target === s.inputs[s.inputs.length - 1]) ||
						(e.shiftKey && e.target === s.inputs[0]) ||
						s.inputs.length === 0) {
                    e.preventDefault();
                    var pos = e.shiftKey ? 'last' : 'first';
                    s.focus(pos);
                }
            }
            else {
                // might be necessary when custom onShow callback is used
                e.preventDefault();
                s.focus();
            }
        },
        /*
		 * Open the modal dialog elements
		 * - Note: If you use the onOpen callback, you must "show" the
		 *         overlay and container elements manually
		 *         (the iframe will be handled by SimpleModal)
		 */
        open: function () {
            var s = this;
            // display the iframe
            s.d.iframe && s.d.iframe.show();

            if ($.isFunction(s.o.onOpen)) {
                // execute the onOpen callback
                s.o.onOpen.apply(s, [s.d]);
            }
            else {
                // display the remaining elements
                s.d.overlay.show();
                s.d.container.show();
                s.d.data.show();
            }

            s.o.focus && s.focus();

            // bind default events
            s.bindEvents();
        },
        /*
		 * Close the modal dialog
		 * - Note: If you use an onClose callback, you must remove the
		 *         overlay, container and iframe elements manually
		 *
		 * @param {boolean} external Indicates whether the call to this
		 *     function was internal or external. If it was external, the
		 *     onClose callback will be ignored
		 */
        close: function () {
            var s = this;

            // prevent close when dialog does not exist
            if (!s.d.data) {
                return false;
            }

            // remove the default events
            s.unbindEvents();

            if ($.isFunction(s.o.onClose) && !s.occb) {
                // set the onClose callback flag
                s.occb = true;

                // execute the onClose callback
                s.o.onClose.apply(s, [s.d]);
            }
            else {
                // if the data came from the DOM, put it back
                if (s.d.placeholder) {
                    var ph = $('#simplemodal-placeholder');
                    // save changes to the data?
                    if (s.o.persist) {
                        // insert the (possibly) modified data back into the DOM
                        ph.replaceWith(s.d.data.removeClass('simplemodal-data').css('display', s.display));
                    }
                    else {
                        // remove the current and insert the original,
                        // unmodified data back into the DOM
                        s.d.data.hide().remove();
                        ph.replaceWith(s.d.orig);
                    }
                }
                else {
                    // otherwise, remove it
                    s.d.data.hide().remove();
                }

                // remove the remaining elements
                s.d.container.hide().remove();
                s.d.overlay.hide();
                s.d.iframe && s.d.iframe.hide().remove();
                s.d.overlay.remove();

                // reset the dialog object
                s.d = {};
            }
        }
    };
}));

;// jquery.tipsy.js
// tipsy, facebook style tooltips for jquery
// version 1.0.0a
// (c) 2008-2010 jason frame [jason@onehackoranother.com]
// released under the MIT license

(function ($) {

    function maybeCall(thing, ctx) {
        return (typeof thing == 'function') ? (thing.call(ctx)) : thing;
    };

    function isElementInDOM(ele) {
        while (ele = ele.parentNode) {
            if (ele == document) return true;
        }
        return false;
    };

    function Tipsy(element, options) {
        this.$element = $(element);
        this.options = options;
        this.enabled = true;
        this.fixTitle();
    };

    Tipsy.prototype = {
        show: function () {
            var title = this.getTitle();
            if (title && this.enabled) {
                var $tip = this.tip();

                $tip.find('.tipsy-inner')[this.options.html ? 'html' : 'text'](title);
                $tip[0].className = 'tipsy'; // reset classname in case of dynamic gravity
                $tip.remove().css({ top: 0, left: 0, visibility: 'hidden', display: 'block' }).prependTo(document.body);

                var pos = $.extend({}, this.$element.offset(), {
                    width: this.$element[0].offsetWidth,
                    height: this.$element[0].offsetHeight
                });

                var actualWidth = $tip[0].offsetWidth,
                    actualHeight = $tip[0].offsetHeight,
                    gravity = maybeCall(this.options.gravity, this.$element[0]);

                var tp;
                switch (gravity.charAt(0)) {
                    case 'n':
                        tp = { top: pos.top + pos.height + this.options.offset, left: pos.left + pos.width / 2 - actualWidth / 2 };
                        break;
                    case 's':
                        tp = { top: pos.top - actualHeight - this.options.offset, left: pos.left + pos.width / 2 - actualWidth / 2 };
                        break;
                    case 'e':
                        tp = { top: pos.top + pos.height / 2 - actualHeight / 2, left: pos.left - actualWidth - this.options.offset };
                        break;
                    case 'w':
                        tp = { top: pos.top + pos.height / 2 - actualHeight / 2, left: pos.left + pos.width + this.options.offset };
                        break;
                }

                if (gravity.length == 2) {
                    if (gravity.charAt(1) == 'w') {
                        tp.left = pos.left + pos.width / 2 - 15;
                    } else {
                        tp.left = pos.left + pos.width / 2 - actualWidth + 15;
                    }
                }

                $tip.css(tp).addClass('tipsy-' + gravity);
                $tip.find('.tipsy-arrow')[0].className = 'tipsy-arrow tipsy-arrow-' + gravity.charAt(0);
                if (this.options.className) {
                    $tip.addClass(maybeCall(this.options.className, this.$element[0]));
                }

                if (this.options.fade) {
                    $tip.stop().css({ opacity: 0, display: 'block', visibility: 'visible' }).animate({ opacity: this.options.opacity });
                } else {
                    $tip.css({ visibility: 'visible', opacity: this.options.opacity });
                }
            }
        },

        hide: function () {
            if (this.options.fade) {
                this.tip().stop().fadeOut(function () { $(this).remove(); });
            } else {
                this.tip().remove();
            }
        },

        fixTitle: function () {
            var $e = this.$element;
            if ($e.attr('title') || typeof ($e.attr('original-title')) != 'string') {
                $e.attr('original-title', $e.attr('title') || '').removeAttr('title');
            }
        },

        getTitle: function () {
            var title, $e = this.$element, o = this.options;
            this.fixTitle();
            var title, o = this.options;
            if (typeof o.title == 'string') {
                title = $e.attr(o.title == 'title' ? 'original-title' : o.title);
            } else if (typeof o.title == 'function') {
                title = o.title.call($e[0]);
            }
            title = ('' + title).replace(/(^\s*|\s*$)/, "");
            return title || o.fallback;
        },

        tip: function () {
            if (!this.$tip) {
                this.$tip = $('<div class="tipsy"></div>').html('<div class="tipsy-arrow"></div><div class="tipsy-inner"></div>');
                this.$tip.data('tipsy-pointee', this.$element[0]);
            }
            return this.$tip;
        },

        validate: function () {
            if (!this.$element[0].parentNode) {
                this.hide();
                this.$element = null;
                this.options = null;
            }
        },

        enable: function () { this.enabled = true; },
        disable: function () { this.enabled = false; },
        toggleEnabled: function () { this.enabled = !this.enabled; }
    };

    $.fn.tipsy = function (options) {

        if (options === true) {
            return this.data('tipsy');
        } else if (typeof options == 'string') {
            var tipsy = this.data('tipsy');
            if (tipsy) tipsy[options]();
            return this;
        }

        options = $.extend({}, $.fn.tipsy.defaults, options);

        function get(ele) {
            var tipsy = $.data(ele, 'tipsy');
            if (!tipsy) {
                tipsy = new Tipsy(ele, $.fn.tipsy.elementOptions(ele, options));
                $.data(ele, 'tipsy', tipsy);
            }
            return tipsy;
        }

        function enter() {
            var tipsy = get(this);
            tipsy.hoverState = 'in';
            if (options.delayIn == 0) {
                tipsy.show();
            } else {
                tipsy.fixTitle();
                setTimeout(function () { if (tipsy.hoverState == 'in') tipsy.show(); }, options.delayIn);
            }
        };

        function leave() {
            var tipsy = get(this);
            tipsy.hoverState = 'out';
            if (options.delayOut == 0) {
                tipsy.hide();
            } else {
                setTimeout(function () { if (tipsy.hoverState == 'out') tipsy.hide(); }, options.delayOut);
            }
        };

        if (!options.live) this.each(function () { get(this); });

        if (options.trigger != 'manual') {
            var binder = options.live ? 'live' : 'bind',
                eventIn = options.trigger == 'hover' ? 'mouseenter' : 'focus',
                eventOut = options.trigger == 'hover' ? 'mouseleave' : 'blur';
            this[binder](eventIn, enter)[binder](eventOut, leave);
        }

        return this;

    };

    $.fn.tipsy.defaults = {
        className: null,
        delayIn: 0,
        delayOut: 0,
        fade: false,
        fallback: '',
        gravity: 'n',
        html: false,
        live: false,
        offset: 0,
        opacity: 0.8,
        title: 'title',
        trigger: 'hover'
    };

    $.fn.tipsy.revalidate = function () {
        $('.tipsy').each(function () {
            var pointee = $.data(this, 'tipsy-pointee');
            if (!pointee || !isElementInDOM(pointee)) {
                $(this).remove();
            }
        });
    };

    // Overwrite this method to provide options on a per-element basis.
    // For example, you could store the gravity in a 'tipsy-gravity' attribute:
    // return $.extend({}, options, {gravity: $(ele).attr('tipsy-gravity') || 'n' });
    // (remember - do not modify 'options' in place!)
    $.fn.tipsy.elementOptions = function (ele, options) {
        return $.metadata ? $.extend({}, options, $(ele).metadata()) : options;
    };

    $.fn.tipsy.autoNS = function () {
        return $(this).offset().top > ($(document).scrollTop() + $(window).height() / 2) ? 's' : 'n';
    };

    $.fn.tipsy.autoWE = function () {
        return $(this).offset().left > ($(document).scrollLeft() + $(window).width() / 2) ? 'e' : 'w';
    };

    /**
    * yields a closure of the supplied parameters, producing a function that takes
    * no arguments and is suitable for use as an autogravity function like so:
    *
    * @param margin (int) - distance from the viewable region edge that an
    *        element should be before setting its tooltip's gravity to be away
    *        from that edge.
    * @param prefer (string, e.g. 'n', 'sw', 'w') - the direction to prefer
    *        if there are no viewable region edges effecting the tooltip's
    *        gravity. It will try to vary from this minimally, for example,
    *        if 'sw' is preferred and an element is near the right viewable 
    *        region edge, but not the top edge, it will set the gravity for
    *        that element's tooltip to be 'se', preserving the southern
    *        component.
    */
    $.fn.tipsy.autoBounds = function (margin, prefer) {
        return function () {
            var dir = { ns: prefer[0], ew: (prefer.length > 1 ? prefer[1] : false) },
			    boundTop = $(document).scrollTop() + margin,
			    boundLeft = $(document).scrollLeft() + margin,
			    $this = $(this);

            if ($this.offset().top < boundTop) dir.ns = 'n';
            if ($this.offset().left < boundLeft) dir.ew = 'w';
            if ($(window).width() + $(document).scrollLeft() - $this.offset().left < margin) dir.ew = 'e';
            if ($(window).height() + $(document).scrollTop() - $this.offset().top < margin) dir.ns = 's';

            return dir.ns + (dir.ew ? dir.ew : '');
        }
    };

})(jQuery);


;// AjaxAvatarThumbnail.js
var RobloxThumbs = function() {
    
    /** Private **/
   function _GenerateAvatarThumbHelper(imgTagId, userId, thumbnailFormatId) {
        $.get("/thumbs/rawavatar.ashx",
        {
            UserID: userId,
            ThumbnailFormatID: thumbnailFormatId
        },
        function(data) 
        {
            if (data == "PENDING") 
            {
                window.setTimeout(function() 
                {
                    _GenerateAvatarThumbHelper(imgTagId, userId, thumbnailFormatId);
                }, 3000);
            }
            else if (data.substring(5, 0) == "ERROR") // Should be using JSON...
            {
                // DO something if an error occurs ?
            }
            else // Success
            {
                $('#' + imgTagId).attr('src', data);
            }
        });
    }

    /** Public **/
    return {
        GenerateAvatarThumb: function(imgTagId, userId, thumbnailFormatId) {

            $('#' + imgTagId).attr('src', '/images/spinners/waiting.gif');

            _GenerateAvatarThumbHelper(imgTagId, userId, thumbnailFormatId);
        }
    };
} ();


;// extensions/string.js
/** 
 *  Extensions for JavaScript's built-in String class.
**/
$.extend(String.prototype, (function () {

    /**
     *  Escapes potentially dangerous characters into their HTML encoded equivalents.
     *
     *  #### Examples ####
     *
     *      '<div class="Place">This is a place.</div>'.escapeHTML()
     *          => '&lt;div class=&quot;Place&quot;&gt;This is a place.&lt;/div&gt;'
     *
    **/
    function escapeHTML() {
        var retval = this.replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;');
      
        return retval;
    }

    return {
        escapeHTML:     escapeHTML
    };

})());

;// StringTruncator.js
//Create a span element that will be used to get the width
var isInitialized = false;
var fitStringSpan = null;

function InitStringTruncator()
{
    if (isInitialized)
        return;

    fitStringSpan = document.createElement("span");
    fitStringSpan.style.display = 'inline-block';
    fitStringSpan.style.visibility = 'hidden';
    fitStringSpan.style.height = '0px';
    fitStringSpan.style.padding = '0px';
    document.body.appendChild(fitStringSpan);

    isInitialized = true;
}

function fitStringToWidth(str, width, className) {
    
    if (!isInitialized)
        InitStringTruncator();
    
    // str    A string where html-entities are allowed but no tags.
    // width  The maximum allowed width in pixels
    // className  A CSS class name with the desired font-name and font-size. (optional)
    // ----
    // _escTag is a helper to escape 'less than' and 'greater than'
    function _escTag(s) { return s.replace("<", "&lt;").replace(">", "&gt;"); }

    

   //Allow a classname to be set to get the right font-size.
    if (className)
        fitStringSpan.className = className;
    

    var result = _escTag(str); // default to the whole string
    fitStringSpan.innerHTML = result;
    // Check if the string will fit in the allowed width. NOTE: if the width
    // can't be determinated (offsetWidth==0) the whole string will be returned.
    if (fitStringSpan.offsetWidth > width)
    {
        var posStart = 0, posMid, posEnd = str.length, posLength;
        // Calculate (posEnd - posStart) integer division by 2 and
        // assign it to posLength. Repeat until posLength is zero.
        while (posLength = (posEnd - posStart) >> 1)
        {
            posMid = posStart + posLength;
            //Get the string from the begining up to posMid;
            fitStringSpan.innerHTML = _escTag(str.substring(0, posMid)) + '&hellip;';

            // Check if the current width is too wide (set new end)
            // or too narrow (set new start)
            if (fitStringSpan.offsetWidth > width) posEnd = posMid; else posStart = posMid;
        }

        result = str.substring(0, posStart) + '&hellip;';
//        result = _escTag(str.substring(0, posStart)) + '&hellip;';
    }
    
    return result;
}

function fitStringToWidthSafe(str, width, className) {
    var safeName = fitStringToWidth(str, width, className);
    if (safeName.indexOf("&hellip;") != -1) {
        var posEnd = safeName.lastIndexOf(" ");
        if (posEnd != -1 && posEnd + 10 <= safeName.length) {
            safeName = safeName.substring(0, posEnd + 2) + "&hellip;";
        }
    }
    return safeName;
}
function fitStringToWidthSafeText(str, width, className) {
    var safeName = fitStringToWidthSafe(str, width, className).replace("&hellip;", "...");
    return safeName;
}


;// json2.js
/*
    json2.js
    2013-05-26

    Public Domain.

    NO WARRANTY EXPRESSED OR IMPLIED. USE AT YOUR OWN RISK.

    See http://www.JSON.org/js.html


    This code should be minified before deployment.
    See http://javascript.crockford.com/jsmin.html

    USE YOUR OWN COPY. IT IS EXTREMELY UNWISE TO LOAD CODE FROM SERVERS YOU DO
    NOT CONTROL.


    This file creates a global JSON object containing two methods: stringify
    and parse.

        JSON.stringify(value, replacer, space)
            value       any JavaScript value, usually an object or array.

            replacer    an optional parameter that determines how object
                        values are stringified for objects. It can be a
                        function or an array of strings.

            space       an optional parameter that specifies the indentation
                        of nested structures. If it is omitted, the text will
                        be packed without extra whitespace. If it is a number,
                        it will specify the number of spaces to indent at each
                        level. If it is a string (such as '\t' or '&nbsp;'),
                        it contains the characters used to indent at each level.

            This method produces a JSON text from a JavaScript value.

            When an object value is found, if the object contains a toJSON
            method, its toJSON method will be called and the result will be
            stringified. A toJSON method does not serialize: it returns the
            value represented by the name/value pair that should be serialized,
            or undefined if nothing should be serialized. The toJSON method
            will be passed the key associated with the value, and this will be
            bound to the value

            For example, this would serialize Dates as ISO strings.

                Date.prototype.toJSON = function (key) {
                    function f(n) {
                        // Format integers to have at least two digits.
                        return n < 10 ? '0' + n : n;
                    }

                    return this.getUTCFullYear()   + '-' +
                         f(this.getUTCMonth() + 1) + '-' +
                         f(this.getUTCDate())      + 'T' +
                         f(this.getUTCHours())     + ':' +
                         f(this.getUTCMinutes())   + ':' +
                         f(this.getUTCSeconds())   + 'Z';
                };

            You can provide an optional replacer method. It will be passed the
            key and value of each member, with this bound to the containing
            object. The value that is returned from your method will be
            serialized. If your method returns undefined, then the member will
            be excluded from the serialization.

            If the replacer parameter is an array of strings, then it will be
            used to select the members to be serialized. It filters the results
            such that only members with keys listed in the replacer array are
            stringified.

            Values that do not have JSON representations, such as undefined or
            functions, will not be serialized. Such values in objects will be
            dropped; in arrays they will be replaced with null. You can use
            a replacer function to replace those with JSON values.
            JSON.stringify(undefined) returns undefined.

            The optional space parameter produces a stringification of the
            value that is filled with line breaks and indentation to make it
            easier to read.

            If the space parameter is a non-empty string, then that string will
            be used for indentation. If the space parameter is a number, then
            the indentation will be that many spaces.

            Example:

            text = JSON.stringify(['e', {pluribus: 'unum'}]);
            // text is '["e",{"pluribus":"unum"}]'


            text = JSON.stringify(['e', {pluribus: 'unum'}], null, '\t');
            // text is '[\n\t"e",\n\t{\n\t\t"pluribus": "unum"\n\t}\n]'

            text = JSON.stringify([new Date()], function (key, value) {
                return this[key] instanceof Date ?
                    'Date(' + this[key] + ')' : value;
            });
            // text is '["Date(---current time---)"]'


        JSON.parse(text, reviver)
            This method parses a JSON text to produce an object or array.
            It can throw a SyntaxError exception.

            The optional reviver parameter is a function that can filter and
            transform the results. It receives each of the keys and values,
            and its return value is used instead of the original value.
            If it returns what it received, then the structure is not modified.
            If it returns undefined then the member is deleted.

            Example:

            // Parse the text. Values that look like ISO date strings will
            // be converted to Date objects.

            myData = JSON.parse(text, function (key, value) {
                var a;
                if (typeof value === 'string') {
                    a =
/^(\d{4})-(\d{2})-(\d{2})T(\d{2}):(\d{2}):(\d{2}(?:\.\d*)?)Z$/.exec(value);
                    if (a) {
                        return new Date(Date.UTC(+a[1], +a[2] - 1, +a[3], +a[4],
                            +a[5], +a[6]));
                    }
                }
                return value;
            });

            myData = JSON.parse('["Date(09/09/2001)"]', function (key, value) {
                var d;
                if (typeof value === 'string' &&
                        value.slice(0, 5) === 'Date(' &&
                        value.slice(-1) === ')') {
                    d = new Date(value.slice(5, -1));
                    if (d) {
                        return d;
                    }
                }
                return value;
            });


    This is a reference implementation. You are free to copy, modify, or
    redistribute.
*/

/*jslint evil: true, regexp: true */

/*members "", "\b", "\t", "\n", "\f", "\r", "\"", JSON, "\\", apply,
    call, charCodeAt, getUTCDate, getUTCFullYear, getUTCHours,
    getUTCMinutes, getUTCMonth, getUTCSeconds, hasOwnProperty, join,
    lastIndex, length, parse, prototype, push, replace, slice, stringify,
    test, toJSON, toString, valueOf
*/


// Create a JSON object only if one does not already exist. We create the
// methods in a closure to avoid creating global variables.

if (typeof JSON !== 'object') {
    JSON = {};
}

(function () {
    'use strict';

    function f(n) {
        // Format integers to have at least two digits.
        return n < 10 ? '0' + n : n;
    }

    if (typeof Date.prototype.toJSON !== 'function') {

        Date.prototype.toJSON = function () {

            return isFinite(this.valueOf())
                ? this.getUTCFullYear()     + '-' +
                    f(this.getUTCMonth() + 1) + '-' +
                    f(this.getUTCDate())      + 'T' +
                    f(this.getUTCHours())     + ':' +
                    f(this.getUTCMinutes())   + ':' +
                    f(this.getUTCSeconds())   + 'Z'
                : null;
        };

        String.prototype.toJSON      =
            Number.prototype.toJSON  =
            Boolean.prototype.toJSON = function () {
                return this.valueOf();
            };
    }

    var cx = /[\u0000\u00ad\u0600-\u0604\u070f\u17b4\u17b5\u200c-\u200f\u2028-\u202f\u2060-\u206f\ufeff\ufff0-\uffff]/g,
        escapable = /[\\\"\x00-\x1f\x7f-\x9f\u00ad\u0600-\u0604\u070f\u17b4\u17b5\u200c-\u200f\u2028-\u202f\u2060-\u206f\ufeff\ufff0-\uffff]/g,
        gap,
        indent,
        meta = {    // table of character substitutions
            '\b': '\\b',
            '\t': '\\t',
            '\n': '\\n',
            '\f': '\\f',
            '\r': '\\r',
            '"' : '\\"',
            '\\': '\\\\'
        },
        rep;


    function quote(string) {

// If the string contains no control characters, no quote characters, and no
// backslash characters, then we can safely slap some quotes around it.
// Otherwise we must also replace the offending characters with safe escape
// sequences.

        escapable.lastIndex = 0;
        return escapable.test(string) ? '"' + string.replace(escapable, function (a) {
            var c = meta[a];
            return typeof c === 'string'
                ? c
                : '\\u' + ('0000' + a.charCodeAt(0).toString(16)).slice(-4);
        }) + '"' : '"' + string + '"';
    }


    function str(key, holder) {

// Produce a string from holder[key].

        var i,          // The loop counter.
            k,          // The member key.
            v,          // The member value.
            length,
            mind = gap,
            partial,
            value = holder[key];

// If the value has a toJSON method, call it to obtain a replacement value.

        if (value && typeof value === 'object' &&
                typeof value.toJSON === 'function') {
            value = value.toJSON(key);
        }

// If we were called with a replacer function, then call the replacer to
// obtain a replacement value.

        if (typeof rep === 'function') {
            value = rep.call(holder, key, value);
        }

// What happens next depends on the value's type.

        switch (typeof value) {
        case 'string':
            return quote(value);

        case 'number':

// JSON numbers must be finite. Encode non-finite numbers as null.

            return isFinite(value) ? String(value) : 'null';

        case 'boolean':
        case 'null':

// If the value is a boolean or null, convert it to a string. Note:
// typeof null does not produce 'null'. The case is included here in
// the remote chance that this gets fixed someday.

            return String(value);

// If the type is 'object', we might be dealing with an object or an array or
// null.

        case 'object':

// Due to a specification blunder in ECMAScript, typeof null is 'object',
// so watch out for that case.

            if (!value) {
                return 'null';
            }

// Make an array to hold the partial results of stringifying this object value.

            gap += indent;
            partial = [];

// Is the value an array?

            if (Object.prototype.toString.apply(value) === '[object Array]') {

// The value is an array. Stringify every element. Use null as a placeholder
// for non-JSON values.

                length = value.length;
                for (i = 0; i < length; i += 1) {
                    partial[i] = str(i, value) || 'null';
                }

// Join all of the elements together, separated with commas, and wrap them in
// brackets.

                v = partial.length === 0
                    ? '[]'
                    : gap
                    ? '[\n' + gap + partial.join(',\n' + gap) + '\n' + mind + ']'
                    : '[' + partial.join(',') + ']';
                gap = mind;
                return v;
            }

// If the replacer is an array, use it to select the members to be stringified.

            if (rep && typeof rep === 'object') {
                length = rep.length;
                for (i = 0; i < length; i += 1) {
                    if (typeof rep[i] === 'string') {
                        k = rep[i];
                        v = str(k, value);
                        if (v) {
                            partial.push(quote(k) + (gap ? ': ' : ':') + v);
                        }
                    }
                }
            } else {

// Otherwise, iterate through all of the keys in the object.

                for (k in value) {
                    if (Object.prototype.hasOwnProperty.call(value, k)) {
                        v = str(k, value);
                        if (v) {
                            partial.push(quote(k) + (gap ? ': ' : ':') + v);
                        }
                    }
                }
            }

// Join all of the member texts together, separated with commas,
// and wrap them in braces.

            v = partial.length === 0
                ? '{}'
                : gap
                ? '{\n' + gap + partial.join(',\n' + gap) + '\n' + mind + '}'
                : '{' + partial.join(',') + '}';
            gap = mind;
            return v;
        }
    }

// If the JSON object does not yet have a stringify method, give it one.

    if (typeof JSON.stringify !== 'function') {
        JSON.stringify = function (value, replacer, space) {

// The stringify method takes a value and an optional replacer, and an optional
// space parameter, and returns a JSON text. The replacer can be a function
// that can replace values, or an array of strings that will select the keys.
// A default replacer method can be provided. Use of the space parameter can
// produce text that is more easily readable.

            var i;
            gap = '';
            indent = '';

// If the space parameter is a number, make an indent string containing that
// many spaces.

            if (typeof space === 'number') {
                for (i = 0; i < space; i += 1) {
                    indent += ' ';
                }

// If the space parameter is a string, it will be used as the indent string.

            } else if (typeof space === 'string') {
                indent = space;
            }

// If there is a replacer, it must be a function or an array.
// Otherwise, throw an error.

            rep = replacer;
            if (replacer && typeof replacer !== 'function' &&
                    (typeof replacer !== 'object' ||
                    typeof replacer.length !== 'number')) {
                throw new Error('JSON.stringify');
            }

// Make a fake root object containing our value under the key of ''.
// Return the result of stringifying the value.

            return str('', {'': value});
        };
    }


// If the JSON object does not yet have a parse method, give it one.

    if (typeof JSON.parse !== 'function') {
        JSON.parse = function (text, reviver) {

// The parse method takes a text and an optional reviver function, and returns
// a JavaScript value if the text is a valid JSON text.

            var j;

            function walk(holder, key) {

// The walk method is used to recursively walk the resulting structure so
// that modifications can be made.

                var k, v, value = holder[key];
                if (value && typeof value === 'object') {
                    for (k in value) {
                        if (Object.prototype.hasOwnProperty.call(value, k)) {
                            v = walk(value, k);
                            if (v !== undefined) {
                                value[k] = v;
                            } else {
                                delete value[k];
                            }
                        }
                    }
                }
                return reviver.call(holder, key, value);
            }


// Parsing happens in four stages. In the first stage, we replace certain
// Unicode characters with escape sequences. JavaScript handles many characters
// incorrectly, either silently deleting them, or treating them as line endings.

            text = String(text);
            cx.lastIndex = 0;
            if (cx.test(text)) {
                text = text.replace(cx, function (a) {
                    return '\\u' +
                        ('0000' + a.charCodeAt(0).toString(16)).slice(-4);
                });
            }

// In the second stage, we run the text against regular expressions that look
// for non-JSON patterns. We are especially concerned with '()' and 'new'
// because they can cause invocation, and '=' because it can cause mutation.
// But just to be safe, we want to reject all unexpected forms.

// We split the second stage into 4 regexp operations in order to work around
// crippling inefficiencies in IE's and Safari's regexp engines. First we
// replace the JSON backslash pairs with '@' (a non-JSON character). Second, we
// replace all simple value tokens with ']' characters. Third, we delete all
// open brackets that follow a colon or comma or that begin the text. Finally,
// we look to see that the remaining characters are only whitespace or ']' or
// ',' or ':' or '{' or '}'. If that is so, then the text is safe for eval.

            if (/^[\],:{}\s]*$/
                    .test(text.replace(/\\(?:["\\\/bfnrt]|u[0-9a-fA-F]{4})/g, '@')
                        .replace(/"[^"\\\n\r]*"|true|false|null|-?\d+(?:\.\d*)?(?:[eE][+\-]?\d+)?/g, ']')
                        .replace(/(?:^|:|,)(?:\s*\[)+/g, ''))) {

// In the third stage we use the eval function to compile the text into a
// JavaScript structure. The '{' operator is subject to a syntactic ambiguity
// in JavaScript: it can begin a block or an object literal. We wrap the text
// in parens to eliminate the ambiguity.

                j = eval('(' + text + ')');

// In the optional fourth stage, we recursively walk the new structure, passing
// each name/value pair to a reviver function for possible transformation.

                return typeof reviver === 'function'
                    ? walk({'': j}, '')
                    : j;
            }

// If the text is not JSON parseable, then a SyntaxError is thrown.

            throw new SyntaxError('JSON.parse');
        };
    }
}());


;// webkit.js
if (typeof (Sys.Browser.WebKit) == "undefined") {
    Sys.Browser.WebKit = {};
}

if (navigator.userAgent.indexOf("WebKit/") > -1) {
    Sys.Browser.agent = Sys.Browser.WebKit;
    Sys.Browser.version = parseFloat(navigator.userAgent.match(/WebKit\/(\d+(\.\d+)?)/)[1]);
    Sys.Browser.name = "WebKit";
}


;// GoogleAnalytics/GoogleAnalyticsEvents.js
var GoogleAnalyticsEvents = {
    FireEvent: function(args) {
        if (window._gaq) {
            if (!window.GoogleAnalyticsDisableRoblox2) {
                var eventsArray = ["_trackEvent"];
                _gaq.push(eventsArray.concat(args));
            }
            var eventsArrayB = ["b._trackEvent"];
            _gaq.push(eventsArrayB.concat(args));
        }
    },
    ViewVirtual: function (url) {
        if (window.GoogleAnalyticsReplaceUrchinWithGAJS) {
            if (window._gaq) {
                !window.GoogleAnalyticsDisableRoblox2 && window._gaq.push(['_trackPageview', url]);
                window._gaq.push(['b._trackPageview', url]);
            }
        } else {
            urchinTracker && urchinTracker(url);
        }
    },
    TrackTransaction: function (orderId, priceTotal) {
        if (window._gaq) {
            if (!window.GoogleAnalyticsDisableRoblox2) {
                _gaq.push(['_addTrans',orderId, 'Roblox', priceTotal, '0', '0', 'San Mateo', 'California', 'USA']);
                                             // Store Name            Tax  Shipping
            }
            _gaq.push(['b._addTrans', orderId, 'Roblox', priceTotal, '0', '0', 'San Mateo', 'California', 'USA']);
        }
    },
    TrackTransactionItem: function (orderId, sku, name, category, price) {
        if (window._gaq) {
            if (!window.GoogleAnalyticsDisableRoblox2) {
                _gaq.push(['_addItem', sku, name, category, price, 1]);
                _gaq.push(['_trackTrans']);
            }
            _gaq.push(['b._addItem', sku, name, category, price, 1]);
            _gaq.push(['b._trackTrans']);
        }
    }
};

function GoogleAnalyticsTimingTracker(category, variable, optLabel, isDebug) {
    this.maxTime = 1 * 60 * 1000;
    this.category = category;
    this.variable = variable;
    this.label = optLabel ? optLabel : undefined;
    this.isDebug = isDebug;
}

GoogleAnalyticsTimingTracker.prototype.getTimeStamp = function() {
    if (window.performance && window.performance.now) {
        return Math.round(window.performance.now());
    }
    return new Date().getTime();
};

GoogleAnalyticsTimingTracker.prototype.start = function () {
    this.startTime = this.getTimeStamp();
};

GoogleAnalyticsTimingTracker.prototype.stop = function () {
    this.elapsedTime = this.getTimeStamp() - this.startTime;
};

/**
 * Send data to Google Analytics with the configured variable, action,
 * elapsed time and label. This function performs a check to ensure that
 * the elapsed time is greater than 0 and less than MAX_TIME. This check
 * ensures no bad data is sent if the browser client time is off. If
 * debug has been enebled, then the sample rate is overridden to 100%
 * and all the tracking parameters are outputted to the console.
 * @return {Object} This TrackTiming instance. Useful for chaining.
 */
GoogleAnalyticsTimingTracker.prototype.send = function () {
    if (0 < this.elapsedTime && this.elapsedTime < this.maxTime) {

        var command = ['b._trackTiming', this.category, this.variable, this.elapsedTime, this.label, 100];

        if (this.isDebug) {
            if (window.console && window.console.log) {
                console.log(command);
            }
        }

        window._gaq.push(command);
    }
};


;// MasterPageUI.js
// enable tipsy
$(function () {
    try {
        $('.tooltip').tipsy();
        $('.tooltip-top').tipsy({ gravity: 's' });
        $('.tooltip-right').tipsy({ gravity: 'w' });
        $('.tooltip-left').tipsy({ gravity: 'e' });
        $('.tooltip-bottom').tipsy({ gravity: 'n' });
    }
    catch(err) {
    }


    // <a disabled> anchor tags don't support disabled attributes in HTML5
    // Since this is in our master styleguide we just need to add the disabled property when we detect a disabled button
    $('a.btn-disabled-primary[disabled]').prop('disabled', true);

});

if (typeof Roblox === "undefined") {
    Roblox = {};
}

/* Roblox.FixedUI handles hiding iframe ads when conflicting with the fixed header, 
and unfixing the header when the window is resized or we are on mobile devices */
Roblox.FixedUI = function () {

    var ua = navigator.userAgent.toLowerCase(); /* unfix headers for iphone, mobile, android, blackberry or playbook devices */
    var isMobile = /mobile/i.test(ua) || /ipad/i.test(ua) || /iphone/i.test(ua) || /android/i.test(ua) || /playbook/i.test(ua) || /blackberry/i.test(ua);
    var usingNavigation2014;
    /* Run on load */
    $(function () {
        usingNavigation2014 = $('body').hasClass('layout-2014');
        if (isMobile) {
            setHeaderScrollState(false);
        }
        else {
            $(window).on('load resize', function checkIfFixed() {
                setHeaderScrollState(isWindowWiderThanThreshold());
            });
        }
    });


    /* Unfixing header for small windows */
    function setHeaderScrollState(setAsFixed) {
        var elements = ['.forceSpace', '#Container', '.mySubmenuFixed', '.site-header', '#MasterContainer', 'body', '#Footer', '.forceSpaceUnderSubmenu'];

        for (var i = 0; i < elements.length; i++) {
            if (setAsFixed || usingNavigation2014) $(elements[i]).removeClass('unfixed');
            else $(elements[i]).addClass('unfixed');
        }
    }

    function getWindowWidth() {
        var winW = 1024;
        if (document.body && document.body.offsetWidth) winW = document.body.offsetWidth; /* ie */
        if (window.innerWidth && window.innerHeight) winW = window.innerWidth; /* other browsers */
        return winW;
    }

    function isHeaderFixed() {
        return usingNavigation2014 || (!isMobile && isWindowWiderThanThreshold());
    }

    function isWindowWiderThanThreshold() {
        return getWindowWidth() >= 978;
    }



    /* Public interface */
    var my = {
        isMobile: isMobile,
        gutterAdsEnabled: false,
        isHeaderFixed: isHeaderFixed,
        getWindowWidth: getWindowWidth
    };
    return my;
} ();

;// jquery.cookie.js
/**
 * Cookie plugin
 *
 * Copyright (c) 2006 Klaus Hartl (stilbuero.de)
 * Dual licensed under the MIT and GPL licenses:
 * http://www.opensource.org/licenses/mit-license.php
 * http://www.gnu.org/licenses/gpl.html
 *
 */

/**
 * Create a cookie with the given name and value and other optional parameters.
 *
 * @example $.cookie('the_cookie', 'the_value');
 * @desc Set the value of a cookie.
 * @example $.cookie('the_cookie', 'the_value', { expires: 7, path: '/', domain: 'jquery.com', secure: true });
 * @desc Create a cookie with all available options.
 * @example $.cookie('the_cookie', 'the_value');
 * @desc Create a session cookie.
 * @example $.cookie('the_cookie', null);
 * @desc Delete a cookie by passing null as value. Keep in mind that you have to use the same path and domain
 *       used when the cookie was set.
 *
 * @param String name The name of the cookie.
 * @param String value The value of the cookie.
 * @param Object options An object literal containing key/value pairs to provide optional cookie attributes.
 * @option Number|Date expires Either an integer specifying the expiration date from now on in days or a Date object.
 *                             If a negative value is specified (e.g. a date in the past), the cookie will be deleted.
 *                             If set to null or omitted, the cookie will be a session cookie and will not be retained
 *                             when the the browser exits.
 * @option String path The value of the path atribute of the cookie (default: path of page that created the cookie).
 * @option String domain The value of the domain attribute of the cookie (default: domain of page that created the cookie).
 * @option Boolean secure If true, the secure attribute of the cookie will be set and the cookie transmission will
 *                        require a secure protocol (like HTTPS).
 * @type undefined
 *
 * @name $.cookie
 * @cat Plugins/Cookie
 * @author Klaus Hartl/klaus.hartl@stilbuero.de
 */

/**
 * Get the value of a cookie with the given name.
 *
 * @example $.cookie('the_cookie');
 * @desc Get the value of a cookie.
 *
 * @param String name The name of the cookie.
 * @return The value of the cookie.
 * @type String
 *
 * @name $.cookie
 * @cat Plugins/Cookie
 * @author Klaus Hartl/klaus.hartl@stilbuero.de
 */
jQuery.cookie = function(name, value, options) {
    if (typeof value != 'undefined') { // name and value given, set cookie
        options = options || {};
        if (value === null) {
            value = '';
            options.expires = -1;
        }
        var expires = '';
        if (options.expires && (typeof options.expires == 'number' || options.expires.toUTCString)) {
            var date;
            if (typeof options.expires == 'number') {
                date = new Date();
                date.setTime(date.getTime() + (options.expires * 24 * 60 * 60 * 1000));
            } else {
                date = options.expires;
            }
            expires = '; expires=' + date.toUTCString(); // use expires attribute, max-age is not supported by IE
        }
        // CAUTION: Needed to parenthesize options.path and options.domain
        // in the following expressions, otherwise they evaluate to undefined
        // in the packed version for some reason...
        var path = options.path ? '; path=' + (options.path) : '';
        var domain = options.domain ? '; domain=' + (options.domain) : '';
        var secure = options.secure ? '; secure' : '';
        document.cookie = [name, '=', encodeURIComponent(value), expires, path, domain, secure].join('');
    } else { // only name given, get cookie
        var cookieValue = null;
        if (document.cookie && document.cookie != '') {
            var cookies = document.cookie.split(';');
            for (var i = 0; i < cookies.length; i++) {
                var cookie = jQuery.trim(cookies[i]);
                // Does this cookie string begin with the name we want?
                if (cookie.substring(0, name.length + 1) == (name + '=')) {
                    cookieValue = decodeURIComponent(cookie.substring(name.length + 1));
                    break;
                }
            }
        }
        return cookieValue;
    }
};

;// jquery.jsoncookie.js
/** 
* JSON Cookie - jquery.jsoncookie.js
*
* Sets and retreives native JavaScript objects as cookies.
* Depends on the object serialization framework provided by JSON2.
*
* Dependencies: jQuery, jQuery Cookie, JSON2
* 
* @project JSON Cookie
* @author Randall Morey
* @version 0.9
*/

(function ($) {
    var isObject = function (x) {
        return (typeof x === 'object') && !(x instanceof Array) && (x !== null);
    };

    $.extend({
        getJSONCookie: function (cookieName, jsonFormat) {
            var cookieData = $.cookie(cookieName);
            if (jsonFormat)
                return cookieData;
            else
                return cookieData ? JSON.parse(cookieData) : {};
        },
        setJSONCookie: function (cookieName, data, options) {
            var cookieData = '';

            options = $.extend({
                expires: 90,
                path: '/'
            }, options);

            if (!isObject(data)) {	// data must be a true object to be serialized
                // Must be in JSON already...
                cookieData = data;
            }
            else {
                cookieData = JSON.stringify(data);
            }

            return $.cookie(cookieName, cookieData, options);
        },
        removeJSONCookie: function (cookieName) {
            return $.cookie(cookieName, null);
        },
        JSONCookie: function (cookieName, data, options) {
            if (data) {
                $.setJSONCookie(cookieName, data, options);
            }
            return $.getJSONCookie(cookieName);
        }
    });
})(jQuery);



function RobloxJSONCookie(name) {
    this._cookiename = name;
}

RobloxJSONCookie.prototype =
{
    Delete: function () {
        return ($.removeJSONCookie(this._cookiename));
    },
    SetObj: function (obj, options) {
        if (!options)
            options = { path: '/' };
        return $.JSONCookie(this._cookiename, obj, options);
    },
    SetJSON: function (json, options) {
        if (!options)
            options = { path: '/' };
        return $.JSONCookie(this._cookiename, json, options);
    },
    GetObj: function () {
        var obj = $.getJSONCookie(this._cookiename, false);
        if (obj == null)
            return new Object();
        else
            return obj;
    },
    GetJSON: function () {
        return $.getJSONCookie(this._cookiename, true);
    }
};

;// JSErrorTracker.js
if (typeof Roblox === 'undefined') {
    Roblox = {};
}

Roblox.JSErrorTracker = {
    showAlert: false,
    defaultPixel: 'GA',
    javascriptStackTraceEnabled: false,
    suppressConsoleError: false,
    data: { category: 'JavascriptExceptions' },

    initialize: function (args) {
        $.extend(Roblox.JSErrorTracker, args);
        this.addOnErrorEventHandler(this.errorHandler);
    },

    errorHandler: function (errMsg, errUrl, errLine, errCol, errObj) {
        try {
            var errInfo = "";
            if (errCol) {
                errInfo = " errCol = " + errCol;
            }
            if (errObj) {
                errInfo = " fileName = " + errObj.fileName + ",  stackTrace = " + JSON.stringify(errObj.stack);
            }
            Roblox.JSErrorTracker.data.msg = errMsg + errInfo;
            Roblox.JSErrorTracker.data.url = errUrl;
            Roblox.JSErrorTracker.data.line = errLine;
            Roblox.JSErrorTracker.data.ua = window.navigator.userAgent;
            Roblox.JSErrorTracker.logException(Roblox.JSErrorTracker.data);
        } catch (e) {
        }
        return Roblox.JSErrorTracker.suppressConsoleError;
    },

    addOnErrorEventHandler: function (fn) {
        var existingErrHandler = window.onerror;
        if (typeof window.onerror === 'function') {
            window.onerror = function (errMsg, errUrl, errLine, errCol, errObj) {
                existingErrHandler(errMsg, errUrl, errLine, errCol, errObj);
                fn(errMsg, errUrl, errLine, errCol, errObj);
            };
        } else {
            window.onerror = fn;
        }
    },

    processException: function (exDetails, pixelToFire) {
        if (typeof (exDetails) === 'undefined') {
            return;
        }
        if (typeof (exDetails.category) === 'undefined')
            exDetails.category = Roblox.JSErrorTracker.data.category;
        switch (pixelToFire) {
            case 'GA':
                var mapping = { category: 'category', url: 'action', msg: 'opt_label', line: 'opt_value' };
                Roblox.JSErrorTracker.fireGAPixel(Roblox.JSErrorTracker.distillGAData(exDetails, mapping));
                break;
            default:
                console.log("Roblox JSErrorTracker received an unknown pixel to fire");
                break;
        }
        return true;
    },

    logException: function (exDetails) {
        Roblox.JSErrorTracker.processException(exDetails, Roblox.JSErrorTracker.defaultPixel);
        Roblox.JSErrorTracker.showErrorMessage(exDetails.msg);
    },

    distillData: function (data, mapping) {
        var distilled = {};
        for (var datakey in mapping) {
            if (typeof data[datakey] !== 'undefined') {
                distilled[mapping[datakey]] = encodeURIComponent(data[datakey]);
            }
        }
        return distilled;
    },

    distillGAData: function (data, mapping) {
        var distilled = Roblox.JSErrorTracker.distillData(data, mapping);
        //Params for GA category, action, opt_label, opt_value
        var eventParams = [decodeURIComponent([distilled.category])];
        if (typeof (distilled.action) !== typeof (undefined)) {
            eventParams = eventParams.concat(decodeURIComponent(distilled.action));
            if (typeof (distilled.opt_label) !== typeof (undefined)) {
                eventParams = eventParams.concat(decodeURIComponent(distilled.opt_label));
                if (typeof (distilled.opt_value) !== typeof (undefined)) {
                    eventParams = eventParams.concat(parseInt(decodeURIComponent(distilled.opt_value)));
                }
            }
        } else {
            //action is a required field
            if (Roblox.JSErrorTracker.showAlert) {
                alert("Missing a required parameter for GA");
            }
        }
        return eventParams;
    },

    createURL: function (url, args, mapping) {
        var urlToFire = url;
        var distilled = Roblox.JSErrorTracker.distillData(args, mapping);
        urlToFire += "?";
        if (distilled != null) {
            for (var arg in distilled) {
                if (typeof (arg) != typeof (undefined) && args.hasOwnProperty(arg))
                    urlToFire += arg + "=" + distilled[arg] + "&";
            }
        }
        urlToFire = urlToFire.slice(0, urlToFire.length - 1);
        return urlToFire;
    },

    fireGAPixel: function (params) {
        if (typeof (_gaq) !== 'undefined') {
            _gaq.push(["c._trackEvent"].concat(params));
        }
    },

    showErrorMessage: function (msg) {
        if (Roblox.JSErrorTracker.showAlert) {
            if (msg !== null)
                alert(msg);
            else
                alert("An error occured");
        }
    }
};

;// RobloxEventManager.js
RobloxEventManager = new function () {
    var cookieStoreEvents = [];
    var dataStore = {};
    this.enabled = false;
    this.initialized = false;
    this.eventQueue = [];

    function getCookieValue(cookieName) {
        var regex = new RegExp(cookieName + '=([^;]*)');
        var match = regex.exec(document.cookie);

        if (match)
            return match[1];

        return null;
    }
    
    function parseDotNetCookie(cookieValue) {
        var cookieObject = {};
        var keyVals = cookieValue.split('&');
        for (var i = 0; i < keyVals.length; i++) {
            var keyVal = keyVals[i].split('=');
            cookieObject[keyVal[0]] = keyVal[1];
        }
        return cookieObject;
    }
    
    function getDotNetCookie(name) {
        var value = getCookieValue(name);
        if (value)
            return parseDotNetCookie(value);

        return null;
    }

    this.initialize = function (enabled) {
        this.initialized = true;
        this.enabled = enabled;
        while (this.eventQueue.length > 0) {
            var event = this.eventQueue.pop();
            this.triggerEvent(event.eventName, event.args);
        }
    };

    this.getMarketingGuid = function () {
        var c = getDotNetCookie('RBXEventTracker');
        if (c != null)
            return c['browserid'];
        return -1;
    };

    this.triggerEvent = function (eventName, args) {
        if (this.initialized) {
            if (this.enabled) {
                if (typeof args === 'undefined')
                    args = {};
                args.guid = this.getMarketingGuid();
                if (args.guid != -1)
                    $(document).trigger(eventName, [args]);
            }
        } else {
            this.eventQueue.push({ eventName: eventName, args: args });
        }
    };

    this.registerCookieStoreEvent = function (eventName) {
        cookieStoreEvents.push(eventName);
    };

    this.insertDataStoreKeyValuePair = function (key, value) {
        dataStore[key] = value;
    };

    this.monitorCookieStore = function () {
        try {
            if (typeof Roblox === "undefined" || typeof Roblox.Client === "undefined" || window.location.protocol == "https:")
                return;

            var plugin = Roblox.Client.CreateLauncher(false);
            if (plugin == null)
                return;

            for (var i = 0; i < cookieStoreEvents.length; i++) {
                try {
                    var eventName = cookieStoreEvents[i];
                    var storedValue = plugin.GetKeyValue(eventName);

                    if (storedValue != '' && storedValue != '-1' && storedValue != 'RBX_NOT_VALID') {
                        var args = eval('(' + storedValue + ')');   // has userId and placeId
                        args['userType'] = args['userId'] > 0 ? 'user' : 'guest';
                        RobloxEventManager.triggerEvent(eventName, args);
                        plugin.SetKeyValue(eventName, 'RBX_NOT_VALID');
                    }
                }
                catch (err) {

                }
            }
        }
        catch (err) {
            // If we update in the middle of checking cookies, let the monitor do the remaining cookies at the next interval
        }
    };

    this.startMonitor = function () {
        var interval, timeout, mouseHasMoved;
        function doTimeout() {
            if (mouseHasMoved)
                resetMouse();
            else
                stop();
        }
        function resetMouse() {
            clearTimeout(timeout);
            timeout = setTimeout(doTimeout, RobloxEventManager._idleInterval);
            mouseHasMoved = false;
            // Rebind mouse movement
            $(document).one("mousemove", function () {
                mouseHasMoved = true;
            });
        }
        function start() {
            // Monitor cookie store every 5 secs
            clearInterval(interval);
            interval = setInterval(RobloxEventManager.monitorCookieStore, 5000);
            // Set mouse movement
            resetMouse();
        }
        // Actually stop monitor
        function stop() {
            clearTimeout(timeout);
            clearInterval(interval);
            // Detach plugin
            var pluginObj = document.getElementById('robloxpluginobj');
            Roblox.Client.ReleaseLauncher(pluginObj, false, false);
            // Restart plugin when the mouse moves
            $(document).one("mousemove", start);
        }
        start();
    };
};

function RBXBaseEventListener() {

    if (!(this instanceof RBXBaseEventListener)) {
        return new RBXBaseEventListener();
    }

    this.init = function () {
        for (eventKey in this.events) {
            if (this.events.hasOwnProperty(eventKey)) {
                $(document).bind(this.events[eventKey], $.proxy(this.localCopy, this));
            }
        }
    };
    this.events = [];

    this.localCopy = function (event, data) {
        var localEvent = $.extend(true, {}, event);
        var localData = $.extend(true, {}, data);
        this.handleEvent(localEvent, localData);
    };
    /*
     * INTERFACE FUNCTIONS
     */
    this.distillData = function (data, mapping) {
        console.log('RBXEventListener distillData - Please implement me');
        return false;
    };
    this.handleEvent = function (event) {
        console.log('EventListener handleEvent - Please implement me');
        return false;
    };
    this.fireEvent = function (evtStr) {
        console.log('EventListener fireEvent - Please implement me');
        return false;
    };
}

;// RobloxEventListener.js
RobloxListener = new RBXBaseEventListener();
RobloxListener.handleEvent = function (event, data) {
    var rEvent, rData, dataMap;

    switch (event.type) {
        case 'rbx_evt_install_begin':
            dataMap = { guid: 'guid', userId: 'userid' };
            rEvent = event.type;
            break;
        case 'rbx_evt_initial_install_start':
            dataMap = { guid: 'guid', userId: 'userid' };
            rEvent = event.type;
            break;
        case 'rbx_evt_ftp':
            dataMap = { guid: 'guid', userId: 'userid' };
            rEvent = event.type;
            break;
        case 'rbx_evt_initial_install_success':
            dataMap = { guid: 'guid', userId: 'userid' };
            rEvent = event.type;
            break;
        case 'rbx_evt_fmp':
            dataMap = { guid: 'guid', userId: 'userid' };
            rEvent = event.type;
            break;
        default:
            console.log('RobloxEventListener - Event registered without handling instructions: ' + event.type);
            return false;
    }

    rData = this.distillData(data, dataMap);
    this.fireEvent(this.eventToString(rEvent, rData));
    return true;
}

RobloxListener.distillData = function (data, mapping) {
    var distilled = {};
    for (dataKey in mapping) {
        if (typeof (data[dataKey]) != typeof (undefined))
            distilled[mapping[dataKey]] = encodeURIComponent(data[dataKey]);
    }

    return distilled;
}
RobloxListener.eventToString = function (event, args) {
    var eventString = RobloxListener.restUrl;
    eventString += "?event=" + event + "&";
    if (args != null) {
        for (arg in args) {
            if (typeof (arg) != typeof (undefined) && args.hasOwnProperty(arg))
                eventString += arg + "=" + args[arg] + "&";
        }
    }
    eventString = eventString.slice(0, eventString.length - 1);
    return eventString;
}
RobloxListener.fireEvent = function (processedEvent) {
    var trPixel = $('<img width="1" height="1" src="' + processedEvent + '"/>');
}
RobloxListener.events = []; // Don't listen for any events. Cleanup file by 2014/5/31

;// GoogleEventListener.js
GoogleListener = new RBXBaseEventListener();
GoogleListener.handleEvent = function (event, data) {
    function translateOsString(str) {
        str = str.toLowerCase();
        if (str == "win32")
            str = "Windows";
        else if (str == "osx")
            str = "Mac";
        return str;
    }

    var gEvent, gData, dataMap;

    switch (event.type) {
        case 'rbx_evt_initial_install_begin':
            data['os'] = translateOsString(data['os']);
            data['category'] = 'Bootstrapper Install Begin';
            dataMap = { os: 'action' };
            break;
        case 'rbx_evt_ftp':
            data['os'] = translateOsString(data['os']);
            data['category'] = 'First Time Played';
            dataMap = { os: 'action' };
            break;
        case 'rbx_evt_initial_install_success':
            data['os'] = translateOsString(data['os']);
            data['category'] = 'Bootstrapper Install Success';
            dataMap = { os: 'action' };
            break;
        case 'rbx_evt_fmp':
            data['os'] = translateOsString(data['os']);
            data['category'] = 'Five Minute Play';
            dataMap = { os: 'action' };
            break;
        case 'rbx_evt_abtest':
            dataMap = { experiment: 'category', variation: 'action', version: 'opt_label' };
            break;
        case 'rbx_evt_card_redemption':
            data['category'] = "CardRedemption";
            dataMap = { merchant: 'action', cardValue: 'opt_label' };
            break;
        default:
            console.log('GoogleListener - Event registered without handling instructions: ' + event.type);
            return false;
    }

    dataMap['category'] = 'category';

    gData = this.distillData(data, dataMap);
    this.fireEvent(gData);
    return true;
}

GoogleListener.distillData = function (data, mapping) {
    var distilled = {};
    for (dataKey in mapping) {
        if (typeof (data[dataKey]) != typeof (undefined))
            distilled[mapping[dataKey]] = data[dataKey];
    }
    var eventParams = [distilled['category'], distilled['action']];
    if (distilled['opt_label'] != null) {
        eventParams = eventParams.concat(distilled['opt_label']);
    }
    if (distilled['opt_value'] != null) {
        eventParams = eventParams.concat(distilled['opt_value']);
    }

    return eventParams;
}
GoogleListener.fireEvent = function (processedEvent) {
    if (typeof (_gaq) != typeof (undefined)) {
        var eventsArray = ["_trackEvent"];
        var eventsArrayB = ["b._trackEvent"];
        _gaq.push(eventsArray.concat(processedEvent));
        _gaq.push(eventsArrayB.concat(processedEvent));
    }
}
GoogleListener.events = [
    'rbx_evt_initial_install_begin',
    'rbx_evt_ftp',
    'rbx_evt_initial_install_success',
    'rbx_evt_fmp',
    'rbx_evt_abtest',
    'rbx_evt_card_redemption'
];

;// MongoEventListener.js
MongoListener = new RBXBaseEventListener();

MongoListener.handleEvent = function (event, data) {

    var shard;
    if (typeof data["shard"] === "undefined") {
        shard = this.defaultShard;
    } else {
        shard = data["shard"];
    }

    if (typeof data["eventName"] === "undefined") {
        data.eventName = event.type;
    }

    if (data.eventName === "JavascriptExceptionLoggingEvent") {
        dataMap = { category: 'category', url: 'url', msg: 'msg', line: 'line', ua: 'UA' };
    } else {
        if (typeof data["category"] === "undefined") {
            data.category = MongoListener.getCategoryFromEventName(data.eventName);
        }
        data.userId = MongoListener.userId;
        data.ip = MongoListener.clientIpAddress;
        dataMap = { guid: 'guid', category: 'category', userId: 'userid', ip: 'ip' };

        /* // don't send age and gender up, for now.  maybe a UserInfo event later?
        if (typeof data.age !== 'undefined') {
            dataMap.age = 'age';
        }

        if (typeof data.gender !== 'undefined') {
            dataMap.gender = 'gender';
        }
        */
    }

    this.fireEvent(shard, this.distillData(data, dataMap));

    return true;
}
MongoListener.getCategoryFromEventName = function (eventName) {
    switch (eventName) {
        case 'rbx_evt_sitetouch':
            return 'SiteTouch';
        case 'rbx_evt_fmp':
            return 'FiveMinutePlay';
        case 'rbx_evt_play_user':
        case 'rbx_evt_play_guest':
            return 'Play';
        default:
            return eventName;
    }
}

MongoListener.distillData = function (data, mapping) {
    var distilled = {};
    for (dataKey in mapping) {
        if (typeof (data[dataKey]) != typeof (undefined))
            distilled[mapping[dataKey]] = encodeURIComponent(data[dataKey]);
    }

    return distilled;
}
MongoListener.fireEvent = function (shard, data) {
   	$.ajax({ url: MongoListener.loggingURI + shard,
   		dataType: "jsonp",
   		jsonpCallback: "MongoListener.callback",
   		data: data
   	});
}
MongoListener.callback = function (obj) {
//console.log goes here.
}
MongoListener.events = [
    'JavascriptExceptionLoggingEvent'
    /*, 'rbx_evt_fmp'
    , 'rbx_evt_play_user'
    , 'rbx_evt_play_guest'
    , 'rbx_evt_sitetouch'*/
];


;// SiteTouchEvent.js
if (typeof Roblox == "undefined") {
    Roblox = {};
}

Roblox.SiteTouchEvent = (function () {
    var key = 'LastActivity';

    function getLastActivity() {
        if (localStorage == null) return new Date(0);
        var lastActivity;
        if (typeof localStorage != "undefined") {
            // assume localStorage is available (IE >= 8, and modern browsers)
            lastActivity = localStorage.getItem(key);
        }
        if (typeof lastActivity == "undefined" || lastActivity === null) {
            // get from cookie
            lastActivity = $.cookie(key);
        }
        var lastActivityTicks = Date.parse(lastActivity);
        if (lastActivity && !isNaN(lastActivityTicks)) {
            return new Date(lastActivityTicks);
        }
        else {
            // no value found, definitely fire an event
            return new Date(0); // Jan 1 1970 00:00:00 GMT
        }
    }

    function setLastActivity(lastActivity) {
        if (localStorage == null) return;
        if (typeof lastActivity == "undefined") {
            lastActivity = new Date(); // default to current date
        }
        // clear the unused storage location, in case we have switched locations
        if (typeof localStorage != "undefined") {
            if (my.useLocalStorage) {
                $.cookie(key, null);
            }
            else {
                localStorage.removeItem(key);
            }
        }
        // write the data
        if (my.useLocalStorage && typeof localStorage != "undefined") {
            // assume localStorage is available (IE >= 8, and modern browsers)
            localStorage.setItem(key, lastActivity);
        }
        else {
            // store in cookie
            $.cookie(key, lastActivity, { expires: 100 }); // 100 days
        }
    }

    function updateLastActivityAndFireEvent() {
        var lastActivity = getLastActivity();
        // 3600000ms = 1 hr
        if (Math.floor(((new Date()) - lastActivity) / 3600000) >= my.dateDiffThresholdInHours) {
            // send an event
            RobloxEventManager.triggerEvent('rbx_evt_sitetouch');
        }
        setLastActivity();
    }

    var my = {
        updateLastActivityAndFireEvent: updateLastActivityAndFireEvent,
        getLastActivity: getLastActivity,
        setLastActivity: setLastActivity,
        dateDiffThresholdInHours: 3,
        useLocalStorage: false
    };

    return my;
})();

;// XsrfToken.js
//If modifying this file, please also modify the corresponding files in the admin and cs sites.

if (typeof Roblox == "undefined") {
    Roblox = {};
}

Roblox.XsrfToken = (function () {
    var xsrfRequestMethods = ["POST", "PUT", "DELETE", "PATCH"];
    var currentToken = "";
    var csrfTokenHeader = "X-CSRF-TOKEN";
    var csrfInvalidResponseCode = 403;

    $(document).ajaxSend(function (event, jqxhr, settings) {
        // Send CSRF if in our own domain and is a method that requires it
        if (currentToken !== "" && xsrfRequestMethods.indexOf(settings.type.toUpperCase()) >= 0) {
            jqxhr.setRequestHeader("X-CSRF-TOKEN", currentToken);
        }
    });

    $.ajaxPrefilter(function (options, originalOptions, jqxhr) {
        if (options.dataType == "jsonp" || options.dataType == "script") {
            // these are most likely remote requests, don't set an error handler
            return;
        }

        // If current token == "" then CSRF protection is disabled on server
        if (currentToken !== "") {
            // save the original error callback for later
            if (originalOptions.error) { 
                originalOptions._error = originalOptions.error;
            }
            // overwrite *current request* error callback
            options.error = $.noop();

            var dfd = $.Deferred();
            // if the request works, return normally
            jqxhr.done(dfd.resolve);

            // if the request fails, do something else, yet still resolve
            jqxhr.fail(function () {
                var args = Array.prototype.slice.call(arguments);
                if (jqxhr.status == csrfInvalidResponseCode && jqxhr.getResponseHeader(csrfTokenHeader) != null) {
                    // this was a token failure, reissue the XHR with the returned token
                    var newToken = jqxhr.getResponseHeader(csrfTokenHeader);

                    if (newToken == null) {
                        dfd.rejectWith(jqxhr, args);
                        return;
                    }
                    currentToken = newToken;

                    $.ajax(originalOptions).then(dfd.resolve, dfd.reject);
                }
                else {
                    // add our _error callback to our promise object
                    if (originalOptions._error) { 
                        dfd.fail(originalOptions._error);
                    }
                    dfd.rejectWith(jqxhr, args);
                }
            });

            // NOW override the jqXHR's promise functions with our deferred
            return dfd.promise(jqxhr)
        }
    });

    function setToken(token) {
        currentToken = token;
    }

    function getToken() {
        return currentToken;
    }

    var my = {
        setToken: setToken,
        getToken: getToken,
    };

    return my;
})();

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


;// parentFrameLogin.js
$(function () {
    var loginPaneOpened = false;

    $('#header-login').click(function (evt) {
        loginPaneOpened = !loginPaneOpened;
        //Hide the Ad
        hideHeaderAd(loginPaneOpened);
        $('#iFrameLogin').toggle();
        $('#header-login').toggleClass('active');
        evt.stopPropagation();
        return false;
    });
    $('#headerLogin').click(function (evt) {
        loginPaneOpened = !loginPaneOpened;
        //Hide the Ad
        hideHeaderAd(loginPaneOpened);
        $('#iFrameLogin').toggle();
        $('#headerLogin').toggleClass('active');
        evt.stopPropagation();
        return false;
    });

    $(document).click(function (evt) {
        if (loginPaneOpened) {
            $('#header-login').removeClass('active');
            $('#headerLogin').removeClass('active');
            $('#iFrameLogin').hide();
            loginPaneOpened = false;
        }
    });

    var hideHeaderAd = function (mode) {
        $(".IframeAdHide").each(function () {
            //Hide only header.
            if ($(this).height() == 90 && $(this).width() == 728) {
                if (mode)
                    $(this).css('visibility', 'hidden');
                else
                    $(this).css('visibility', 'visible');
            }
        });
    };

    var ParseMessage = function (msg) {
        if (msg.indexOf("resize") != -1) {
            //msg = "resize,270px"
            var args = msg.split(',');
            $('#iFrameLogin').css({ 'height': args[1] });
        }
        if (msg.indexOf("fbRegister") != -1) {
            var args = msg.split('^');
            var qs = "&fbname=" + encodeURIComponent(args[1]) + "&fbem=" + encodeURIComponent(args[2]) + "&fbdt=" + encodeURIComponent(args[3]);
            window.location.href = "../Login/Default.aspx?iFrameFacebookSync=true" + qs;
        }
    };

    $.receiveMessage(function (e) {
        ParseMessage(e.data);
    });

    //show the login iFrame if the optional parameter exists
    if ($('#header-login-wrapper').data('display-opened') == "True") {
        $('#header-login').addClass('active');
        $('#iFrameLogin').css('display', 'block');
    }
});

;// DropDownNav.js
;// DropDownNav.js
typeof Roblox=="undefined"&&(Roblox={}),(Roblox.DropDownNav=function(){function i(n){var i=$(n.target),f,u;i.attr("drop-down-nav-button")||(i=i.parents("[drop-down-nav-button]")),i.addClass("active"),f=i.attr("drop-down-nav-button"),u=t.filter('[drop-down-nav-container="'+f+'"]'),u.show(),t.not(u).hide(),r.not(i).removeClass("active"),n.stopPropagation(),i.trigger("showDropDown")}function u(n){$("[drop-down-nav-button]").unbind("click",f),i(n),$("[drop-down-nav-button]").bind("mouseleave",e)}function e(){n(),$("[drop-down-nav-button]").unbind("mouseleave",e)}function f(t){$("[drop-down-nav-button]").unbind("mouseenter",u),i(t),$(document).bind("click",function(){n()}),$("[drop-down-nav-button]").bind("click",o)}function o(){$(document).unbind("click",function(){n()}),n(),$("[drop-down-nav-button]").bind("click",i)}function n(){t.hide(),r.removeClass("active")}var t,r;$(function(){t=$("[drop-down-nav-container]"),r=$("[drop-down-nav-button]"),$("[drop-down-nav-button]").bind("click",f),$("[drop-down-nav-button]").bind("mouseenter",u)})})();
/*;(function () {
    //by convention, all dropdownNav styling should use the class 'active'
    //apply attr 'data-drop-down-nav-container' to the container
    //apply attr 'drop-down-nav-button' to the button
    //this module will run it's self; also note it works for click and hover
    var dropDownNavContainers;
    var dropDownNavButtons;
      
    $(function() {
        dropDownNavContainers = $('[data-drop-down-nav-container]');
        dropDownNavButtons = $('[drop-down-nav-button]');
        
        $('[drop-down-nav-button]').bind('click', openDropDownNavClick);
        $('[drop-down-nav-button]').bind('mouseenter', openDropDownNavHover);
    });

    function showDropDownNav(event) {
        var clicked = $(event.target);
        if (!clicked.attr('drop-down-nav-button')) {
            clicked = clicked.parents('[drop-down-nav-button]');
        }
        clicked.addClass('active');
        var navName = clicked.attr('drop-down-nav-button');
        var navcontainer = dropDownNavContainers.filter('[data-drop-down-nav-container="' + navName + '"]');
        navcontainer.show();
        dropDownNavContainers.not(navcontainer).hide();
        dropDownNavButtons.not(clicked).removeClass('active');
        event.stopPropagation();
        clicked.trigger('showDropDown');
        
    }
    function openDropDownNavHover(event) {
        $('[drop-down-nav-button]').unbind('click', openDropDownNavClick);
        showDropDownNav(event);
        $('[drop-down-nav-button]').bind('mouseleave', closeDropDownNavHover);
    }
    function closeDropDownNavHover() {
        hideDropDownNavs();
        $('[drop-down-nav-button]').unbind('mouseleave', closeDropDownNavHover);
    }
    
    function openDropDownNavClick(event) {
        $('[drop-down-nav-button]').unbind('mouseenter', openDropDownNavHover);
        showDropDownNav(event);
        $(document).bind('click', function(event) {
            hideDropDownNavs();
        });
        $('[drop-down-nav-button]').bind('click', closeDropDownNavClick);
    }
    function closeDropDownNavClick() {
        $(document).unbind('click', function(event) {
            hideDropDownNavs();
        });
        hideDropDownNavs();
        $('[drop-down-nav-button]').bind('click', showDropDownNav);
    }

    function hideDropDownNavs() {
        dropDownNavContainers.hide();
        dropDownNavButtons.removeClass('active');
    }
})();*/

;// UpsellAdModal.js
Roblox = Roblox || {};

if (typeof Roblox.UpsellAdModal === "undefined") {
    Roblox.UpsellAdModal = function() {
        var open = function() {
            var options = {
                titleText: Roblox.UpsellAdModal.Resources.title,
                bodyContent: Roblox.UpsellAdModal.Resources.body,
                footerText: "",
                overlayClose: true,
                escClose: true,
                acceptText: Roblox.UpsellAdModal.Resources.accept,
                declineText: Roblox.UpsellAdModal.Resources.decline,
                acceptColor: Roblox.GenericConfirmation.green,
                onAccept: function () { window.location.href = '/premium/membership'; },
                imageUrl: '/images/BuildersClub-110x110_small.png'
            };

            Roblox.GenericConfirmation.open(
                options
            );
        };

        return {
            open: open
        };
    } ();
}

$(function () {
    $('a.UpsellAdButton').click(function () {
        Roblox.UpsellAdModal.open();
        return false;
    });
});
