using NeoSocial.Database.IUnitOfWork;
using NeoSocial.Database.Repository;
using NeoSocial.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoSocial.Business
{
    interface IIconBusiness
    {
        List<Icon> getAllIconId();
        string getIconUrl(int iconId);
    }
    public class IconBusiness : IIconBusiness
    {
        PostContext _postContext;
        List<Icon> _iconList;
        Icon _icon;

        public IconBusiness()
        {
            _postContext = new PostContext(new DbContextFactory());   
        }

        public List<Icon> getAllIconId()
        {
            _iconList = _postContext.IconRepository.Get().ToList();

            return _iconList;
        }

        public string getIconUrl(int iconId)
        {
            _icon = _postContext.IconRepository.Filter(a => a.IconID == iconId).ToList().First();

            return _icon.IconPath;
        }
    }
}
