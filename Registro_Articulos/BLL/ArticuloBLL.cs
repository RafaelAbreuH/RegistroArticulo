using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Registro_Articulos.DAL;
using Registro_Articulos.Entidades;

namespace Registro_Articulos.BLL
{
    public class ArticuloBLL
    {
        public static bool Guardar(Articulo articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Articulo.Add(articulo) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }

                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Articulo articulo)
        {

            bool paso = false;

            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(articulo).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;

                }

                contexto.Dispose();

            }

            catch (Exception)
            {

                throw;

            }

            return paso;



        }

        public static bool Eliminar(int id)
        {

            bool paso = false;

            Contexto contexto = new Contexto();

            try
            {

                Articulo articulo = contexto.Articulo.Find(id);
                contexto.Articulo.Remove(articulo);
                if (contexto.SaveChanges() > 0)
                {

                    paso = true;

                }

                contexto.Dispose();

            }

            catch (Exception)
            {

                throw;

            }

            return paso;

        }

        public static Articulo Buscar(int id)
        {

            Articulo articulo = new Articulo();
            Contexto contexto = new Contexto();

            try
            {
                articulo = contexto.Articulo.Find(id);
                contexto.Dispose();

            }

            catch (Exception)
            {

                throw;

            }

            return articulo;

        }

        public static List<Articulo> GetList(Expression<Func<Articulo, bool>> expression)
        {

            List<Articulo> Articulo = new List<Articulo>();
            Contexto contexto = new Contexto();

            try
            {

                Articulo = contexto.Articulo.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return Articulo;
        }

    }
}