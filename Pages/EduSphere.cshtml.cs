using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cdsa.solutions.Pages
{
    public class EduSphereModel : PageModel
    {
        public int LearnerCount { get; private set; }
        public int SchoolsConnected { get; private set; }
        public int Partners { get; private set; }

        public void OnGet()
        {
            // For MVP keep it static or fetch from your database / API
            LearnerCount = 1200;       // replace with real data source later
            SchoolsConnected = 5;
            Partners = 4;
        }
    }
}
