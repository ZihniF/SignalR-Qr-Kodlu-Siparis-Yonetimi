using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccsessLayer.Abstract
{
	public interface INotificationDal:IGenericDal<Notification>
	{
		int NotificationCountByStatusFalse();
		List<Notification> GetALlNotificationByFalse();
		void NotificationStatusChangeToTrue(int id);
		void NotificationStatusChangeToFalse(int id);
	}
}
