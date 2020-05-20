using PhoneInfo.ApplicationLogic.Abstractions;
using PhoneInfo.ApplicationLogic.DataModel;
using PhoneInfo.DataAccess;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace DataAccess
{
    public class PhoneRepository : BaseRepository<Phone>, IPhone
    {
        Regex rgx;

        public PhoneRepository(PhoneInfoDBContext dbContext) : base(dbContext)
        {
        }
        public IEnumerable<Comment> GetComments(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetComments()
        {
            throw new NotImplementedException();
        }

        public Phone GetPhoneByPhoneId(Guid phoneId)
        {
            throw new NotImplementedException();
        }
        public string GetPage(string name)
        {
            string text = "samsungnote10 samsungs20ultra HuaweiP40Pro Iphone11 Iphone11Pro LgV60 ";
            string retPage = null;
            string phoneName = null;

            rgx = new Regex(name, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Match match = rgx.Match(text);

            if(match.Success)
            {
                text = text.Substring(match.Index, text.Length - match.Index);
                phoneName = text.Substring(0, text.IndexOf(" "));
                retPage = "~/Views/Phones/" + phoneName + ".cshtml";
            }

            return retPage;

        }
    }
}
