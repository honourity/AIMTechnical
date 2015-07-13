using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AIMTechnical.Startup))]
namespace AIMTechnical
{
  public partial class Startup
  {
    public void Configuration(IAppBuilder app)
    {

    }
  }
}
