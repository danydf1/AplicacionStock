using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Calzado
     {
        public int ID { get; set; }
        public string Modelo { get; set; }
        public SqlMoney Precio { get; set; }
        public ColorBase colorBase { get; set; }
        public Color Color { get; set; }
        public Tipo Tipo { get; set; }

    }
}
