using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    public class Service
    {
        private readonly DataBase _dataBase;

        public Service(DataBase dataBase)
        {
            _dataBase = dataBase;
        }

        public IEntity Save(IEntity entity, ISaver saver)
        {
            return saver.Save(_dataBase, entity);
        }

        public List<IEntity> ReadAll(IReader reader)
        {
            return reader.ReadAll(_dataBase);
        }

    }
}
