using BanSmartPhone.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;

namespace BanSmartPhone
{
    public interface ISiteContext
    {
        public UserLogin CurrentUser
        {
            get;
        }
        public UserLogin Cart
        {
            get;
        }
    }
    public class SiteContext : ISiteContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public SiteContext(IHttpContextAccessor httpContextAccessor) {
            _httpContextAccessor = httpContextAccessor;
        }
        public UserLogin CurrentUser
        {
            get
            {
                UserLogin user = new UserLogin();

                if (_httpContextAccessor.HttpContext?.Session.GetString("username") != null)
                {
                    user.Username = _httpContextAccessor.HttpContext?.Session.GetString("username");
                    user.Id = (long)(_httpContextAccessor.HttpContext?.Session.GetInt32("id"));
                    return user;
                }
                return null;
            }
        }

        public UserLogin Cart => throw new NotImplementedException();

        //    public UserLogin Cart {
        //        get
        //        {
        //            CartSessionModel user = new CartSessionModel();
        //            CookieHeaderValue cookie = Request.Headers.GetCookies("user-code").FirstOrDefault();
        //            if (cookie != null)
        //            {
        //                sessionId = cookie["session-id"].Value;
        //            }
        //            var resp = new HttpResponseMessage();

        //            var cookie = new CookieHeaderValue("session-id", "12345");

        //            cookie.Expires = DateTimeOffset.Now.AddDays(1);
        //            cookie.Domain = Request.RequestUri.Host;
        //            cookie.Path = "/";

        //            resp.Headers.AddCookies(new CookieHeaderValue[] { cookie });
        //        }


        //}
    }
}
