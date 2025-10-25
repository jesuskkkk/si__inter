using System;
using System.Collections.Generic;
using System.Text;

namespace ClassL_simu
{
    public interface I_DiccionarioInstrumento
    {
        void AgregarHistorial(string id, string detalle);
        public Dictionary<string, object> ConsultarHistorial(string id);
    }
}
