using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.Final
{
    class Mascotera<T>
    {
        #region Atributos

        private List<T> _miLista;

        #endregion

        #region Propiedades

        public T this[int index]
        {
                get
                {
                    return _miLista[index];
                }

                set
                {
                    _miLista[index] = value;
                }
         }


        public List<T> Lista
        {    
            get { return this._miLista; }
        }

        #endregion

        #region Constructores

        public Mascotera()
        {
            this._miLista = new List<T>();
        }

        #endregion

        #region Métodos


        public static Mascotera<T> operator +(Mascotera<T> M, T a)
        {
            M._miLista.Add(a);
            return M;
        }


        #endregion



    }
}
