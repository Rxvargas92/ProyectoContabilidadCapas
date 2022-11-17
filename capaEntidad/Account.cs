﻿using capaDatos;
using capaEntidad;

namespace capaDatos
{
    [Serializable]
    public class Account
    {
        private long id;
        private String nombre;
        private float debe;
        private float haber;

        public long _Id { get => id; set => id = value; }
        public string _Nombre { get => nombre; set => nombre = value; }
        public float _Debe { get => debe; set => debe = value; }
        public float _Haber { get => haber; set => haber = value; }

        public Account(string nombre)
        {
            this._Nombre = nombre;
        }
        public Account(string nombre, int tipo, float monto, int debeOHaber, string fecha)
        {
            this.nombre = nombre;

            if (debeOHaber == 0)
            {
                this.debe = monto;
            }
            else
            {
                this.haber = monto;
            }
        }

    }
}