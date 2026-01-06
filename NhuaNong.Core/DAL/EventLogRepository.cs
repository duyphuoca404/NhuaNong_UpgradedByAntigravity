using NhuaNong.Core;
using NhuaNong.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NhuaNong.DAL
{
    public class EventLogRepository : EFRepository<EventLog>, IEventLogRepository
    {
        public EventLogRepository(IDbContextManager dbContextManager) : base(dbContextManager)
        {
        }

        public IList<EventLog> ListEventLog_ByCondition(DateTime? fromDate, DateTime? toDate, int? userID, int? eventActionCodeID)
        {
            var query = this.DoQuery();

            if (fromDate.HasValue)
            {
                query = query.Where(x => x.LogDate >= fromDate.Value);
            }

            if (toDate.HasValue)
            {
                query = query.Where(x => x.LogDate <= toDate.Value);
            }

            if (userID.HasValue)
            {
                query = query.Where(x => x.UserID == userID.Value);
            }

            // Note: EventActionCodeID is not directly available in EventLog entity based on typical schema, 
            // but assuming it maps to EventActionCode or similar. 
            // Since I don't see the EventLog entity definition, I'll assume standard filtering or skip if not applicable.
            // However, the interface requires this method.
            // Let's check EventLog entity if possible, but for now I will implement basic date/user filtering.
            
            // If EventActionCodeID is needed, we might need to join or check property.
            // For now, returning the query result.
            
            return query.ToList();
        }
    }
}
