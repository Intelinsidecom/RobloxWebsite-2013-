;// bundle: page___14520e545378978c39f94d77453b0cd0
;// files: SignupFormValidatorGeneric.old.js, Landing/BlueCity/AnimatedSignupFormValidator.js, Landing/BlueCity/AnimatedLoginFormValidator.js, FormValidator.js, CaptchaModal.js, Landing/BlueCity/Animation.js, Landing/BlueCity/Animated.js

;// SignupFormValidatorGeneric.old.js
typeof Roblox == "undefined" && (Roblox = {}), Roblox.SignupFormValidatorGeneric = function() {
    function a(n, t, i) {
        return i <= 0 || n <= 0 || t <= 0 || t > new Date(i, n, 0).getDate()
    }

    function v(n, t, i) {
        return i != 0 && n != 0 && t != 0
    }

    function c(n, t) {
        return $(n).length != 0 || $(t).length != 0
    }

    function l(n) {
        return n.length > 20
    }

    function y(n) {
        return n.length < 3
    }

    function b(n) {
        return !n.match(/^[a-zA-Z0-9]*$/)
    }

    function k(n) {
        var i = function(n) {
                return n.data == 1 ? 1 : n.data == 2 ? 2 : n.data == 0 ? 0 : void 0
            },
            t = function() {};
        $.ajax({
            type: "GET",
            url: "/UserCheck/checkifinvalidusernameforsignup?username=" + n,
            success: i,
            error: t
        })
    }

    function p(n, t) {
        return t == "" || n.length > 0 && t != "" && n == t
    }

    function w(n) {
        return n.length > 20
    }

    function h(n) {
        return n.length < 6
    }

    function i(n) {
        return s(n) > 3
    }

    function r(n) {
        return f(n) > 1
    }

    function n(n) {
        return o(n) > 0
    }

    function t(n, t) {
        return n == t
    }

    function u(n) {
        return (n = n.toLowerCase(), n.indexOf("asdf") > -1) ? !0 : n.indexOf("pass") > -1 || n.indexOf("qwer") > -1 || n.indexOf("zxcv") > -1 || n.indexOf("aaaa") > -1 || n.indexOf("zzzz") > -1 ? !0 : !1
    }

    function o(n) {
        var r = /^\s$/,
            i = 0,
            t;
        if (n == null || n == "") return 0;
        for (t = 0; t < n.length; t++) n.charAt(t).match(r) && (i += 1);
        return i
    }

    function s(n) {
        var r = /^[A-Za-z]$/,
            i = 0,
            t;
        if (n == null || n == "") return 0;
        for (t = 0; t < n.length; t++) n.charAt(t).match(r) && (i += 1);
        return i
    }

    function f(n) {
        var r = /^[0-9]$/,
            i = 0,
            t;
        if (n == null || n == "") return 0;
        for (t = 0; t < n.length; t++) n.charAt(t).match(r) && (i += 1);
        return i
    }
    return {
        invalidBirthday: a,
        selectedBirthday: v,
        genderSelected: c,
        usernameTooLong: l,
        usernameTooShort: y,
        usernameRegexInvalid: b,
        usernameInvalid: k,
        passwordTooLong: w,
        passwordTooShort: h,
        passwordEnoughLetters: i,
        passwordEnoughNumbers: r,
        passwordContainsSpaces: n,
        passwordIsUsername: t,
        passwordsMatch: p,
        weakPassword: u
    }
}();

