using System;
using System.Collections.Generic;
using System.Text;

namespace ClassL_simu
{
    public interface I_Instrumentos
    {
        public string id {  get; set; }
        public string name {  get; set; }
        public string Tipo {  get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime fecha { get; set; }
        public string EstodoCalibracion {  get; set; }

        public string GetDetalles {  get; set; }


    }
}
