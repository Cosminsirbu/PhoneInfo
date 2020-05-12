using PhoneInfo.ApplicationLogic.Abstractions;
using PhoneInfo.ApplicationLogic.DataModel;
using PhoneInfo.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class TipUsRepository : BaseRepository<TipUs>, ITipUs
    {
        public TipUsRepository(PhoneInfoDBContext dbContext) : base(dbContext)
        {
        }


        public void AddTipUs(Guid tipUsId, string tipUsEmail, string tipUsContent, DateTime date)
        {
            TipUs tipUs = new TipUs()
            {
                TipusId = tipUsId,
                Email = tipUsEmail,
                Content = tipUsContent,
                Date = date
            };

            Add(tipUs);
        }
    }
    
}