;// Landing/BlueCity/AnimatedSignupFormValidator.js
typeof Roblox == "undefined" && (Roblox = {}), Roblox.AnimatedSignupFormValidator = function() {
    function r(n) {
        var r = parseInt($("#lstMonths option:selected").val()),
            i = parseInt($("#lstDays option:selected").val()),
            t = parseInt($("#lstYears option:selected").val());
        return Roblox.SignupFormValidatorGeneric.invalidBirthday(r, i, t) ? (n && (Roblox.SignupFormValidatorGeneric.selectedBirthday(r, i, t) ? $("#birthdayError").html(Roblox.Resources.AnimatedSignupFormValidator.invalidBirthday) : $("#birthdayError").html(Roblox.Resources.AnimatedSignupFormValidator.requiredField), $("#birthdayError").show(), $("#birthdayText").addClass("error"), $("#birthdayGood").hide()), !1) : ($("#birthdayGood").show(), $("#birthdayError").hide(), $("#birthdayText").removeClass("error"), !0)
    }

    function i() {
        var t = $("#MaleBtn:checked"),
            n = $("#FemaleBtn:checked");
        return Roblox.SignupFormValidatorGeneric.genderSelected(t, n) ? ($("#genderGood").show(), $("#genderError").hide(), $("#genderText").removeClass("error"), !0) : ($("#genderError").text(Roblox.Resources.AnimatedSignupFormValidator.requiredField), $("#genderError").show(), $("#genderGood").hide(), $("#genderText").addClass("error"), !1)
    }

    function c() {
        var t = $("#username").val(),
            n;
        if (t.length == 0) {
            $("#usernameGood").hide(), $("#usernameError").show(), $("#usernameText").removeClass("error");
            return
        }
        n = s(t), n != "" ? ($("#usernameError").html(n), $("#usernameError").show(), $("#usernameText").addClass("error")) : ($("#usernameError").hide(), $("#usernameText").removeClass("error"), h())
    }

    function s(n) {
        var t = "";
        return Roblox.SignupFormValidatorGeneric.usernameTooLong(n) && (t = Roblox.Resources.AnimatedSignupFormValidator.tooLong), Roblox.SignupFormValidatorGeneric.usernameTooShort(n) && (t = Roblox.Resources.AnimatedSignupFormValidator.tooShort), Roblox.SignupFormValidatorGeneric.usernameRegexInvalid(n) && (t = Roblox.Resources.AnimatedSignupFormValidator.invalidName), t
    }

    function h() {
        var i = $("#username").val(),
            t = function(n) {
                n.data == 1 ? ($("#usernameError").html(Roblox.Resources.AnimatedSignupFormValidator.alreadyTaken), $("#usernameError").show(), $("#usernameText").addClass("error"), $("#usernameGood").hide()) : n.data == 2 ? ($("#usernameError").html(Roblox.Resources.AnimatedSignupFormValidator.cantBeUsed), $("#usernameError").show(), $("#usernameText").addClass("error"), $("#usernameGood").hide()) : n.data == 0 && ($("#usernameError").hide(), $("#usernameText").removeClass("error"), $("#usernameGood").show())
            },
            n = function() {};
        $.ajax({
            type: "GET",
            url: "/UserCheck/checkifinvalidusernameforsignup?username=" + i,
            success: t,
            error: n
        })
    }

    function f() {
        var i = $("#password").val(),
            r = $("#username").val(),
            n;
        if (t(), $("#password").val().length == 0) {
            $("#passwordError").hide(), $("#passwordGood").hide(), $("#passwordText").removeClass("error");
            return
        }
        n = o(i, r), n != "" ? ($("#passwordError").html(n), $("#passwordError").show(), $("#passwordText").addClass("error"), $("#passwordGood").hide()) : ($("#passwordError").hide(), $("#passwordText").removeClass("error"), $("#passwordGood").show())
    }

    function t() {
        var t = $("#password").val(),
            n = $("#passwordConfirm").val();
        if ($("#passwordError").css("display") != "none" || n == "" || t == "") {
            $("#passwordConfirmGood").hide(), $("#passwordConfirmError").hide(), $("#passwordConfirmText").removeClass("error");
            return
        }
        Roblox.SignupFormValidatorGeneric.passwordsMatch(t, n) ? ($("#passwordConfirmGood").show(), $("#passwordConfirmError").hide(), $("#passwordConfirmText").removeClass("error")) : ($("#passwordConfirmError").html(Roblox.Resources.AnimatedSignupFormValidator.doesntMatch), $("#passwordConfirmError").show(), $("#passwordConfirmText").addClass("error"), $("#passwordConfirmGood").hide())
    }

    function o(n, t) {
        var i = "";
        return Roblox.SignupFormValidatorGeneric.passwordTooLong(n) ? i = Roblox.Resources.AnimatedSignupFormValidator.tooLong : Roblox.SignupFormValidatorGeneric.passwordTooShort(n) ? i = Roblox.Resources.AnimatedSignupFormValidator.tooShort : (Roblox.SignupFormValidatorGeneric.passwordEnoughLetters(n) || (i = Roblox.Resources.AnimatedSignupFormValidator.needsFourLetters), Roblox.SignupFormValidatorGeneric.passwordEnoughNumbers(n) || (i = Roblox.Resources.AnimatedSignupFormValidator.needsTwoNumbers), Roblox.SignupFormValidatorGeneric.passwordContainsSpaces(n) && (i = Roblox.Resources.AnimatedSignupFormValidator.noSpaces)), Roblox.SignupFormValidatorGeneric.weakPassword(n) && (i = Roblox.Resources.AnimatedSignupFormValidator.weakKey), Roblox.SignupFormValidatorGeneric.passwordIsUsername(n, t) && (i = Roblox.Resources.AnimatedSignupFormValidator.invalidName), i
    }

    function u() {
        var s = r(!0),
            h = i(),
            c = e(),
            o = $("#usernameError").css("display") == "none",
            u = $("#passwordError").css("display") == "none" && $("#passwordConfirmError").css("display") == "none",
            t = !0,
            f = n();
        return ($("#email").length > 0 && (Roblox.FormValidator.validateElementRegex($("#email")) || (t = !1)), s && h && c && u && o && t && f) ? !0 : !1
    }

    function e() {
        var n = !0;
        return $("#password").val().length == 0 && ($("#passwordError").html(Roblox.Resources.AnimatedSignupFormValidator.requiredField), $("#passwordError").show(), $("#passwordText").addClass("error"), n = !1), $("#passwordConfirm").val().length == 0 && ($("#passwordConfirmError").html(Roblox.Resources.AnimatedSignupFormValidator.requiredField), $("#passwordConfirmError").show(), $("#passwordConfirmText").addClass("error"), n = !1), $("#username").val().length == 0 && ($("#usernameError").html(Roblox.Resources.AnimatedSignupFormValidator.requiredField), $("#usernameError").show(), $("#usernameText").addClass("error"), n = !1), $("#email").length > 0 && $("#email").val().length == 0 && ($("#emailError").html(Roblox.Resources.AnimatedSignupFormValidator.requiredField), $("#emailError").show(), $("#emailText").addClass("error"), n = !1), n
    }

    function n() {
        var n = !0;
        return $("#WomAttributionSectionTest").length && $('input[name="womAttribution"]').length && (n = $('input[name="womAttribution"]:checked').length, n ? ($("#womAttributionError").hide(), $("#womAttributionText").removeClass("error"), $("#womAttributionGood").show()) : ($("#womAttributionError").text(Roblox.Resources.AnimatedSignupFormValidator.requiredField), $("#womAttributionGood").hide(), $("#womAttributionError").show(), $("#womAttributionText").addClass("error"))), n
    }
    return $("#email").keyup(function() {
        if ($(this).val().length == 0) {
            $("#emailText").removeClass("error"), $("#emailGood").hide(), $("#emailError").hide();
            return
        }
        Roblox.FormValidator.validateElementRegex($(this)) ? ($("#emailError").hide(), $("#emailText").removeClass("error"), $("#emailGood").show()) : ($("#emailError").html(Roblox.Resources.AnimatedSignupFormValidator.invalidEmail), $("#emailGood").hide(), $("#emailError").show(), $("#emailText").addClass("error"))
    }), {
        checkBirthday: r,
        checkGender: i,
        checkUsername: c,
        checkPassword: f,
        checkPasswordConfirm: t,
        checkWomAttributionTest: n,
        validateForm: u
    }
}();

