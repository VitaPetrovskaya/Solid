using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    public interface ISaver
    {
        IEntity Save(DataBase database, IEntity entity);
    }
}
