﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;

namespace api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务
            // 将 Web API 配置为仅使用不记名令牌身份验证。
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API 路由    有这个才可以在action 前面加 路由属性 eg ;   [HttpGet,Route("aa/{dd?}")]
            config.MapHttpAttributeRoutes();
       
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { controller= "MyApiController", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
               name: "my",
               routeTemplate: "My/{controller}/{action}/{id}",
               defaults: new { controller = "MyApi", action = "index", id = RouteParameter.Optional }
           );
        }
    }
}
