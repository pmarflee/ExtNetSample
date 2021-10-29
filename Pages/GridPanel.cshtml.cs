using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace extnetsample.Pages
{
    public record GridDataItem(Company Company, decimal Price, decimal Change, double PctChange, string lastChange);

    public record Company(string Name);

    public class GridPanelModel : PageModel
    {
        public List<object> GridData { get; set; }

        public void OnGet()
        {
            var now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:tt");

            GridData ??= new List<object>
            {
                new GridDataItem(new Company("3m Co"), 71.72M, 0.02M, 0.03, now),
                new GridDataItem(new Company("Alcoa Inc"), 29.01M, 0.42M, 1.47, now),
                new GridDataItem(new Company("Altria Group Inc"), 83.81M, 0.28M, 0.34, now),
                new GridDataItem(new Company("American Express Company"), 52.55M, 0.01M, 0.02, now),
                new GridDataItem(new Company("American International Group, Inc."), 64.13M, 0.31M, 0.49, now)
            };
        }
    }
}