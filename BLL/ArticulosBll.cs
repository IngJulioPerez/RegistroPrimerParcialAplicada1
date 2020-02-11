using System;
using System.Collections.Generic;
using System.Text;
using RegistroPrimerParcial.Entidades;
using RegistroPrimerParcial.DAL;


namespace RegistroPrimerParcial.BLL
{
    public class ArticulosBll
    {
        public static Articulo Buscar(int ProductoId)
        {
            Contexto db = new Contexto();
            Articulo articulo = new Articulo();

            try
            {
                articulo = db.Articulo.Find(ProductoId);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return articulo;
        }

        public static bool Guardar(Articulo articulo)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Articulo.Add(articulo) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;

        }

        public static bool Eliminar(int ProductoId)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Articulo.Find(ProductoId);
                db.Entry(eliminar).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;

                paso = (db.SaveChanges() > 0);


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;

        }

        public static bool Editar(Articulo articulo)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(articulo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = (db.SaveChanges() > 0);

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }
    }

        
}
