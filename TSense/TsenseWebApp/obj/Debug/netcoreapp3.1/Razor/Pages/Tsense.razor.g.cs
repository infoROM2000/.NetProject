#pragma checksum "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a5c66fd3710f65295b6122dab8c3651b26ef636"
// <auto-generated/>
#pragma warning disable 1591
namespace TsenseWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\NET\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\NET\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\NET\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\NET\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\NET\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\NET\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\NET\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\NET\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using TsenseWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\NET\.NetProject\TSense\TsenseWebApp\_Imports.razor"
using TsenseWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
using TsenseWebApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Tsense : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "boxAll");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "id", "boxImage");
#nullable restore
#line 12 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
         if (@ShowImage)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<div id=\"alignAll\"><img src=\"/css/Images/emoji.jpg\" class=\"image\" alt=\"Sample Image\" width=\"70%\">\r\n                <p class=\"linkImage\">videe+Check your vibe!+Descriere </p></div>");
#nullable restore
#line 18 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "id", "raspunsuri");
#nullable restore
#line 23 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                 if (@sentiment.Equals(true))
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<img src=\"/css/Images/pozitiv.jpg\" class=\"image\" alt=\"Sample Image Pozitive\" width=\"70%\">");
#nullable restore
#line 26 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<img src=\"/css/Images/negative.jpg\" class=\"image\" alt=\"Sample Image Pozitive\" width=\"70%\">");
#nullable restore
#line 30 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                 if (@selection == 0)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "id", "tweet");
            __builder.OpenElement(11, "span");
            __builder.AddAttribute(12, "id", "result");
            __builder.AddContent(13, 
#nullable restore
#line 34 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                                           result

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "id", "sentiment");
            __builder.AddMarkupContent(16, "<span>Your vibe:</span>\r\n                        ");
            __builder.OpenElement(17, "span");
            __builder.AddAttribute(18, "id", "result-sentiment");
            __builder.AddContent(19, 
#nullable restore
#line 39 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                                                     sentiment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "id", "text");
            __builder.AddMarkupContent(22, "<span>Your text:</span>\r\n                        ");
            __builder.OpenElement(23, "span");
            __builder.AddAttribute(24, "id", "result");
            __builder.AddContent(25, 
#nullable restore
#line 46 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                                           text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "id", "sentiment");
            __builder.AddMarkupContent(29, "<span>Your vibe:</span>\r\n                        ");
            __builder.OpenElement(30, "span");
            __builder.AddAttribute(31, "id", "result-sentiment");
            __builder.AddContent(32, 
#nullable restore
#line 50 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                                                     sentiment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "id", "text");
            __builder.AddMarkupContent(35, "<span>With probaility:</span>\r\n                    ");
            __builder.OpenElement(36, "span");
            __builder.AddAttribute(37, "id", "result-prob");
            __builder.AddContent(38, 
#nullable restore
#line 55 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                                            probability

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "id", "boxTweet");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(42);
            __builder.AddAttribute(43, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 63 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                          tweet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(45, "<p class=\"Or\">Option1</p>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "tweetLink");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(49);
            __builder.AddAttribute(50, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 66 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                              tweet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 66 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                                                OnSubmitLink

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(53, "p");
                __builder2.AddMarkupContent(54, "<label class=\"linkText\" for=\"link\">Link: </label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(55);
                __builder2.AddAttribute(56, "class", "inputLink");
                __builder2.AddAttribute(57, "id", "link");
                __builder2.AddAttribute(58, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 69 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                                                                        tweet.Link

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tweet.Link = __value, tweet.Link))));
                __builder2.AddAttribute(60, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tweet.Link));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                ");
                __builder2.AddMarkupContent(62, "<button class=\"btn-primary\" type=\"submit\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(64);
            __builder.AddAttribute(65, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 75 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                          tweet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(67, "<p class=\"Or\">Option2</p>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "id", "tweetText");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(71);
            __builder.AddAttribute(72, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 77 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                              tweet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 77 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                                                OnSubmitText

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(75, "p");
                __builder2.AddMarkupContent(76, "<label class=\"linkText\" for=\"text\">Text: </label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(77);
                __builder2.AddAttribute(78, "class", "inputLink");
                __builder2.AddAttribute(79, "id", "text");
                __builder2.AddAttribute(80, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 80 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
                                                                        text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => text = __value, text))));
                __builder2.AddAttribute(82, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => text));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                ");
                __builder2.AddMarkupContent(84, "<button class=\"btn-primary\" type=\"submit\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "C:\NET\.NetProject\TSense\TsenseWebApp\Pages\Tsense.razor"
       

    Tweet tweet = new Tweet();
    string user = "";
    string result="";
    string text="";
    bool sentiment = true;
    Boolean ShowImage = true;
    int selection;
    double probability = 0;

    protected async Task OnSubmitLink()
    {
        result = await TService.GetTextFromTweet(tweet.Link);
        JObject mlPrediction = await MService.SentimentFromLink(result);
        sentiment = (bool)(mlPrediction)["prediction"];
        probability = (double)(mlPrediction)["probability"];

        text = "";
        ShowImage = false;
        selection = 0;
    }

    protected async Task OnSubmitText()
    {
        JObject mlPrediction = await MService.SentimentFromText(text);
        result = "";
        sentiment = (bool)(mlPrediction)["prediction"];
        probability = (double)(mlPrediction)["probability"];
        ShowImage = false;
        selection = 1;
    }

    protected async Task OnSubmitUser()
    {
        //"Huawei" se va inlocui cu usernameul introdus
        List<string> tweets = await TService.GetTweetsFromUser("Huawei");
        JObject mlPrediction = await MService.SentimentFromMultiple(tweets);
        sentiment = (bool)(mlPrediction)["prediction"];
        probability = (double)(mlPrediction)["probability"];
      
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MLService MService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TweetService TService { get; set; }
    }
}
#pragma warning restore 1591
