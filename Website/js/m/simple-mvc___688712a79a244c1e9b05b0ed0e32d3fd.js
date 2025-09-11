;// bundle: simple-mvc___688712a79a244c1e9b05b0ed0e32d3fd
;// files: RobloxEventManager.js, jquery.simplemodal-1.3.5.js, jquery.cookies.2.2.0.1.js, jquery.cookie.js, jquery.jsoncookie.js, jquery.json-2.2.js, parentFrameLogin.js, RobloxEventListener.js, GoogleEventListener.js, MongoEventListener.js, SiteTouchEvent.js, JSErrorTracker.js

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

;// jquery.cookies.2.2.0.1.js
/**
* Copyright (c) 2005 - 2010, James Auldridge
* All rights reserved.
*
* Licensed under the BSD, MIT, and GPL (your choice!) Licenses:
*  http://code.google.com/p/cookies/wiki/License
*
*/
var jaaulde = window.jaaulde || {};
jaaulde.utils = jaaulde.utils || {};
jaaulde.utils.cookies = (function() {
    var resolveOptions, assembleOptionsString, parseCookies, constructor, defaultOptions = {
        expiresAt: null,
        path: '/',
        domain: null,
        secure: false
    };
    /**
    * resolveOptions - receive an options object and ensure all options are present and valid, replacing with defaults where necessary
    *
    * @access private
    * @static
    * @parameter Object options - optional options to start with
    * @return Object complete and valid options object
    */
    resolveOptions = function(options) {
        var returnValue, expireDate;

        if (typeof options !== 'object' || options === null) {
            returnValue = defaultOptions;
        }
        else {
            returnValue = {
                expiresAt: defaultOptions.expiresAt,
                path: defaultOptions.path,
                domain: defaultOptions.domain,
                secure: defaultOptions.secure
            };

            if (typeof options.expiresAt === 'object' && options.expiresAt instanceof Date) {
                returnValue.expiresAt = options.expiresAt;
            }
            else if (typeof options.hoursToLive === 'number' && options.hoursToLive !== 0) {
                expireDate = new Date();
                expireDate.setTime(expireDate.getTime() + (options.hoursToLive * 60 * 60 * 1000));
                returnValue.expiresAt = expireDate;
            }

            if (typeof options.path === 'string' && options.path !== '') {
                returnValue.path = options.path;
            }

            if (typeof options.domain === 'string' && options.domain !== '') {
                returnValue.domain = options.domain;
            }

            if (options.secure === true) {
                returnValue.secure = options.secure;
            }
        }

        return returnValue;
    };
    /**
    * assembleOptionsString - analyze options and assemble appropriate string for setting a cookie with those options
    *
    * @access private
    * @static
    * @parameter options OBJECT - optional options to start with
    * @return STRING - complete and valid cookie setting options
    */
    assembleOptionsString = function(options) {
        options = resolveOptions(options);

        return (
                        (typeof options.expiresAt === 'object' && options.expiresAt instanceof Date ? '; expires=' + options.expiresAt.toGMTString() : '') +
                        '; path=' + options.path +
                        (typeof options.domain === 'string' ? '; domain=' + options.domain : '') +
                        (options.secure === true ? '; secure' : '')
                );
    };
    /**
    * parseCookies - retrieve document.cookie string and break it into a hash with values decoded and unserialized
    *
    * @access private
    * @static
    * @return OBJECT - hash of cookies from document.cookie
    */
    parseCookies = function() {
        var cookies = {}, i, pair, name, value, separated = document.cookie.split(';'), unparsedValue;
        for (i = 0; i < separated.length; i = i + 1) {
            pair = separated[i].split('=');
            name = pair[0].replace(/^\s*/, '').replace(/\s*$/, '');

            try {
                value = decodeURIComponent(pair[1]);
            }
            catch (e1) {
                value = pair[1];
            }

            if (typeof JSON === 'object' && JSON !== null && typeof JSON.parse === 'function') {
                try {
                    unparsedValue = value;
                    value = JSON.parse(value);
                }
                catch (e2) {
                    value = unparsedValue;
                }
            }

            cookies[name] = value;
        }
        return cookies;
    };

    constructor = function() { };

    /**
    * get - get one, several, or all cookies
    *
    * @access public
    * @paramater Mixed cookieName - String:name of single cookie; Array:list of multiple cookie names; Void (no param):if you want all cookies
    * @return Mixed - Value of cookie as set; Null:if only one cookie is requested and is not found; Object:hash of multiple or all cookies (if multiple or all requested);
    */
    constructor.prototype.get = function(cookieName) {
        var returnValue, item, cookies = parseCookies();

        if (typeof cookieName === 'string') {
            returnValue = (typeof cookies[cookieName] !== 'undefined') ? cookies[cookieName] : null;
        }
        else if (typeof cookieName === 'object' && cookieName !== null) {
            returnValue = {};
            for (item in cookieName) {
                if (typeof cookies[cookieName[item]] !== 'undefined') {
                    returnValue[cookieName[item]] = cookies[cookieName[item]];
                }
                else {
                    returnValue[cookieName[item]] = null;
                }
            }
        }
        else {
            returnValue = cookies;
        }

        return returnValue;
    };
    /**
    * filter - get array of cookies whose names match the provided RegExp
    *
    * @access public
    * @paramater Object RegExp - The regular expression to match against cookie names
    * @return Mixed - Object:hash of cookies whose names match the RegExp
    */
    constructor.prototype.filter = function(cookieNameRegExp) {
        var cookieName, returnValue = {}, cookies = parseCookies();

        if (typeof cookieNameRegExp === 'string') {
            cookieNameRegExp = new RegExp(cookieNameRegExp);
        }

        for (cookieName in cookies) {
            if (cookieName.match(cookieNameRegExp)) {
                returnValue[cookieName] = cookies[cookieName];
            }
        }

        return returnValue;
    };
    /**
    * set - set or delete a cookie with desired options
    *
    * @access public
    * @paramater String cookieName - name of cookie to set
    * @paramater Mixed value - Any JS value. If not a string, will be JSON encoded; NULL to delete
    * @paramater Object options - optional list of cookie options to specify
    * @return void
    */
    constructor.prototype.set = function(cookieName, value, options) {
        if (typeof options !== 'object' || options === null) {
            options = {};
        }


        if (typeof value === 'undefined' || value === null) {
            value = '';
            options.hoursToLive = -8760;
        }

        else if (typeof value !== 'string') {
            if (typeof JSON === 'object' && JSON !== null && typeof JSON.stringify === 'function') {
                value = JSON.stringify(value);
            }
            else {
                throw new Error('cookies.set() received non-string value and could not serialize.');
            }
        }


        var optionsString = assembleOptionsString(options);

        document.cookie = cookieName + '=' + encodeURIComponent(value) + optionsString;
    };
    /**
    * del - delete a cookie (domain and path options must match those with which the cookie was set; this is really an alias for set() with parameters simplified for this use)
    *
    * @access public
    * @paramater MIxed cookieName - String name of cookie to delete, or Bool true to delete all
    * @paramater Object options - optional list of cookie options to specify ( path, domain )
    * @return void
    */
    constructor.prototype.del = function(cookieName, options) {
        var allCookies = {}, name;

        if (typeof options !== 'object' || options === null) {
            options = {};
        }

        if (typeof cookieName === 'boolean' && cookieName === true) {
            allCookies = this.get();
        }
        else if (typeof cookieName === 'string') {
            allCookies[cookieName] = true;
        }

        for (name in allCookies) {
            if (typeof name === 'string' && name !== '') {
                this.set(name, null, options);
            }
        }
    };
    /**
    * test - test whether the browser is accepting cookies
    *
    * @access public
    * @return Boolean
    */
    constructor.prototype.test = function() {
        var returnValue = false, testName = 'cT', testValue = 'data';

        this.set(testName, testValue);

        if (this.get(testName) === testValue) {
            this.del(testName);
            returnValue = true;
        }

        return returnValue;
    };
    /**
    * setOptions - set default options for calls to cookie methods
    *
    * @access public
    * @param Object options - list of cookie options to specify
    * @return void
    */
    constructor.prototype.setOptions = function(options) {
        if (typeof options !== 'object') {
            options = null;
        }

        defaultOptions = resolveOptions(options);
    };

    return new constructor();
})();

