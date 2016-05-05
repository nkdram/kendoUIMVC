# Sample MVC application using Kendo UI

Steps:

Install KendoUI for asp.net MVC trial version [https://www.telerik.com/download-trial-file/v2/ui-for-asp.net-mvc] 

Create MVC 5 web application in Visual Studio

Include Kendo.MVC.dll dll in reference C:\Program Files (x86)\Telerik\UI for ASP.NET MVC Q1 2016\wrappers\aspnetmvc\Binaries\Mvc5\Kendo.MVC.dll
 
    Note : Extension in VS is also included in KendoUI trial version. It allows you to scaffhold MVC - KendoUI web app.

Scripts and Styles of KendoUI can be added in filesystem using configure option in menu - Telerik -> UI for Asp.net MVC - > Configure Project 

                            (OR)

Copy JS folder ( C:\Program Files (x86)\Telerik\UI for ASP.NET MVC Q1 2016\js ) to file system - (Path ~siteroot/Scripts/KendoUI/)
Copy Styles folder ( C:\Program Files (x86)\Telerik\UI for ASP.NET MVC Q1 2016\styles ) to file system  -  (Path ~siteroot/Content/KendoUI/)


Add reference in bundle.config file


            //Kendo UI Js
            bundles.Add(new ScriptBundle("~/bundles/kendojs").Include(
                      "~/Scripts/kendo/2016.1.412/jszip.min.js",
                      "~/Scripts/kendo/2016.1.412/kendo.all.min.js",
                      "~/Scripts/kendo/2016.1.412/kendo.aspnetmvc.min.js"));

            //Kendo UI CSS
            bundles.Add(new StyleBundle("~/Content/kendocss").Include(
                      "~/Content/kendo/2016.1.412/kendo.common.min.css",
                      "~/Content/kendo/2016.1.412/kendo.mobile.all.min.css",
                      "~/Content/kendo/2016.1.412/kendo.dataviz.min.css",
                      "~/Content/kendo/2016.1.412/kendo.default.min.css",
                      "~/Content/kendo/2016.1.412/kendo.dataviz.default.min.css"));
                      
                      
  
  
  Now KendoUI controls can be added in view , simple example of adding a Textbox using HTML helper in razor cshtml file.
  
                   @(
                        Html.Kendo().TextBoxFor(model => model.Name)
                              .Name("name")
                              .HtmlAttributes(new { placeholder = "Enter your name", required = "required", validationmessage = "Enter {0}", 
                              @class="form-control"})
                      )
                      
                      

