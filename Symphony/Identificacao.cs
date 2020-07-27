using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symphony
{
    class Identificacao
    {
        private Int64 id_usuario = 1;
        public Int64 Id_Usuario
        {
            get
            {
                return id_usuario;
            }
            set
            {
                id_usuario = value;
            }
        }
        
    }
}
