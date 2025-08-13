using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Roblox.Website.ViewModels
{
    public class LoginViewModel
    {
        public RobloxResourceSet LoginLangResources = new RobloxResourceSet("Authentication.Login");
        public RobloxResourceSet UIControlsLangResources = new RobloxResourceSet("CommonUI.Controls");

        public string Username { get; set; }
        public string Password { get; set; }

        public string ReturnUrl { get; set; }

        public LoginViewModel()
        {
            ReturnUrl = "/";
        }

        /// <summary>
        /// Self-validates the model and returns the resulting validation message (if any)
        /// </summary>
        /// <returns>The validation message</returns>
        public string GetValidationMessage()
        {
            string message = null;
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                message = LoginLangResources["Message.UsernameAndPasswordRequired"];

            return message;
        }
    }
}