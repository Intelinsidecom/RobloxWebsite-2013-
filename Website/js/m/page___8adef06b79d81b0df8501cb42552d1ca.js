;// bundle: page___8adef06b79d81b0df8501cb42552d1ca
;// files: SignupFormValidator.js, FormValidator.js, GenericConfirmation.js

;// SignupFormValidator.js
if (typeof Roblox === "undefined") {
    Roblox = {};
}

/* Roblox.SignupFormValidator handles the validation when a user signs up on the 
NewNameAndPassword.aspx page */
Roblox.SignupFormValidator = function () {
    $(function () {
        $('#UserName,#Password,#PasswordConfirm').keypress(function (event) {
            if (event.which == '13') {
                if (ValidateForm()) document.getElementById('ButtonCreateAccount').click();
            }
        });
        $('#UserName').blur(Roblox.SignupFormValidator.checkUsername);
    });

    function checkGender() {
        if ($('#MaleBtn:checked').length == 0 && $('#FemaleBtn:checked').length == 0) {
            $('#genderError').show();
            $('#genderGood').hide();
            return false;
        }
        else {
            $('#genderError').hide();
            $('#genderGood').show();
            return true;
        }
    }

    function checkPassword() {
        checkPasswordConfirm();

        if ($('#Password').val().length == 0) {
            $('#passwordError').hide();
            $('#passwordGood').hide();
            return; // don't do anything if empty
        }

        var error = verifyPassword($('#Password').val(), $('#UserName').val());
        if (error != "") {
            $('#passwordErrorMessage').html(error);
            $('#passwordError').show();
            $('#passwordGood').hide();
        } else {
            $('#passwordError').hide();
            $('#passwordGood').show();
        }
    }

    function checkPasswordConfirm() {
        var p0 = $('#Password').val();
        var p1 = $('#PasswordConfirm').val();

        // if either is empty, or the first password is bad, don't make any comment in the password confirm
        if ($('#passwordError').css('display') != 'none' || (p1 == "" || p0 == "")) {
            $('#passwordConfirmGood').hide();
            $('#passwordConfirmError').hide();
            return;
        }

        // if it matches
        var isMatch = testPasswordMatch(p0, p1);
        if (!isMatch) {
            $('#passwordConfirmError').show();
            $('#PasswordConfirmMessage').html("<p>" + Roblox.SignupFormValidator.Resources.doesntMatch + "</p>");
            $('#passwordConfirmGood').hide();
        } else {
            $('#passwordConfirmGood').show();
            $('#passwordConfirmError').hide();
        }
    }

    function checkUsername() {

        if ($('#UserName').val().length == 0) {
            $('#usernameGood').hide();
            $('#UsernameError').hide();
            return;
        }

        // check if errors related to length or regex
        var error = verifyUsername($('#UserName').val());
        if (error != "") {
            $('#usernameErrorMessage').html(error);
            $('#usernameErrorMessage').show();
            $('#UsernameError').show();
            $('#usernameGood').hide();
        } else {
            $('#UsernameError').hide();
            checkIfUsernameInvalid();
        }
    }
    function checkBirthday(showError) {
        var year = parseInt($('#lstYears option:selected').val());
        var month = parseInt($('#lstMonths option:selected').val());
        var day = parseInt($('#lstDays option:selected').val());

        // if valid
        if (year <= 0 || month <= 0 || day <= 0 || day > new Date(year, month, 0).getDate()) {
            if (showError) {
                if (year == 0 && month == 0 && day == 0) $('#birthdayErrorParagraph').html(Roblox.SignupFormValidator.Resources.requiredField);
                else $('#birthdayErrorParagraph').html('Invalid birthday');
                $('#birthdayError').show();
                $('#birthdayGood').hide();
            }
            return false;
        }
        else {
            $('#birthdayError').hide();
            $('#birthdayGood').show();
            return true;
        }
    }

    function checkIfPasswordIsGood() {
        return ($('#passwordError').css('display') == 'none' && $('#passwordConfirmError').css('display') == 'none');
    }

    function testPasswordMatch(pwd0, pwd1) {
        if (pwd1 == "" || pwd0.length > 0 && pwd1 != "" && pwd0 == pwd1)
            return true;
        return false;
    }
    function verifyUsername(username) {
        var msg = "";
        if (username.length > 20) msg += "<p>" + Roblox.SignupFormValidator.Resources.tooLong + "</p>";
        if (username.length < 3) msg += "<p>" + Roblox.SignupFormValidator.Resources.tooShort + "</p>";
        if (!username.match(/^[a-zA-Z0-9]*$/)) msg += "<p>" + Roblox.SignupFormValidator.Resources.containsInvalidCharacters + "</p>";
        return msg;
    }

    function verifyPassword(pwd, username) {
        // Someday, replace this with an AJAX call
        var msg = "";

        if (pwd.length > 20) {
            msg += "<p>" + Roblox.SignupFormValidator.Resources.tooLong + "</p>";
        } else if (pwd.length < 6) {
            msg += "<p>" + Roblox.SignupFormValidator.Resources.tooShort + "</p>";
        } else {
            if (countLettersInPassword(pwd) < 4) msg += "<p>" + Roblox.SignupFormValidator.Resources.needsFourLetters + "</p>";
            if (countNumbersInPassword(pwd) < 2) msg += "<p>" + Roblox.SignupFormValidator.Resources.needsTwoNumbers + "</p>";
            if (countSpaces(pwd) > 0) msg += "<p>" + Roblox.SignupFormValidator.Resources.noSpaces + "</p>";
        }

        if (weakPassword(pwd)) msg += "<p>" + Roblox.SignupFormValidator.Resources.weakKey + "</p>";
        if (pwd == username) msg += "<p>" + Roblox.SignupFormValidator.Resources.invalidName + "</p>";

        return msg;
    }
    function countSpaces(str) {
        var regExp = /^\s$/;
        var numSpaces = 0;
        if (str == null || str == "") {
            return 0;
        }
        for (var i = 0; i < str.length; i++) {
            if (str.charAt(i).match(regExp)) {
                numSpaces += 1;
            }
        }
        return numSpaces;
    }
    function countLettersInPassword(str) {
        var regExp = /^[A-Za-z]$/;
        var numLetters = 0;
        if (str == null || str == "") {
            return 0;
        }
        for (var i = 0; i < str.length; i++) {
            if (str.charAt(i).match(regExp)) {
                numLetters += 1;
            }
        }
        return numLetters;
    }
    function countNumbersInPassword(str) {
        var regExp = /^[0-9]$/;
        var numNumbers = 0;
        if (str == null || str == "") {
            return 0;
        }
        for (var i = 0; i < str.length; i++) {
            if (str.charAt(i).match(regExp)) {
                numNumbers += 1;
            }
        }
        return numNumbers;
    }
    function weakPassword(pwd) {
        if (pwd.indexOf("asdf") > -1) {
            return true;
        } else if (pwd.indexOf(Roblox.SignupFormValidator.Resources.password) > -1) {
            return true;
        } else if (pwd.indexOf("qwer") > -1) {
            return true;
        } else if (pwd.indexOf("zxcv") > -1) {
            return true;
        } else if (pwd.indexOf("aaaa") > -1) {
            return true;
        } else if (pwd.indexOf("zzzz") > -1) {
            return true;
        }
        return false;
    }

    function ValidateForm() {
        var validDate = checkBirthday(true);
        var validGender = checkGender();
        var noEmptyUsernameFields = CheckEmptyUsernameFields();
        var noUsernameErrors = $('#UsernameError').css('display') == 'none';
        var validEmail = true;

        if ($('#Email').length > 0) {
            if (!Roblox.FormValidator.validateElementRegex($('#Email'))) {
                validEmail = false;
            }
        }

        if (validDate && validGender && noEmptyUsernameFields && checkIfPasswordIsGood() && noUsernameErrors && validEmail) {
            return true;
        }
        return false;
    }

    /* show clientside errors when someone crosspostbacks to this page and serverside validation fails */
    function ValidateAndShowResponses() {
        checkBirthday(true);
        checkGender();
        checkUsername();
        checkPassword();
        CheckEmptyUsernameFields();
    }

    function checkIfUsernameInvalid() {
        var username = $get('UserName').value;
        var onSuccess = function (result, context) {
        if (result.data == 1) {
                $('#usernameErrorMessage').html("<p>" + Roblox.SignupFormValidator.Resources.alreadyTaken + "</p>");
                $('#usernameErrorMessage').show();
                $('#UsernameError').show();
                $('#usernameGood').hide();
            } else if (result.data == 2) { // automoderated
                $('#usernameErrorMessage').html("<p>" + Roblox.SignupFormValidator.Resources.cantBeUsed + "</p>");
                $('#usernameErrorMessage').show();
                $('#UsernameError').show();
                $('#usernameGood').hide();
            } else if (result.data == 0) {
                $('#usernameErrorMessage').hide();
                $('#UsernameError').hide();
                $('#usernameGood').show();
            }
        };
        var onError = function (result, context) { };
        $.ajax({
            type: "GET",
            url: "/UserCheck/checkifinvalidusernameforsignup?username=" + username,
            success: onSuccess,
            error: onError
        });
    }

    function CheckEmptyUsernameFields() {
        var isValid = true;
        if ($('#Password').val().length == 0) {
            $('#passwordError').show();
            $('#passwordErrorMessage').html("<p>" + Roblox.SignupFormValidator.Resources.requiredField + "</p>");
            isValid = false;
        }
        if ($('#PasswordConfirm').val().length == 0) {
            $('#passwordConfirmError').show();
            $('#PasswordConfirmMessage').html("<p>" + Roblox.SignupFormValidator.Resources.requiredField + "</p>");
            isValid = false;
        }
        if ($('#UserName').val().length == 0) {
            $('#UsernameError').show();
            $('#usernameErrorMessage').html("<p>" + Roblox.SignupFormValidator.Resources.requiredField + "</p>");
            $('#usernameErrorMessage').show();
            isValid = false;
        }
        if ($('#Email').length > 0) {
            if ($('#Email').val().length == 0) {
                $('#emailError').show();
                $('#emailErrorMessage').html("<p>" + Roblox.SignupFormValidator.Resources.requiredField + "</p>");
                $('#emailErrorMessage').show();
                isValid = false;
            }
        }
        return isValid;
    }

    function checkEmail() {
        var emailElement = $('#Email');
        if (emailElement.val().length == 0) {
            $('#emailError').hide();
            $('#emailGood').hide();
            return;
        }

        var isValidEmail = Roblox.FormValidator.validateElementRegex(emailElement);
        if (isValidEmail) {
            $('#emailError').hide();
            $('#emailGood').show();
        } else {
            $('#emailErrorMessage').html(Roblox.SignupFormValidator.Resources.invalidEmail);
            $('#emailError').show();
            $('#emailGood').hide();
        }
    }

    /* Public interface */
    var my = {
        checkBirthday: checkBirthday,
        checkUsername: checkUsername,
        checkPassword: checkPassword,
        checkGender: checkGender,
        checkPasswordConfirm: checkPasswordConfirm,
        checkEmail: checkEmail,
        ValidateForm: ValidateForm,
        ValidateAndShowResponses: ValidateAndShowResponses
    };
    return my;
} ();


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

