using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DIExample.Views.Share
{
    public class _Layout : PageModel
    {
        private readonly ILogger<_Layout> _logger;

        public _Layout(ILogger<_Layout> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}