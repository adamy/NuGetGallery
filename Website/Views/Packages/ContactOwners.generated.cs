﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17020
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGetGallery.Views.Packages
{
    using System.Linq;
    using System.Web.Mvc.Html;
    using NuGetGallery;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Packages/ContactOwners.cshtml")]
    public class ContactOwners : System.Web.Mvc.WebViewPage<ContactOwnersViewModel>
    {
        public ContactOwners()
        {
        }
        public override void Execute()
        {



#line 2 "..\..\Views\Packages\ContactOwners.cshtml"

            ViewBag.Tab = "Packages";
            Layout = "~/Views/Shared/TwoColumnLayout.cshtml";



#line default
#line hidden
            WriteLiteral("\r\n");


            DefineSection("LeftNav", () =>
            {

                WriteLiteral("\r\n    <img src=\"");



#line 8 "..\..\Views\Packages\ContactOwners.cshtml"
                Write(Links.Content.Images.sendMessageGraphic_png);


#line default
#line hidden
                WriteLiteral("\" style=\"padding-left: 55px\" />\r\n");


            });

            WriteLiteral("    \r\n\r\n");


            DefineSection("ContentHeader", () =>
            {

                WriteLiteral("            \r\n    <h2>Contact the Owners of <em>");



#line 12 "..\..\Views\Packages\ContactOwners.cshtml"
                Write(Model.PackageId);


#line default
#line hidden
                WriteLiteral("</em></h2>\r\n");


            });

            WriteLiteral("\r\n");



#line 14 "..\..\Views\Packages\ContactOwners.cshtml"
            if (Model.Owners.Any())
            {


#line default
#line hidden
                WriteLiteral("    <div class=\"description\">\r\n        <p>\r\n            By submitting this form, " +
                "you agree to <strong>disclose your email address</strong> \r\n            to the p" +
                "ackage owners listed below so they can reply to you.\r\n        </p>\r\n    </div> \r" +
                "\n");



                WriteLiteral("    <form action=\"");



#line 21 "..\..\Views\Packages\ContactOwners.cshtml"
                Write(Url.Current());


#line default
#line hidden
                WriteLiteral("\" id=\"form\" method=\"post\">\r\n        <label>\r\n            To: ");



#line 23 "..\..\Views\Packages\ContactOwners.cshtml"
                Write(ViewHelpers.OwnersGravatar(Model.Owners, 24, Url));


#line default
#line hidden


#line 23 "..\..\Views\Packages\ContactOwners.cshtml"
                WriteLiteral("\r\n        </label>\r\n        <div ");


#line default
#line hidden

#line 25 "..\..\Views\Packages\ContactOwners.cshtml"
                if (Html.IsError(m => m.Message))
                {

#line default
#line hidden
                    WriteLiteral("class=\"invalid\"");



#line 25 "..\..\Views\Packages\ContactOwners.cshtml"
                }

#line default
#line hidden
                WriteLiteral(">\r\n            ");



#line 26 "..\..\Views\Packages\ContactOwners.cshtml"
                Write(Html.LabelFor(m => m.Message));


#line default
#line hidden
                WriteLiteral("\r\n            <aside>\r\n                <p>\r\n                    <strong>");



#line 29 "..\..\Views\Packages\ContactOwners.cshtml"
                Write(Html.ValidationMessageFor(m => m.Message));


#line default
#line hidden
                WriteLiteral("</strong>\r\n                </p>\r\n            </aside>\r\n            ");



#line 32 "..\..\Views\Packages\ContactOwners.cshtml"
                Write(Html.TextAreaFor(m => m.Message, 10, 50, null));


#line default
#line hidden
                WriteLiteral("\r\n        </div>                     \r\n\r\n        ");



#line 35 "..\..\Views\Packages\ContactOwners.cshtml"
                Write(Html.AntiForgeryToken());


#line default
#line hidden
                WriteLiteral("\r\n        <input id=\"contactOwnersButton\" type=\"submit\" value=\"Send\" singleclickb" +
                "utton=\"true\" />\r\n    </form>\r\n");



#line 38 "..\..\Views\Packages\ContactOwners.cshtml"
            }
            else
            {


#line default
#line hidden
                WriteLiteral(@"    <div id=""messages"">
        <div class=""zone zone-messages"">
            <div class=""message message-Warning"">
                <p>Sorry, the owners of this package do not allow contacting them through this form.</p>
            </div>
            <p class=""description"">Try visiting the project home page for the package in order to contact the package owner.</p>
        </div>
    </div>
");



#line 48 "..\..\Views\Packages\ContactOwners.cshtml"
            }


#line default
#line hidden
            WriteLiteral("\r\n");


            DefineSection("BottomScripts", () =>
            {

                WriteLiteral("\r\n    <script src=\"");



#line 51 "..\..\Views\Packages\ContactOwners.cshtml"
                Write(Url.Content("~/Scripts/jquery.validate.min.js"));


#line default
#line hidden
                WriteLiteral("\" type=\"text/javascript\"></script>\r\n    <script src=\"");



#line 52 "..\..\Views\Packages\ContactOwners.cshtml"
                Write(Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js"));


#line default
#line hidden
                WriteLiteral("\" type=\"text/javascript\"></script>\r\n    <script src=\"");



#line 53 "..\..\Views\Packages\ContactOwners.cshtml"
                Write(Url.Content("~/Scripts/gallery.form.js"));


#line default
#line hidden
                WriteLiteral("\" type=\"text/javascript\"></script>\r\n");


            });


        }
    }
}
#pragma warning restore 1591