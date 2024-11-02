using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccsessLayer.Abstract
{
    public interface IbasketDal:IGenericDal<Basket>
    {
        List<Basket> GetBasketByMenuTableNumber ( int id );
    }
}
