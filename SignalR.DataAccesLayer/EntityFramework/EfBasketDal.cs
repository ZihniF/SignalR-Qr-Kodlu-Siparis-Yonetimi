﻿using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.DataAccsessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccsessLayer.EntityFramework
{
    public class EfBasketDal : GenericRepository<Basket>, IbasketDal
    {
        public EfBasketDal(SignalRContext context) : base(context)
        {

        }

        public List<Basket> GetBasketByMenuTableNumber(int id)
        {
            using var contex = new SignalRContext();
            var values=contex.Baskets.Where(x=>x.MenuTableID==id).Include(y => y.Product).ToList();
            return values;
        }
    }
}
