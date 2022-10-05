using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Interfaces
{
    internal interface ITarjetaService
    {
        List<Tarjeta> traerTodos(int idUsuario);
        List<Tarjeta> traerFiltrados(int idUsuario, int? id_marca_tarjeta, long? nro_tarjeta, string fecha_venc_mes, string fecha_venc_año) ;
        bool Crear(Tarjeta tarjeta);
        bool Modificar(Tarjeta tarjeta);
        bool Eliminar(long nro_tarjeta);
        Tarjeta RecuperarPorNro(long nro_tarjeta);
        bool ExisteTarjeta(long nro_tarjeta);
    }
}
