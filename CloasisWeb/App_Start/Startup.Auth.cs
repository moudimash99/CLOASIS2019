﻿using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Owin;
using CloasisWeb.Models;

namespace CloasisWeb
{
    //public partial class Startup
    //{
    //    // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
    //    public void ConfigureAuth(IAppBuilder app)
    //    {
           
    //        app.CreatePerOwinContext(ApplicationDbContext.Create);
    //        app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
    //        app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);
 
    //        app.UseCookieAuthentication(new CookieAuthenticationOptions
    //        {
    //            AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
    //            LoginPath = new PathString("/Account/Login"),
    //            Provider = new CookieAuthenticationProvider
    //            {
    //                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<ApplicationUserManager, ApplicationUser>(
    //                    validateInterval: TimeSpan.FromMinutes(30),
    //                    regenerateIdentity: (manager, user) => user.GenerateUserIdentityAsync(manager))
    //            }
    //        });            
    //        app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

    //           app.UseTwoFactorSignInCookie(DefaultAuthenticationTypes.TwoFactorCookie, TimeSpan.FromMinutes(5));
    // app.UseTwoFactorRememberBrowserCookie(DefaultAuthenticationTypes.TwoFactorRememberBrowserCookie);
             
    //        app.UseMicrosoftAccountAuthentication(
    //            clientId: "0451457d-8e77-45ed-8ab7-9cba8fb063a5",
    //            clientSecret: "zxcIDO2?]#jzlsPHJA7290[");
         
    //    }
    //}
}