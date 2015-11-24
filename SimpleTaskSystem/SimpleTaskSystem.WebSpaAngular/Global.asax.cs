﻿using System;
using System.Web.Http;
using Abp.Dependency;
using Abp.Web;
using Castle.Facilities.Logging;

namespace SimpleTaskSystem.WebSpaAngular
{
    public class MvcApplication : AbpWebApplication
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            IocManager.Instance.IocContainer.AddFacility<LoggingFacility>(f => f.UseLog4Net().WithConfig("log4net.config"));
            base.Application_Start(sender, e);
        }
    }
}
