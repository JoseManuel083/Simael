using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simael.Clases
{
    class EquipoElectronico
    {
        private string sicipo;

        public string Sicipo
        {
            get { return sicipo; }
            set { sicipo = value; }
        }
        private string folio;

        public string Folio
        {
            get { return folio; }
            set { folio = value; }
        }
        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        private string noSerie;

        public string NoSerie
        {
            get { return noSerie; }
            set { noSerie = value; }
        }
        private string estadoFisico;

        public string EstadoFisico
        {
            get { return estadoFisico; }
            set { estadoFisico = value; }
        }
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
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
        private string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        private string inventario;

        public string Inventario
        {
            get { return inventario; }
            set { inventario = value; }
        }
    }
}
