using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using vwmsweb.Utils;
using vwmsweb.Services;

namespace vwmsweb.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    [MaxLength(20)]
    [DisplayName("Username")]
    [Required]
    public string? Username { get; set; }

    [BindProperty]
    [DisplayName("Password")]
    [DataType(DataType.Password)]
    [Required]
    public string? Password { get; set; }

    [BindProperty]
    public bool InvalidLoginWarning { get; set; } = false;

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public IActionResult OnGet()
    {
        if (SessionUtil.AuthorizeExhibitor(HttpContext))
        {
            return Redirect(Constants.ExhibitorLoginRedirect);
        }

        if (SessionUtil.AuthorizeManager(HttpContext))
        {
            return Redirect(Constants.ManagerLoginRedirect);
        }

        return Page();
    }

    public IActionResult OnPost(UserService svc)
    {
        if (Username == null || Password == null)
        {
            return Page();
        }

        var user = svc.LoginUser(Username, Password);
        if (user == null)
        {
            InvalidLoginWarning = true;
            return Page();
        }

        SessionUtil.SetUser(HttpContext, user);
        return RedirectToPage();
    }
}