using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(semana15_pagina_web.Startup))]
namespace semana15_pagina_web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
