using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Ext.Net;
using Ext.Net.Core;
using MojeeIO;

namespace extnetsample.Pages
{
    public class DirectEventsModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnPostButtonClick()
        {
            var msg = $"Server Time is { DateTime.Now.ToString("H:mm:ss tt") } :+1:";

            this.X().Toast(Mojee.Replace(msg));

            return this.Direct();
        }
    }
}