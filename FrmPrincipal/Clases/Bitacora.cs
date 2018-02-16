using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simael.Clases
{
    class Bitacora
    {
        private string equipoTipo;

        public string EquipoTipo
        {
            get { return equipoTipo; }
            set { equipoTipo = value; }
        }
        private string equipoSOI;

        public string EquipoSOI
        {
            get { return equipoSOI; }
            set { equipoSOI = value; }
        }
        private string equipoNoFolio;

        public string EquipoNoFolio
        {
            get { return equipoNoFolio; }
            set { equipoNoFolio = value; }
        }
        private string equipoMarca;

        public string EquipoMarca
        {
            get { return equipoMarca; }
            set { equipoMarca = value; }
        }
        private string equipoModelo;

        public string EquipoModelo
        {
            get { return equipoModelo; }
            set { equipoModelo = value; }
        }
        private string equipoNoSerie;

        public string EquipoNoSerie
        {
            get { return equipoNoSerie; }
            set { equipoNoSerie = value; }
        }
        private string resguardante;

        public string Resguardante
        {
            get { return resguardante; }
            set { resguardante = value; }
        }
        private string area;

        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        private string falla;

        public string Falla
        {
            get { return falla; }
            set { falla = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public Bitacora(string equipoTipo, string equipoSOI,string equipoFolio) 
        {

        }


        public bool agregarRegistroBitacora()
        {

            return true;
        }

        public bool editarRegistroBitacora() 
        {
            return true;
        }

        public bool eliminarRegistroBitacora() 
        {
            return true;
        }
    }
}
