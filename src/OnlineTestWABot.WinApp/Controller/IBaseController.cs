﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineTestWABot.WinApp.Controller
{
    public interface IBaseController<T>
        where T : class
    {
        int Save(T obj);
        int Update(T obj);
        int Delete(T obj);

        IList<T> GetAll();
    }
}
