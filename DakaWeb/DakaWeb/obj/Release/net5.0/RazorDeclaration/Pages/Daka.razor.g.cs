// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DakaWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "F:\.net_core\DakaWeb\DakaWeb\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\.net_core\DakaWeb\DakaWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\.net_core\DakaWeb\DakaWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\.net_core\DakaWeb\DakaWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\.net_core\DakaWeb\DakaWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\.net_core\DakaWeb\DakaWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\.net_core\DakaWeb\DakaWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\.net_core\DakaWeb\DakaWeb\_Imports.razor"
using DakaWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\.net_core\DakaWeb\DakaWeb\_Imports.razor"
using DakaWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\.net_core\DakaWeb\DakaWeb\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\.net_core\DakaWeb\DakaWeb\Pages\Daka.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\.net_core\DakaWeb\DakaWeb\Pages\Daka.razor"
using System.ComponentModel.Design.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\.net_core\DakaWeb\DakaWeb\Pages\Daka.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\.net_core\DakaWeb\DakaWeb\Pages\Daka.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\.net_core\DakaWeb\DakaWeb\Pages\Daka.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/daka")]
    public partial class Daka : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "F:\.net_core\DakaWeb\DakaWeb\Pages\Daka.razor"
 
    public class Model
    {
        [Required]
        public string Url { get; set; }
        [Required]
        public string Sno { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Code { get; set; }
        public bool RememberMe { get; set; } = true;
        public string PingStatus { get; set; }
    }

    public class LoginModel
    {
        
        public string url { get; set; }
        
        public string sno { get; set; }
        
        public string email { get; set; }
        public int time { get; set; }
        
        public string verifyCode { get; set; }
    }
    public class Msg
    {
        public int code;
        public string message;
        public bool isSuccess;
    }

    private Msg msg = new Msg();
    private Model model = new Model();
    private LoginModel _loginModel = new LoginModel();

    private void OnFinish(EditContext editContext)
    {
        Console.WriteLine($"Success:{JsonSerializer.Serialize(model)}");
    }

    private void OnFinishFailed(EditContext editContext)
    {
        Console.WriteLine($"Failed:{JsonSerializer.Serialize(model)}");
    }

    private async Task sendCode()
    {
        string str = "api/verifyCode?sno=" + model.Sno + "&email=" + model.Email;
        Console.WriteLine(str);
        msg =await http.GetFromJsonAsync<Msg>(str);
    }

    private async Task sendPing()
    {
        model.PingStatus = await http.GetStringAsync("api/ping");
    }

    private async Task addUser()
    {
        _loginModel.time = 2;
        _loginModel.url = model.Url;
        _loginModel.email = model.Email;
        _loginModel.sno = model.Sno;
        _loginModel.verifyCode = model.Code;
        Console.WriteLine(JsonSerializer.Serialize(_loginModel));
        var content = await http.PutAsJsonAsync("api/xust/user", _loginModel);
        msg =await content.Content.ReadFromJsonAsync<Msg>();
    }
        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