;// Landing/BlueCity/AnimatedLoginFormValidator.js
typeof Roblox=="undefined"&&(Roblox={}),Roblox.AnimatedLoginFormValidator=function(){function t(){var t=$("#loginUsername"),n=$("#loginPassword");return t.val().length==0||n.val().length==0?($("#login-error").html(Roblox.Resources.AnimatedSignupFormValidator.loginFieldsRequired),$("#login-error").show(),!1):($("#login-error").hide(),!0)}return{validateLoginForm:t}}();

;// FormValidator.js
if (typeof Roblox === "undefined") {
	Roblox = {};
}

Roblox.FormValidator = function() {
    function validateElementRegex(element) {
        var regex = $(element).data("regex");
        var value = $(element).val();
        return validateRegex(value, regex);
    }

    function validateRegex(value, regex) {
        if (typeof(value) === "undefined" || typeof(regex) === "undefined") {
            return false;
        }
        var pattern = new RegExp(regex, "i");
        return pattern.test(value);
    }

    return {
        validateElementRegex: validateElementRegex
    };
}();

;// CaptchaModal.js
Roblox = Roblox || {};
Roblox.Resources = Roblox.Resources || {};

Roblox.Resources.CaptchaModal = {
    title: "Are you human?",
    message: "To finish, please verify that you are human.",
    captchaEmptyMessage: "The CAPTCHA field should not be empty, please fill it.",
    captchaErrorMessage: "The CAPTCHA you entered is invalid. Please try again.",
    finish: "Finish"
};

