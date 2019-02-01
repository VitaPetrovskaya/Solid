using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    public interface IReader
    {
        List<IEntity> ReadAll(DataBase database);
    }
}
