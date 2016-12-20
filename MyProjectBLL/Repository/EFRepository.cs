﻿using MyProjectDAL.Context;
using MyProjectDAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectBLL.Repository
{
    public class EFRepository : IRepository
    {
        public Person GetByName(string name)
        {
            Person p = null;
            using (var db = new PersonContext())
            {
                p = db.Persons.SingleOrDefault(x => x.PersonName.Contains(name));
            }
            return p;
        }
    }
}
