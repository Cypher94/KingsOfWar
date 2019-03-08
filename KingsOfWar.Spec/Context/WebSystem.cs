using System;
using System.Configuration;

namespace KingsOfWar.Spec.Context
{
    public class WebSystem
    {
        public Uri BaseUrl { get; set; }

        public WebSystem()
        {
            BaseUrl = new Uri(ConfigurationManager.AppSettings["Context.WebSystem.BaseUrl"]);
        }
    }
}