Roblox.CaptchaModal = function () {
    "use strict";
    function create(form) {
        function onCancel() {
            captchaDiv.hide();
            captchaDiv.appendTo(form);
        }

        function onAccept() {
            Roblox.GenericConfirmation.disableButtons();
            //copy over the inputs into the form and submit
            form.find(captchaDivSelector).remove();
            captchaDiv.hide();
            captchaDiv.appendTo(form);
            captchaDiv.removeClass("roblox-captcha-modal");
            form.submit();
        }

        function onOpen() {
            var modal = $(".ConfirmationModal");
            var noBtn = modal.find("#roblox-decline-btn");
            noBtn.hide();

            var finishBtn = modal.find("#roblox-confirm-btn");
            finishBtn.addClass("btn-large").addClass("btn-primary");
            finishBtn.width("200px");

            var body = modal.find(".TopBody");

            if (captchaDiv.length == 0) {
                captchaDiv = form.find(captchaDivSelector);
            }

            captchaDiv.css("position", "relative");
            captchaDiv.css("left", "50%");
            captchaDiv.css("margin-left", "-159px");
            captchaDiv.css("padding-top", "5px");
            captchaDiv.appendTo(body);
            captchaDiv.show();

            var message = modal.find(".Message");
            message.css("top", "0");
        }

        var captchaDiv = form.find(captchaDivSelector);

        if (typeof Roblox.GenericConfirmation === 'undefined') {
            captchaDiv.remove();
            form.submit();
            return;
        }

        Roblox.GenericConfirmation.open({
            titleText: Roblox.Resources.CaptchaModal.title,
            bodyContent: Roblox.Resources.CaptchaModal.message,
            allowHtmlContentInBody: true,
            acceptColor: Roblox.GenericConfirmation.green,
            acceptText: Roblox.Resources.CaptchaModal.finish,
            dismissable: false,
            xToCancel: true,
            onAccept: onAccept,
            onCancel: onCancel,
            onOpenCallback: onOpen
        });
    }

    function formNeedsCaptcha(form) {
        return (form.find(captchaDivSelector).length != 0);
    }

    var captchaDivSelector = ".roblox-captcha-modal";

    return {
        Create: create,
        FormNeedsCaptcha: formNeedsCaptcha
    };
}();

