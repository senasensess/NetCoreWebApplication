﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
     interface IRepository<T> where T : class
    {
        List<T> GetAll();

        List<T> GetAll(Expression<Func<T ,bool>> expression);

        

        T Get(Expression<Func<T, bool>> expression);

        T Find(int id);

        int Add(T entity);

        int Update(T entity);

        int Remove(T entity);


    }
}
