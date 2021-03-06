#pragma checksum "C:\Users\prasa\source\repos\BlogApp\BlogApp\Pages\BlogPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20c90b8be581b94912cee73c101d999d61e0e91f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BlogApp.Pages.Pages_BlogPost), @"mvc.1.0.razor-page", @"/Pages/BlogPost.cshtml")]
namespace BlogApp.Pages
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
#line 1 "C:\Users\prasa\source\repos\BlogApp\BlogApp\Pages\_ViewImports.cshtml"
using BlogApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c90b8be581b94912cee73c101d999d61e0e91f", @"/Pages/BlogPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83a1cf30ae070aef3cc6e811d1583c85778705b3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_BlogPost : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"single-blog\" class=\"card bg-light mb-3\">\r\n    <div class=\"card-header\"><span>Written by: ");
#nullable restore
#line 7 "C:\Users\prasa\source\repos\BlogApp\BlogApp\Pages\BlogPost.cshtml"
                                          Write(Model.Blog.Author.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span>Published Date: ");
#nullable restore
#line 7 "C:\Users\prasa\source\repos\BlogApp\BlogApp\Pages\BlogPost.cshtml"
                                                                                                   Write(Model.Blog.PublishDate.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
    <div class=""card-body"">

        <div class=""blog-settings"">
            <a><svg id=""save-svg"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24"" width=""24"" height=""24""><path fill-rule=""evenodd"" d=""M5 3.75C5 2.784 5.784 2 6.75 2h10.5c.966 0 1.75.784 1.75 1.75v17.5a.75.75 0 01-1.218.586L12 17.21l-5.781 4.625A.75.75 0 015 21.25V3.75zm1.75-.25a.25.25 0 00-.25.25v15.94l5.031-4.026a.75.75 0 01.938 0L17.5 19.69V3.75a.25.25 0 00-.25-.25H6.75z""></path></svg></a>
            <a id=""share-link""><svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24"" width=""24"" height=""24""><path fill-rule=""evenodd"" d=""M20 5.5a3.5 3.5 0 01-6.062 2.385l-5.112 3.021a3.497 3.497 0 010 2.188l5.112 3.021a3.5 3.5 0 11-.764 1.29l-5.112-3.02a3.5 3.5 0 110-4.77l5.112-3.021v.001A3.5 3.5 0 1120 5.5zm-1.5 0a2 2 0 11-4 0 2 2 0 014 0zM5.5 14a2 2 0 100-4 2 2 0 000 4zm13 4.5a2 2 0 11-4 0 2 2 0 014 0z""></path></svg></a>
        </div>

        <h5 id=""blog-title"" class=""card-title display-4"">");
#nullable restore
#line 15 "C:\Users\prasa\source\repos\BlogApp\BlogApp\Pages\BlogPost.cshtml"
                                                    Write(Model.Blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p id=\"blog-content\" class=\"card-text\">");
#nullable restore
#line 16 "C:\Users\prasa\source\repos\BlogApp\BlogApp\Pages\BlogPost.cshtml"
                                          Write(Model.Blog.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    </div>
</div>


<script>
    const svg = document.getElementById('save-svg');
    const SAVE_CACHE = 'save-v1';
    function toggleSave(url) {
        if ('caches' in window) {
            caches.open(SAVE_CACHE).then((cache) => {
                cache.match(url).then((response) => {
                    if (typeof response == 'object') {
                        svg.innerHTML = `<path fill-rule=""evenodd"" d=""M5 3.75C5 2.784 5.784 2 6.75 2h10.5c.966 0 1.75.784 1.75 1.75v17.5a.75.75 0 01-1.218.586L12 17.21l-5.781 4.625A.75.75 0 015 21.25V3.75zm1.75-.25a.25.25 0 00-.25.25v15.94l5.031-4.026a.75.75 0 01.938 0L17.5 19.69V3.75a.25.25 0 00-.25-.25H6.75z""></path>`;
                        cache.delete(url);
                    } else {
                        svg.innerHTML = `<path fill-rule=""evenodd"" d=""M6.69 2a1.75 1.75 0 00-1.75 1.756L5 21.253a.75.75 0 001.219.583L12 17.21l5.782 4.625A.75.75 0 0019 21.25V3.75A1.75 1.75 0 0017.25 2H6.69z""></path>`;
                        cache.add(url);
   ");
            WriteLiteral(@"                 }
                })
            });
        } else {
            alert('Feature not supported by your browser.');
        }

    }
    
    svg.parentElement.addEventListener('click', e => {
        toggleSave(window.location.href);
    })

    const shareLink = document.getElementById('share-link');
    shareLink.addEventListener('click', e => {
        let blogTitle = document.getElementById('blog-title').innerText;
        let blogContent = document.getElementById('blog-content').innerText
        if ('share' in navigator) {
            navigator.share({
                title: blogTitle,
                text: blogContent,
                url: window.location.href
            })
                .then(() => console.log('Successful share'))
                .catch(error => console.log('Error sharing:', error));
        } else {
            alert(""Sharing not supported by you browser"");
        }
    });
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogApp.Pages.BlogPostModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BlogApp.Pages.BlogPostModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BlogApp.Pages.BlogPostModel>)PageContext?.ViewData;
        public BlogApp.Pages.BlogPostModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
