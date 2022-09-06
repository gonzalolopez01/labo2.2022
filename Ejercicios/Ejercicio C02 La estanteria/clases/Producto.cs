using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_C02_La_estanteria.clases
{
    internal class Producto
    {
        private string _codigoDeBarras;
        private string _marca;
        private float _precio;

        public Producto(string marca, string codigo, float precio)
        {
            _codigoDeBarras = codigo;
            _marca = marca;
            _precio = precio;
        }
        public static explicit operator string(Producto p)
        {
            return p._codigoDeBarras;
        }
        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(p._marca + "-");
            sb.Append(p._codigoDeBarras + "-");
            sb.AppendLine(p._precio.ToString());

            return sb.ToString();
        }
        public string GetMarca{
            get { return _marca; }
            set { _marca = value; } 
        }
        public float GetPrecio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public static bool operator ==(Producto p, string cadena)
        {
            bool ret = false;
            if(p is not null)
            {
                ret = p._marca == cadena;
            }
            return ret;
            //return p._marca == cadena;
        }
        public static bool operator !=(Producto p, string cadena)
        {
            return !(p._marca == cadena);
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool ret = false;
            if(p1 is not null && p2 is not null)
            {
                ret = (p1._marca == p2._marca && p1._codigoDeBarras == p2._codigoDeBarras);
                //return p1 == p2._marca && p1._codigoDeBarras == p2._codigoDeBarras;
            }
            return ret;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
       /* public static bool operator ==(Producto p, string marca)
        {
            bool ret = false;
            if(p is not null)
            {
                ret = (p._marca == marca);
            }
            return ret;
        }
        public static bool operator != (Producto p, string marca)
        {
            return !(p == marca);
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool ret = false;
            if(p1 is not null && p2 is not null)
            {
                ret = (p1._marca == p2._marca && p1._codigoDeBarras == p2._codigoDeBarras);
            }
            return ret;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }*/
    }
}
