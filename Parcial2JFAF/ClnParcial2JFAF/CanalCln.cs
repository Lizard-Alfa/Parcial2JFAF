using CadParcial2JFAF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnParcial2JFAF
{
    public class CanalCln
    {
        public static List<Canal> listar()
        {
            using (var context = new Parcial2JFAFEntities())
            {
                return context.Canal
                    .Where(x => x.estado == (short)Estado.Activo)
                    .OrderBy(x => x.nombre).ToList();
            }
        }
    }
}
