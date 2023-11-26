using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitflow_project
{
    internal class entidad
    {
        public String ruta { get; set; }
        public String destino { get; set; }
        public String hora_partida { get; set; }
        public String hora_llegada { get; set; }
        public int precio { get; set; }
        public database db { get; set; }


        private entidad() { }

        private static entidad _instance;

        public static entidad GetInstance()
        {
            if (_instance == null)
            {
                _instance = new entidad();
            }
            return _instance;
        }
    }

}
