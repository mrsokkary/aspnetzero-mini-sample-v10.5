﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCompanyName.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Layout;
using MyCompanyName.AbpZeroTemplate.Web.Session;
using MyCompanyName.AbpZeroTemplate.Web.Views;

namespace MyCompanyName.AbpZeroTemplate.Web.Areas.AppAreaName.Views.Shared.Themes.Theme9.Components.AppAreaNameTheme9Brand
{
    public class AppAreaNameTheme9BrandViewComponent : AbpZeroTemplateViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameTheme9BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
