using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.IO;
using System;
namespace JqueryAjax.vscode
{
    public class Helper
    {
        public static string RenderRazorViewToString(Controller controller,string viewname,object modal=null)
        {
            controller.ViewData.Model=modal;
            using (var sw =new StringWriter())
            {
                IViewEngine viewEngine=controller.HttpContext.RequestServices.GetService(typeof(ICompositeViewEngine)) as ICompositeViewEngine;
                ViewEngineResult viewEngineResult=viewEngine.FindView(controller.ControllerContext,viewname,false);
                ViewContext viewContextAttribute=new ViewContext(
                    controller.ControllerContext,
                    viewEngineResult.View,
                    controller.ViewData,
                    controller.TempData,
                    sw,
                    new HtmlHelperOptions()
                );
            viewEngineResult.View.RenderAsync(viewContextAttribute);
            return sw.GetStringBuilder().ToString();
                
            }
        }
        
    }
}