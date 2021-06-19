using ActionFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFilters.Filters
{
    public class ActFilters : FilterAttribute, IActionFilter
    {
        DataBaseContext context = new DataBaseContext();

        /// <summary>
        /// After action executed
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            context.Database.CreateIfNotExists();
            context.Logs.Add(new Log()
            {
                TransactionDate = DateTime.Today,
                UserName = "System",
                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName
            });

            context.SaveChanges();
        }


        /// <summary>
        /// before action executing
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            context.Database.CreateIfNotExists();
            context.Logs.Add(new Log()
            {
                TransactionDate = DateTime.Today,
                UserName="System",
                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName
            });

            context.SaveChanges();
        }
    }
}