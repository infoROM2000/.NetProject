// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TsenseWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\iRebeca\Source\Repos\brebeca\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iRebeca\Source\Repos\brebeca\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\iRebeca\Source\Repos\brebeca\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\iRebeca\Source\Repos\brebeca\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\iRebeca\Source\Repos\brebeca\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\iRebeca\Source\Repos\brebeca\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\iRebeca\Source\Repos\brebeca\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\iRebeca\Source\Repos\brebeca\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using TsenseWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\iRebeca\Source\Repos\brebeca\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using TsenseWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iRebeca\Source\Repos\brebeca\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
using TsenseWebApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Tsense : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Users\iRebeca\Source\Repos\brebeca\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
       

    Tweet tweet = new Tweet();

    string result;
    string text;
    string sentiment;
    Boolean ShowImage = true;
    int selection;

    protected async Task OnSubmitLink()
    {
        result = await TService.GetTextFromTweet(tweet.Link);
        sentiment = (string)(await MService.SentimentFromLink(result))["Prediction"];
        text = "";
        ShowImage = false;
        selection = 0;
    }

    protected async Task OnSubmitText()
    {
        result = "";
        sentiment = (string)(await MService.SentimentFromText(text))["Prediction"];
        ShowImage = false;
        selection = 1;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MLService MService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TweetService TService { get; set; }
    }
}
#pragma warning restore 1591
