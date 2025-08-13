<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BonusRoundJavaScript.ascx.cs" Inherits="Roblox.Website.UserControls.BonusRoundJavaScript" %>
    <script type="text/javascript">
        var referrerIsValid = true;
        function check_code() {
            if ($("#<%#Parent.FindControl("referral_code").ClientID %>").val() != "") {
                $.ajax({
                    type: "GET",
                    url: "/Login/ReferralCodeCheck.ashx?&code=" + $("#<%#Parent.FindControl("referral_code").ClientID %>").val(),
                    success: function(data) {

                        if (data == "false") {
                            $("#code_checker").html("<img src='<%# StaticContent.GetUrl("~/images/cross.png") %>' />");
                            referrerIsValid = false;

                        }
                        else if (data == "true") {
                            $("#code_checker").html("<img src='<%# StaticContent.GetUrl("~/images/accept.png") %>' />");
                            referrerIsValid = true;
                        }
                    }
                });
            }
            else {
                $("#code_checker").html("");
                referrerIsValid = true;
            }
        }
        function initiate_waiting() {
            var input_code = $("#<%#Parent.FindControl("referral_code").ClientID %>").val();
            if (input_code != "") {
                $("#code_checker").html("<img src='<%# StaticContent.GetUrl("~/images/waiting.gif") %>' />");
                if (input_code.length > 3 && input_code.length < 20) {
                    check_code();
                }
                else {
                    $("#code_checker").html("<img src='<%# StaticContent.GetUrl("~/images/cross.png") %>' />");
                    referrerIsValid = false;
                }
            }
            else {
                $("#code_checker").html("");
                referrerIsValid = true;
            }
        }
        function checkReferralState(alsoCheckEmail) {
            if (referrerIsValid == false) {
                var answer = confirm("The referral code you've entered is invalid. Are you sure you want to create an account without a referral code?");
                if (answer) {
                    if (!alsoCheckEmail)
                        return true;
                    else
                    {
                        if ($("#<%#Parent.FindControl("EmailTextBox").ClientID %>").val() == "")
			            {
			            var popupText = '';
                                    //Warn with modal popup that email is not present
                                   
                                        popupText = "Looks like you're trying to enter your email but forgot. Enter email and click OK, or click Enter Email Later if you don't want to enter your email.";
                                   
                                   
                                   alert(popupText);
                                   
                                   return false;
			            }
			            return true;
                    }
                }
                else {
                    return false;
                }
            }
            else {
                if (!alsoCheckEmail)
                    return true;
                else 
                {
                    if ($("#<%#Parent.FindControl("EmailTextBox").ClientID %>").val() == "")
			        {
			        var popupText = '';
                                //Warn with modal popup that email is not present
                               
                                    popupText = "Looks like you're trying to enter your email but forgot. Enter email and click OK, or click Enter Email Later if you don't want to enter your email.";
                               
                               
                               alert(popupText);
                               
                               return false;
			        }
			        return true;
                }
            }
        }
        $(document).ready(function() {
            if ($("#<%#Parent.FindControl("referral_code").ClientID %>").val() != "") {
                check_code();
            }
        });
    </script>