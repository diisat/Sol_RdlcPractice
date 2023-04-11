using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class N_Categories
    {
        public static DataTable List_ca(string cText)
        {
            D_Categories data = new D_Categories();
            return data.List_ca(cText);
        }

        public static string save_ca(int option, E_Categories oCa)
        {
            D_Categories data = new D_Categories();
            return data.save_ca(option, oCa);

        }
    }
}
