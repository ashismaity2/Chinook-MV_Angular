using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcChinook.Services
{
    public interface IAppService
    {
        JsonResult GetCustomer();//IList<string> GetGenreNames();
        //void CreCustomer(Customer customer);
        //IList<Genre> GetGenres(int max = 0);

        //Genre GetGenreByName(string name);

        //Album GetAlbum(int id);
    }

}