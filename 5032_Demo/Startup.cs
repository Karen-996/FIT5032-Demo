﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_5032_Demo.Startup))]
namespace _5032_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
