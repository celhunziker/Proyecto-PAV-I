using AppBTS.Datos.Daos;
using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using AppBTS.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Implementaciones
{
    internal class TarjetaService : ITarjetaService
    {
        private ITarjeta dao;
        public TarjetaService()
        {
            dao = new TarjetaDao();
        }
        public bool Crear(Tarjeta tarjeta)
        {
            return dao.Create(tarjeta);
        }

        public bool Eliminar(long nro_tarjeta)
        {
            return dao.Eliminar(nro_tarjeta);
        }

        public bool ExisteTarjeta(long nro_tarjeta)
        {
            return dao.ExisteTarjeta(nro_tarjeta);
        }

        public bool Modificar(Tarjeta tarjeta)
        {
            return dao.Modificar(tarjeta);
        }

        public Tarjeta RecuperarPorNro(long nro_tarjeta)
        {
            return dao.RecuperarPorNro(nro_tarjeta);
        }

        public List<Tarjeta> traerFiltrados(int idUsuario, int? id_marca_tarjeta, long? nro_tarjeta, string fecha_venc_mes, string fecha_venc_anio)
        {
            return dao.RecuperarListaFiltrada(idUsuario, id_marca_tarjeta, nro_tarjeta, fecha_venc_mes, fecha_venc_anio);
        }

        public List<Tarjeta> traerTodos(int idUsuario)
        {
            return dao.RecuperarTodos(idUsuario);
        }
    }
}