$(function () {
    $("form").submit(function (e) {
        "use strict";
        var form = $(this);
        if (Roblox.CaptchaModal.FormNeedsCaptcha(form)) {
            e.preventDefault();
            Roblox.CaptchaModal.Create(form);
        }
    });
});

;// Landing/BlueCity/Animation.js
; // /js/Landing/Animation.js
var Animator = function() {
    if (!(this instanceof Animator)) return new Animator;
	var n = this;
    this.init = function(t, i, r, u, f, e) {
        n.properties = t;
		n.onUpdate = i;
		n.frames = r;
		n.fps = u;
		n.finiteLoops = f;
		n.loops = e;
		n.currentFrame = 0;
		n.currentLoop = 0;
		return n;
    };
	this.restart = function() {
        n.currentFrame = 0;
		n.currentLoop = 0;
		n.start();
    };
	this.start = function() {
		n.intervalId = setInterval(n.animate, 1e3 / n.fps);
    };
	this.stop = function() {
        clearInterval(n.intervalId);
    };
	this.animate = function() {
        n.onUpdate(n.currentFrame, n.properties);
        n.currentFrame++;
		if (n.currentFrame >= n.frames && n.finiteLoops) {
			n.currentLoop++;
			n.currentFrame = 0;
		}else if (n.currentFrame % n.frames == 0) {
			n.currentLoop++;
			n.currentFrame = 0;
		}
		if (n.currentLoop >= n.loops && n.finiteLoops) {
			n.stop();
		}
    }
};

;// Landing/BlueCity/Animated.js
; // Landing/Animated.js
$(function() {
    function r(n, t) {
        t.xpos = -.71 * n;
		t.logo.css("background-position", t.xpos + "px 0");
    }

    function e(n, t) {
        t.xpos = -.35 * n;
		t.logo.css("background-position", t.xpos + "px 0");
    }

    function n() {
        $("#animated-signup").show();
		$("#animated-login").hide();
		$("#animated-tab-signup").addClass("animated-tab-selected");
		$("#animated-tab-login").removeClass("animated-tab-selected");
    }

    function i() {
        $("#animated-login").show();
		$("#animated-signup").hide();
		$("#animated-tab-login").addClass("animated-tab-selected");
		$("#animated-tab-signup").removeClass("animated-tab-selected");
    }
    var f = {
            xpos: 0,
            logo: $("#Container")
        },
        o = {
            xpos: 0,
            logo: $("body")
        },
        u = $("#Experimental").data("is-animated") == "True",
        t;
    if (u) {
		(new Animator).init(f, r, 1e4, 60, !1, 0).start();
		(new Animator).init(o, e, 2e4, 60, !1, 0).start();
	}
	
	$("#UserName,#Password,#PasswordConfirm,#SignUpButton").keypress(function(n) {
        n.which == "13" && Roblox.AnimatedSignupFormValidator.validateForm() && $("#SignUpButton").click();
    });
	$("#UserName").blur(Roblox.AnimatedSignupFormValidator.checkUsername);
	$("#animated-tab-login").click(function() {
        i();
    });
	$("#animated-tab-signup").click(function() {
        n();
    });
	t = $("#animated-wrapper").data("first-visit"), t == "True" ? n() : i(), $("#loginUsername,#loginPassword").keypress(function(n) {
        n.which == "13" && Roblox.AnimatedLoginFormValidator.validateLoginForm() && $("#login-button").click();
    });
	$("#login-button").click(function() {
        Roblox.AnimatedLoginFormValidator.validateLoginForm() && $("#login-form").submit();
    })
});