(function() {
    if (window.jQuery) {
        (function($) {
            $.cookies = jaaulde.utils.cookies;

            var extensions = {
                /**
                * $( 'selector' ).cookify - set the value of an input field, or the innerHTML of an element, to a cookie by the name or id of the field or element
                *                           (field or element MUST have name or id attribute)
                *
                * @access public
                * @param options OBJECT - list of cookie options to specify
                * @return jQuery
                */
                cookify: function(options) {
                    return this.each(function() {
                        var i, nameAttrs = ['name', 'id'], name, $this = $(this), value;

                        for (i in nameAttrs) {
                            if (!isNaN(i)) {
                                name = $this.attr(nameAttrs[i]);
                                if (typeof name === 'string' && name !== '') {
                                    if ($this.is(':checkbox, :radio')) {
                                        if ($this.attr('checked')) {
                                            value = $this.val();
                                        }
                                    }
                                    else if ($this.is(':input')) {
                                        value = $this.val();
                                    }
                                    else {
                                        value = $this.html();
                                    }

                                    if (typeof value !== 'string' || value === '') {
                                        value = null;
                                    }

                                    $.cookies.set(name, value, options);

                                    break;
                                }
                            }
                        }
                    });
                },
                /**
                * $( 'selector' ).cookieFill - set the value of an input field or the innerHTML of an element from a cookie by the name or id of the field or element
                *
                * @access public
                * @return jQuery
                */
                cookieFill: function() {
                    return this.each(function() {
                        var n, getN, nameAttrs = ['name', 'id'], name, $this = $(this), value;

                        getN = function() {
                            n = nameAttrs.pop();
                            return !!n;
                        };

                        while (getN()) {
                            name = $this.attr(n);
                            if (typeof name === 'string' && name !== '') {
                                value = $.cookies.get(name);
                                if (value !== null) {
                                    if ($this.is(':checkbox, :radio')) {
                                        if ($this.val() === value) {
                                            $this.attr('checked', 'checked');
                                        }
                                        else {
                                            $this.removeAttr('checked');
                                        }
                                    }
                                    else if ($this.is(':input')) {
                                        $this.val(value);
                                    }
                                    else {
                                        $this.html(value);
                                    }
                                }

                                break;
                            }
                        }
                    });
                },
                /**
                * $( 'selector' ).cookieBind - call cookie fill on matching elements, and bind their change events to cookify()
                *
                * @access public
                * @param options OBJECT - list of cookie options to specify
                * @return jQuery
                */
                cookieBind: function(options) {
                    return this.each(function() {
                        var $this = $(this);
                        $this.cookieFill().change(function() {
                            $this.cookify(options);
                        });
                    });
                }
            };


            $.each(extensions, function(i) {
                $.fn[i] = this;
            });

        })(window.jQuery);
    }
})();


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
