#pragma checksum "F:\.net_core\BlazorApp\Pages\Daka.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6bad0cc513c51602c6ad091290a2021cd5ae639a9d62b57efad589bc1788ee60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Daka), @"mvc.1.0.razor-page", @"/Pages/Daka.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
using System.ComponentModel.Design.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
using AntDesign;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/daka")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6bad0cc513c51602c6ad091290a2021cd5ae639a9d62b57efad589bc1788ee60", @"/Pages/Daka.cshtml")]
    public class Pages_Daka : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<Form LabelColSpan=\"8\"\r\n      WrapperColSpan=\"8\">\r\n    <FormItem Label=\"Url\">\r\n        <Input ");
#nullable restore
#line 15 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
          Write(bind);

#line default
#line hidden
#nullable disable
            WriteLiteral("-Value=\"");
            WriteLiteral(".Url\" />\r\n    </FormItem>\r\n    <FormItem Label=\"学号\">\r\n        <Input ");
#nullable restore
#line 18 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
          Write(bind);

#line default
#line hidden
#nullable disable
            WriteLiteral("-Value=\"");
            WriteLiteral(".Sno\" />\r\n    </FormItem>\r\n    <FormItem Label=\"邮箱\">\r\n        <Input ");
#nullable restore
#line 21 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
          Write(bind);

#line default
#line hidden
#nullable disable
            WriteLiteral("-Value=\"");
            WriteLiteral(".Email\" />\r\n    </FormItem>\r\n    <Row>\r\n        <Col Offset=\"8\" />\r\n        <FormItem Label=\"验证码\">\r\n            <Input ");
#nullable restore
#line 26 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
              Write(bind);

#line default
#line hidden
#nullable disable
            WriteLiteral("-Value=\"");
            WriteLiteral(".Code\"/>\r\n        </FormItem>\r\n        <Button");
            BeginWriteAttribute("type", " type=\"", 766, "\"", 791, 1);
#nullable restore
#line 28 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
WriteAttributeValue("", 773, ButtonType.Dashed, 773, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 28 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
                                     Write(onclick);

#line default
#line hidden
#nullable disable
            WriteLiteral("=\"sendCode\">\r\n            发送验证码\r\n        </Button>\r\n\r\n    </Row>\r\n    \r\n    <FormItem WrapperColOffset=\"8\" WrapperColSpan=\"16\">\r\n        <Checkbox ");
#nullable restore
#line 35 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
             Write(bind);

#line default
#line hidden
#nullable disable
            WriteLiteral("-Value=\"model.RememberMe\">记住我</Checkbox>\r\n    </FormItem>\r\n    <FormItem WrapperColOffset=\"8\" WrapperColSpan=\"16\">\r\n        <Button");
            BeginWriteAttribute("Type", " Type=\"", 1084, "\"", 1110, 1);
#nullable restore
#line 38 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
WriteAttributeValue("", 1091, ButtonType.Primary, 1091, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" HtmlType=\"submit\" ");
#nullable restore
#line 38 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
                                                        Write(onclick);

#line default
#line hidden
#nullable disable
            WriteLiteral("=\"addUser\">\r\n            上传打卡任务\r\n        </Button>\r\n    </FormItem>\r\n</Form>\r\n<Row>\r\n    <Button");
            BeginWriteAttribute("type", " type=\"", 1234, "\"", 1260, 1);
#nullable restore
#line 44 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
WriteAttributeValue("", 1241, ButtonType.Primary, 1241, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 44 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
                                  Write(onclick);

#line default
#line hidden
#nullable disable
            WriteLiteral("=\"sendPing\">Ping服务端</Button>\r\n    <text>状态:");
            WriteLiteral(".PingStatus\r\n    </text>\r\n</Row>\r\n\r\n");
#nullable restore
#line 49 "F:\.net_core\BlazorApp\Pages\Daka.cshtml"
Write(code);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
{
    public class Models
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
    private Models model = new Models();
    private LoginModel _loginModel = new LoginModel();

    

    private async Task sendCode()
    {
        string str = """);
            WriteLiteral(@"api/verifyCode?sno="" + model.Sno + ""&email="" + model.Email;
        Console.WriteLine(str);
        msg =await http.GetFromJsonAsync<Msg>(str);
    }

    private async Task sendPing()
    {
        model.PingStatus = await http.GetStringAsync(""api/ping"");
    }

    private async Task addUser()
    {
        _loginModel.time = 2;
        _loginModel.url = model.Url;
        _loginModel.email = model.Email;
        _loginModel.sno = model.Sno;
        _loginModel.verifyCode = model.Code;
        Console.WriteLine(JsonSerializer.Serialize(_loginModel));
        var content = await http.PutAsJsonAsync(""api/xust/user"", _loginModel);
        msg =await content.Content.ReadFromJsonAsync<Msg>();
    }
        
}");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public HttpClient http { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlazorApp.Pages.Daka> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BlazorApp.Pages.Daka> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BlazorApp.Pages.Daka>)PageContext?.ViewData;
        public BlazorApp.Pages.Daka Model => ViewData.Model;
    }
}
#pragma warning restore 1591
