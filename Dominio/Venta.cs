using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
    {
        public int ID { get; set; }
        public Calzado Calzado { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public SqlMoney Total { get; set; }
    }
}
