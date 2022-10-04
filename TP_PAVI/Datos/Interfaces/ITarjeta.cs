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
        List<Tarjeta> RecuperarListaFiltrada(int idUsuario, int? id_marca_tarjeta, long? nro_tarjeta, string fecha_venc_mes, string fecha_venc_año);
        Tarjeta ObjectMapping(DataRow row);
        bool Create(Tarjeta tarjeta);
        bool Modificar(Tarjeta tarjeta);
        bool Eliminar(long nroTarjeta);
    }
}
