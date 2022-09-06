using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C02_La_estanteria.clases
{
    internal class Estante
    {
        private Producto[] _productos;
        private int _ubicacionEstante;

        private Estante(int capacidad)
        {
            _productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            _ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos {
            get { return _productos; }
        }
        
        public static string MostrarEstante(Estante e)
        {
            string ret;
            StringBuilder sb = new StringBuilder();
            int len = e._productos.Length;

            for (int i = 0; i < len; i++)
            {
                if (e._productos[i] is not null) //se usa is not null porque el operador == esta sobrecargado
                {
                    sb.AppendLine(Producto.MostrarProducto(e._productos[i]));
                }
            }
            return ret = sb.ToString();
        }
        public static bool operator == (Estante e, Producto p)
        {
            bool ret = false;
            int len = e._productos.Length;
            for(int i = 0; i < len; i++)
            {
                if (e._productos[i] is not null)
                {
                    if (e._productos[i] == p)
                    {
                        ret = true;
                    }
                    break;
                }
            }
            return ret;
        }
        public static bool operator != (Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator + (Estante e, Producto p)
        {
            bool ret = false;
            int len;
            if(e != p)
            {
                len = e._productos.Length;
                for(int i = 0; i < len; i++)
                {
                    if(e._productos[i] is null)
                    {
                        e._productos[i] = p;
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            if(e == p)
            {
                int len = e._productos.Length;
                for(int i = 0; i < len; i++)
                {
                    if (e._productos[i] == p)
                    {
                        e._productos[i] = null;
                        break;
                    }
                }
            }

            return e;
        }
    }
}
