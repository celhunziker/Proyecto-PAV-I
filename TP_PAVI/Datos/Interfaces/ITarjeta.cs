using AppBTS.Entidades;
using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    interface ITarjeta
    {
        List<Tarjeta> RecuperarTodos(int idUsuario);
        List<Tarjeta> RecuperarListaFiltrada(List<Tarjeta> lista, int id_marca_tarjeta, long nro_tarjeta, DateTime fecha_venc);
        Tarjeta ObjectMapping(DataRow row);
        bool Create(Tarjeta tarjeta);
        bool Modificar(Tarjeta tarjeta);
        bool Eliminar(long nroTarjeta);
    }
}