;// GenericConfirmation.js
if (typeof Roblox === "undefined") {
    Roblox = {};
}
if (typeof Roblox.GenericConfirmation === "undefined") {
    Roblox.GenericConfirmation = function () {

        var BUTTON_CLASS_GREEN = "btn-primary";
        var BUTTON_CLASS_BLUE = "btn-neutral";
        var BUTTON_CLASS_GRAY = "btn-negative";

        var BUTTON_CLASS_GREEN_DISABLED = "btn-disabled-primary";
        var BUTTON_CLASS_BLUE_DISABLED = "btn-disabled-neutral";
        var BUTTON_CLASS_GRAY_DISABLED = "btn-disabled-negative";

        var BUTTON_CLASS_NONE = "btn-none";

        var BUTTON_SELECTOR_YES = "#roblox-confirm-btn";
        var BUTTON_SELECTOR_NO = "#roblox-decline-btn";

        var status = {
            isOpen: false
        };

        function onCloseCallback() {
            status.isOpen = false;
            close();
        }

        var modalProperties = {
            overlayClose: true,
            escClose: true,
            opacity: 80,
            overlayCss: {
                backgroundColor: "#000"
            },
            onClose: onCloseCallback
        };

        // Usage: pass in object that overrides defaults
        function open(properties) {
            status.isOpen = true;
            // Default Property set for 'open'
            var defaults = {
                titleText: "",
                bodyContent: "",
                footerText: "",
                acceptText: Roblox.Resources.GenericConfirmation.yes,
                declineText: Roblox.Resources.GenericConfirmation.No,
                acceptColor: BUTTON_CLASS_BLUE,
                declineColor: BUTTON_CLASS_GRAY,
                xToCancel: false,
                onAccept: function () { return false; },
                onDecline: function () { return false; },
                onCancel: function () { return false; },
                imageUrl: null,
                allowHtmlContentInBody: false,
                allowHtmlContentInFooter: false,
                dismissable: true,
                fieldValidationRequired: false,
                onOpenCallback: function () { }
            };
            
            properties = $.extend({}, defaults, properties); // merge defaults into passed in properties

            modalProperties.overlayClose = properties.dismissable;
            modalProperties.escClose = properties.dismissable;

            var yesBtn = $(BUTTON_SELECTOR_YES);
            yesBtn.html(properties.acceptText);
            yesBtn.attr("class", "btn-large " + properties.acceptColor);
            yesBtn.unbind();
            yesBtn.bind('click', function () {
                if (_buttonIsDisabled(yesBtn))
                {
                    return false;
                }
                
                if (properties.fieldValidationRequired) {
                    btnClickCallbackFirst(properties.onAccept);
                } else {
                    btnClick(properties.onAccept);
                }
                return false;
            });

            var noBtn = $(BUTTON_SELECTOR_NO);
            noBtn.html(properties.declineText);
            noBtn.attr("class", "btn-large " + properties.declineColor);
            noBtn.unbind();
            noBtn.bind('click', function () {
                if (_buttonIsDisabled(noBtn))
                {
                    return false;
                }
                
                btnClick(properties.onDecline);
                return false;
            });

            $('[data-modal-handle="confirmation"] div.Title').text(properties.titleText);

            var modal = $("[data-modal-handle='confirmation']");
            if (properties.imageUrl == null) {
                modal.addClass('noImage');
            } else {
                modal.find('img.GenericModalImage').attr('src', properties.imageUrl);
                modal.removeClass('noImage');
            }

            if (properties.allowHtmlContentInBody)
                $("[data-modal-handle='confirmation'] div.Message").html(properties.bodyContent);
            else
                $("[data-modal-handle='confirmation'] div.Message").text(properties.bodyContent);

            //Remove extra spacing introduced by the footer if there is no footer
            if ($.trim(properties.footerText) == "") {
                $('[data-modal-handle="confirmation"] div.ConfirmationModalFooter').hide();
            }
            else {
                $('[data-modal-handle="confirmation"] div.ConfirmationModalFooter').show();
            }
            if (properties.allowHtmlContentInFooter)
                $('[data-modal-handle="confirmation"] div.ConfirmationModalFooter').html(properties.footerText);
            else
                $('[data-modal-handle="confirmation"] div.ConfirmationModalFooter').text(properties.footerText);

            $("[data-modal-handle='confirmation']").modal(modalProperties);

            var cancelBtn = $("a.genericmodal-close");
            cancelBtn.unbind();
            cancelBtn.bind('click', function () {
                btnClick(properties.onCancel);
                return false;
            });
            if (!properties.xToCancel) {
               cancelBtn.hide();           
            }
            

            properties.onOpenCallback();
        }

        function _disableButton(btn) {
            if (btn.hasClass(BUTTON_CLASS_GRAY)) {
                btn.addClass(BUTTON_CLASS_GRAY_DISABLED);
            } else if (btn.hasClass(BUTTON_CLASS_GREEN)) {
                btn.addClass(BUTTON_CLASS_GREEN_DISABLED);
            } else if (btn.hasClass(BUTTON_CLASS_BLUE)) {
                btn.addClass(BUTTON_CLASS_BLUE_DISABLED);
            }
        }
        function _buttonIsDisabled(btn) {
            if (btn.hasClass(BUTTON_CLASS_BLUE_DISABLED)
                    || btn.hasClass(BUTTON_CLASS_GRAY_DISABLED)
                    || btn.hasClass(BUTTON_CLASS_GREEN_DISABLED)) {
                return true;
            }

            return false;
        }

        function disableButtons() {
            var yesBtn = $(BUTTON_SELECTOR_YES);
            var noBtn = $(BUTTON_SELECTOR_NO);

            _disableButton(yesBtn);
            _disableButton(noBtn);

        }

        function enableButtons() {
            var yesBtn = $(BUTTON_SELECTOR_YES);
            var noBtn = $(BUTTON_SELECTOR_NO);
            var classesToRemove = BUTTON_CLASS_BLUE_DISABLED + " " + BUTTON_CLASS_GRAY_DISABLED + " " + BUTTON_CLASS_GREEN_DISABLED;

            yesBtn.removeClass(classesToRemove);
            noBtn.removeClass(classesToRemove);
        }

        function clickYes() {
            if (status.isOpen) {
            var yesBtn = $(BUTTON_SELECTOR_YES);
            yesBtn.click();
        }
        }

        function clickNo() {
            var noBtn = $(BUTTON_SELECTOR_NO);
            noBtn.click();
        }

        function close(id) {
            status.isOpen = false;
            if (typeof id !== 'undefined') {
                $.modal.close(id);
            } else {
                $.modal.close();
            }
        }

        function btnClick(callBack) {
            close();
            if (typeof callBack === 'function') {
                callBack();
            }
        }

        function btnClickCallbackFirst(callBack) {
            if (typeof callBack === 'function') {
                var returnVal = callBack();
                if (returnVal !== 'undefined') {
                    if (returnVal == false) {
                        return false;
                    }
                }
            }
            close();
        };

        return {
            open: open,
            close: close,
            disableButtons: disableButtons,
            enableButtons: enableButtons,
            clickYes: clickYes,
            clickNo: clickNo,
            status: status,

            green: BUTTON_CLASS_GREEN,
            blue: BUTTON_CLASS_BLUE,
            gray: BUTTON_CLASS_GRAY,
            none: BUTTON_CLASS_NONE
        };
    } ();
}

//keyboard control
$(document).keypress(function (e) {
    if (Roblox.GenericConfirmation.status.isOpen && e.which === 13) {
        Roblox.GenericConfirmation.clickYes();
    }
});
