﻿using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(SocialNetwork.Api.Startup))]

namespace SocialNetwork.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            ConfigureAuth(app);

            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}