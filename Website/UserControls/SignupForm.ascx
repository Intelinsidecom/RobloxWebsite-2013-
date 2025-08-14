<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SignupForm.ascx.cs" Inherits="Roblox.Website.UserControls.SignupForm" %>
 <div class="formRow">
    <label class="form-label" for="birthdate">Birthday</label>
    <div class="rightFormColumn">
        <div class="inputColumn radio">
			<asp:DropDownList ID="lstMonths" ClientIDMode="Static" tabindex="1" CssClass="form-select" change="Roblox.SignupFormValidator.checkBirthday()" runat="server" />
			<asp:DropDownList ID="lstDays" ClientIDMode="Static" tabindex="2" CssClass="form-select" onchange="Roblox.SignupFormValidator.checkBirthday()" runat="server" />
			<asp:DropDownList ID="lstYears" ClientIDMode="Static" tabindex="3" CssClass="form-select" onchange="Roblox.SignupFormValidator.checkBirthday(false)" style="margin: 0;" runat="server" />
        </div>
        <div class="validation">
            <table id="birthdayError" class="validator-container">
	<tr>
		<td><div class="validator-tooltip-top"></div><div class="validator-tooltip-main">
                <p id="birthdayErrorParagraph">Invalid birthday</p>
            </div><div class="validator-tooltip-bottom"></div></td>
	</tr>
</table>

            <div id="birthdayGood" class="validator-checkmark"></div>
        </div>
        <div class="clear" style="font-size:0;"></div>
        <span class="tip-text">Enter your birthday for a personalized experience.<br/>It will not be given to any third party.</span>
    </div>
    
    </div>

    <div class="formRow">
        <label class="form-label" for="gender">Gender:</label>

        <div class="formRadio signupPage">
            <asp:RadioButton ID="MaleBtn" ClientIDMode="Static" GroupName="Gender" Text="Male" Value="MaleBtn" onclick="Roblox.SignupFormValidator.checkGender();" tabindex="4" runat="server" />
            <asp:RadioButton ID="FemaleBtn" ClientIDMode="Static" GroupName="Gender" Text="Female" Value="FemaleBtn" onclick="Roblox.SignupFormValidator.checkGender();" tabindex="5" runat="server" />
        </div>

        <div class="validation">
            <div id="genderError" class="validator-container" style="position:absolute">
                <div class="validator-tooltip-top"></div>
                <div class="validator-tooltip-main">
                    <p>Required field</p>
                </div>
                <div class="validator-tooltip-bottom"></div>
            </div>
            <div id="genderGood" class="validator-checkmark"></div>
        </div>
    </div>

    <div class="formRow">
    <label class="form-label" for="username">Desired Username:</label>
    <div class="rightFormColumn">
        <div class="inputColumn">
            <asp:TextBox ID="UserName" ClientIDMode="Static" tabindex="6" class="text-box text-box-large" onblur="Roblox.SignupFormValidator.checkUsername()" runat="server" />
        </div>
        <div class="validation">
            <table id="UsernameError" class="validator-container">
            <tr><td><div class="validator-tooltip-top"></div><div class="validator-tooltip-main">
                <div id="usernameErrorMessage"></div>
            </div><div class="validator-tooltip-bottom"></div></td></tr>
            </table>
        
            <div id="usernameGood" class="validator-checkmark"></div>
        </div>
        <div class="clear" style="font-size:0;"></div>
        <span class="tip-text">3-20 alphanumeric characters, no spaces. <br />Do not use your real name.</span>
    </div>

    </div>
    <div class="formRow">
    <label class="form-label" for="password1">Password:</label>
    <div class="rightFormColumn">
        <div class="inputColumn">
            <input name="pass" value="" id="Password" class="text-box text-box-large"  TabIndex="7" type="password" onkeyup="Roblox.SignupFormValidator.checkPassword();"/>
        </div>
        <div class="validation">
            <table id="passwordError" class="validator-container">
            <tr><td><div class="validator-tooltip-top"></div><div class="validator-tooltip-main">
                <div id="passwordErrorMessage"></div>
            </div><div class="validator-tooltip-bottom"></div></td></tr>
            </table>
            <div id="passwordGood" class="validator-checkmark"></div>
        </div>
        <div class="clear" style="font-size:0;"></div>
        <span class="tip-text">6-20 characters, minimum of 4 letters & 2 numbers</span>
    </div>
    </div>
    <div class="formRow">
        <label class="form-label" for="password2">Confirm Password:</label>
        <div class="inputColumn">
            <input name="passConfirm" value="" id="PasswordConfirm" class="text-box text-box-large" TabIndex="8" type="password" onkeyup="Roblox.SignupFormValidator.checkPasswordConfirm();"/>
        </div>
        <div class="validation">
            <table id="passwordConfirmError" class="validator-container">
            <tr><td><div class="validator-tooltip-top"></div><div class="validator-tooltip-main">
                <div id="PasswordConfirmMessage"></div>
            </div><div class="validator-tooltip-bottom"></div></td></tr>
            </table>
            <div id="passwordConfirmGood" class="validator-checkmark"></div>
        </div>
    </div>

    <div class="clear" style="font-size:0;"></div>
    
     
    <div class="CreateAccountWrapper" style="text-align:center" >
        <asp:LinkButton OnClientClick="return Roblox.SignupFormValidator.ValidateForm();" data-se="SignUpButton" class="btn-large btn-primary" Text="Sign Up" runat="server" />
    </div>

<script type="text/javascript">
    $(function () {
 
        //<sl:translate>
        Roblox.SignupFormValidator.Resources = {
        doesntMatch : "Doesn't match",
        requiredField : "Required field",
        tooLong : "Too long",
        tooShort : "Too short",
        containsInvalidCharacters : "Contains invalid characters",
        needsFourLetters : "Needs 4 letters",
        needsTwoNumbers : "Needs 2 numbers",
        noSpaces : "No spaces allowed",
        weakKey : "Weak key combination.",
        invalidName : "Can't be your character name",
        alreadyTaken : "Already taken",
        cantBeUsed : "Can't be used",
        password : "password"
        };
        //</sl:translate>
    });
</script>   