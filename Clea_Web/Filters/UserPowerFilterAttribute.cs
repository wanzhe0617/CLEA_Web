﻿using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Clea_Web.Controllers;
using Clea_Web.Models;


namespace Clea_Web.Filters
{
    public class UserPowerFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //base.OnActionExecuting(context);

            var user = context.HttpContext.User;
            if (user.Identities.FirstOrDefault().Claims.Count() > 0)
            {
                GetUserRolePower(context);
            }
            else
            {
                UserRedirctPage(context, "L");
            }


            //context.HttpContext.Session.SetString("TempMsgType", "error");
            //context.HttpContext.Session.SetString("TempMsgTitle", "提醒您");
            //context.HttpContext.Session.SetString("TempMsg", "無本頁面使用權限");
        }

        private void GetUserRolePower(ActionExecutingContext context)
        {
            dbContext db = new dbContext();
            //取得目前controller name
            String _controller = context.RouteData.Values["controller"].ToString();
            //取得目前action name
            String _action = context.RouteData.Values["action"].ToString();
            //組合Url
            String Url = "/" + _controller + "/Index" ;
            //String Url = "/" + _controller + "/" + _action;
            //取得USER POWER
            var user = context.HttpContext.User;
            var claims = user.Identities.First().Claims.ToArray();
            Guid R_UID = Guid.Parse(claims[2].Value);
            ViewMenuRolePower? rp = db.ViewMenuRolePowers.Where(x => x.RUid == R_UID && x.MUrl.Equals(Url)).FirstOrDefault();

            //檢查權限
            //
            if (!(rp is null) && rp.SearchData) //Index
            {
                Boolean PowerChk = false;
                if (_action.Equals("Modify") && rp.ModifyData)
                {
                    PowerChk = true;
                }
                else if (_action.Equals("Delete") && rp.DeleteData)
                {
                    PowerChk = true;
                }
                else if (_action.Equals("Import") && rp.ImportData)
                {
                    PowerChk = true;
                }
                else if (_action.Equals("Export") && rp.Exportdata)
                {
                    PowerChk = true;
                }
                else
                {
                    //Index
                    PowerChk = true;
                }

                if (!PowerChk)
                {
                    UserRedirctPage(context, "F");
                }
            }
            else
            {
                UserRedirctPage(context, "F");
            }

        }

        private void UserRedirctPage(ActionExecutingContext context, String Type)
        {
            String _controller = string.Empty;
            String _action = "Index";

            _controller = Type.Equals("L") ? "Sys_Login" : "B_Home";

            RouteValueDictionary dictionary = new RouteValueDictionary(new { controller = _controller, action = _action });
            if (_controller.Equals("B_Home"))
            {
                context.HttpContext.Session.SetString("TempMsgType", "error");
                context.HttpContext.Session.SetString("TempMsgTitle", "提醒您");
                context.HttpContext.Session.SetString("TempMsg", "無本頁面使用權限");
            }
            else
            {
                context.HttpContext.Session.Clear();
            }            

            context.Result = new RedirectToRouteResult(dictionary);
        }
    }
}
