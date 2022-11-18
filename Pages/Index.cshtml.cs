using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmptyCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmptyCore.Pages
{
    public class IndexModel : PageModel
    {
        public string CurrentMeg = "";
        private IGreeter _greeter;

        public IndexModel(IGreeter greeter)
        {
            _greeter = greeter;
        }
        public void OnGet(string name)
        {
            CurrentMeg = $"{name}: {_greeter.GetMessageOfDay()}";
        }
    }
}