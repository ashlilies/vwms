using vwmsweb.Models;

namespace vwmsweb.Utils;

public static class SessionUtil
{
    public static User? GetUser(HttpContext context)
    {
        int? id;
        if ((id = context.Session.GetInt32("UserId")) != null)
        {
            using var db = new VwmsContext();
            return db.Users.FirstOrDefault(u => u.Id == id);
        }

        return null;
    }
    
    public static void SetUser(HttpContext context, User user)
    {
        context.Session.SetInt32("UserId", user.Id);
        context.Session.SetString("FullName", user.FullName);
        context.Session.SetInt32("IsManager", Convert.ToInt32(user.IsManager));
    }

    public static void RemoveUser(HttpContext context)
    {
        context.Session.Remove("UserId");
        context.Session.Remove("FullName");
        context.Session.Remove("IsManager");
    }

    public static bool AuthorizeExhibitor(HttpContext context)
    {
        if (Authorize(context))
        {
            if (context.Session.GetInt32("IsManager") == 0)
            {
                return true;
            }
        }

        return false;
    }
    
    public static bool AuthorizeManager(HttpContext context)
    {
        if (Authorize(context))
        {
            if (context.Session.GetInt32("IsManager") == 1)
            {
                return true;
            }
        }

        return false;
    }

    public static bool Authorize(HttpContext context)
    {
        return context.Session.GetInt32("UserId") != null;
    }
}