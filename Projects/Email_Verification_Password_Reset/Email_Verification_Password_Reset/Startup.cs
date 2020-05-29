using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Email_Verification_Password_Reset.Startup))]
namespace Email_Verification_Password_Reset
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
