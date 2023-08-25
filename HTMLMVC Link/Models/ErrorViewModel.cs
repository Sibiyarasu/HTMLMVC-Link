using System;

namespace HTMLMVC_Link.Models
{
    public class ErrorViewModel
    {
        public ErrorViewModel()
        {
            ErrorMessage = "Error Occured.";
            CustomMessage = "Please Contact System Admin";
        }

        public string CustomMessage { get; set; }
        public string ErrorMessage { get; set; }
    }
}
