 using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Daos
{
    internal class FacturaDao : IFactura
    {
        public bool InsertarFacturaConDetalle(Factura oFactura, Detalle_Factura oDetalleFactura)
        {
            //bool aux = false;

            //string consultaFactura = "INSERT into Facturas (id_usuario_vendedor,id_tipo_factura,total,id_descuento,id_usuario_cliente,fecha,nroFactura)"
            //                    + "VALUES (" + oFactura.Id_usuario_vendedor + ","
            //                    + oFactura.Tipo_factura.Id_tipo_factura + ","
            //                    + oFactura.Total + ","
            //                    + oFactura.Id_descuento + ","
            //                    + oFactura.Id_cliente + ",'"
            //                    + oFactura.Fecha.ToString("yyyy/MM/dd") + "',"
            //                    + oFactura.Nro_factura + ")";
            //BDHelper.obtenerInstancia().conectarConTransaccion();
            //BDHelper.obtenerInstancia().EjecutarConTransaccion(consultaFactura);

            ////Recuperar ID nuevo
            //int nuevoId = Convert.ToInt32(BDHelper.obtenerInstancia().ConsultaSQLScalar("SELECT @@identity"));
            //if(nuevoId == null)
            //{
            //    nuevoId = 1;
            //}
            //oDetalleFactura.Id_factura = ObtenerFactura(nuevoId);

            ////Insertar Historia con Nuevo ID
            //string consultaDetalleFactura = "INSERT into Detalles_Facturas (id_factura,cantidad,subtotal,id_producto)"
            //                            + "VALUES (" + oDetalleFactura.Id_factura.Id_factura + ","
            //                            + oDetalleFactura.Cantidad + ","
            //                            + oDetalleFactura.Subtotal + ", "
            //                            + oDetalleFactura.Id_producto + ")";

            //BDHelper.obtenerInstancia().EjecutarConTransaccion(consultaDetalleFactura);
            //aux = BDHelper.obtenerInstancia().Desconectar();
            return true;
        }

        internal DataTable RecuperarProductosAgrupados(string fechaDesde, string fechaHasta, int orden, float monto_minimo, float monto_maximo)
        {
            string strSql = "SELECT p.id_producto as Id_producto, p.nombre as Producto, p.precio as Precio, SUM(df.cantidad) as Cantidad FROM FACTURAS f JOIN " +
                "DETALLES_FACTURAS df ON f.id_factura=df.id_factura JOIN PRODUCTOS p ON p.id_producto=df.id_producto" +
                " WHERE f.fecha BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "' GROUP BY p.nombre, p.precio, p.id_producto " +
                " HAVING SUM(df.cantidad*p.precio) BETWEEN " + monto_minimo + " AND " + monto_maximo;
            switch (orden)
            {
                case 0:
                    strSql += " ORDER BY p.id_producto";
                    break;
                case 1:
                    strSql += " ORDER BY p.nombre";
                    break;
                case 2:
                    strSql += " ORDER BY SUM(df.cantidad)";
                    break;
                case 3:
                    strSql += " ORDER BY SUM(df.cantidad*p.precio)";
                    break;
            }
            return BDHelper.obtenerInstancia().consultar(strSql);
        }
        internal DataTable RecuperarMediosPagoAgrupados(string fechaDesde, string fechaHasta, int orden, float monto_minimo, float monto_maximo)
        {
            string strSql = "SELECT mp.id_medio_cobro AS Id_medio_pago, mp.nombre AS Medio_pago, " +
                "SUM(dc.monto) as Ingreso FROM FACTURAS F " +
                "JOIN Detalles_Cobros DC ON f.id_factura=dc.id_factura " +
                "JOIN Medios_Pagos mp ON mp.id_medio_cobro=dc.id_medio_cobro " +
                " WHERE f.fecha BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "" +
                "'" +
                " GROUP BY mp.nombre, mp.id_medio_cobro" +
                " HAVING SUM(dc.monto) BETWEEN " + monto_minimo +" AND " + monto_maximo;
            if (orden == 0)
            {
                strSql += " ORDER BY mp.id_medio_cobro";
            }
            else
            {
                strSql += " ORDER BY mp.nombre";
            }
            return BDHelper.obtenerInstancia().consultar(strSql);
        }
        internal DataTable RecuperarTipoProductosAgrupados(string fechaDesde, string fechaHasta, int orden)
        {
            string strSql = "SELECT tp.id_tipo_producto as Id_tipo_producto, tp.nombre as Nombre, tp.descripcion as Descripcion, SUM(df.cantidad) as Cantidad FROM FACTURAS f JOIN " +
                "DETALLES_FACTURAS df ON f.id_factura=df.id_factura JOIN PRODUCTOS p ON p.id_producto=df.id_producto JOIN TIPOS_PRODUCTOS tp ON tp.id_tipo_producto=p.tipo_producto" +
                " WHERE f.fecha BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "' GROUP BY tp.nombre, tp.id_tipo_producto, tp.descripcion ";
            switch (orden)
            {
                case 0:
                    strSql += " ORDER BY tp.id_tipo_producto";
                    break;
                case 1:
                    strSql += " ORDER BY tp.nombre";
                    break;
                case 2:
                    strSql += " ORDER BY SUM(df.cantidad)";
                    break;
            }
            return BDHelper.obtenerInstancia().consultar(strSql);
        }

        internal DataTable RecuperarVendedorAgrupados(string fechaDesde, string fechaHasta, int orden, float monto_minimo, float monto_maximo)
        {
            string strSql = "SELECT v.id_usuario AS Id_vendedor, v.nombre AS Nombre, " +
                "SUM(dc.monto) as Ingreso FROM FACTURAS F " +
                "JOIN Detalles_Cobros DC ON f.id_factura=dc.id_factura " +
                "JOIN Usuarios v ON v.id_usuario=f.id_usuario_vendedor " +
                " WHERE f.fecha BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "" +
                "'" +
                " GROUP BY v.nombre, v.id_usuario" +
                " HAVING SUM(dc.monto) BETWEEN " + monto_minimo + " AND " + monto_maximo;
            if (orden == 0)
            {
                strSql += " ORDER BY v.id_usuario";
            }
            else
            {
                strSql += " ORDER BY v.nombre";
            }
            return BDHelper.obtenerInstancia().consultar(strSql);
        }

        //private Factura ObtenerFactura(int nuevoId)
        //{
        //    string strSql = string.Concat(" SELECT id_factura, ",
        //                                       "        f.id_usuario_vendedor, ",
        //                                       "        f.id_tipo_factura, ",
        //                                       "        f.total, ",
        //                                       "        f.id_descuento, ",
        //                                       "        f.borrado, ",
        //                                       "        f.id_usuario_cliente, ",
        //                                       "        f.fecha, ",
        //                                       "        f.nroFactura ",
        //                                       "   FROM Facturas f INNER JOIN Usuarios u1 ON f.id_usuario_vendedor=u1.id_usuario",
        //                                       " INNER JOIN Usuarios u2 ON f.id_usuario_cliente=u2.id_usuario",
        //                                       " INNER JOIN Tipos_Facturas tf ON f.id_tipo_factura=tf.id_tipo_factura",
        //                                       " INNER JOIN Descuento d ON f.id_descuento=d.id_descuento",
        //                                       "  WHERE f.borrado=0 AND f.id_factura = ", Convert.ToInt64(nuevoId));
        //    DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
        //    if (tabla.Rows.Count > 0)
        //    {
        //        return ObjectMapping(tabla.Rows[0]);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        //private Factura ObjectMapping(DataRow dataRow)
        //{
        //    Factura factura = new Factura();
        //    factura.Id_factura = Convert.ToInt32(dataRow[0]);

        //    //LLAMAR USUARIO DAO Y QUE NOS CREE EL LOS USUARIOS

        //}
        public bool Create(Factura factura)
        {
            int descuento;
            string consulta;
            if (factura.Id_descuento != null)
            {
                descuento = factura.Id_descuento.Id_descuento;
                consulta = "INSERT INTO Facturas (id_usuario_vendedor, id_tipo_factura, " +
                "total, id_descuento, id_usuario_cliente, fecha, nroFactura, borrado)" +
                            " VALUES (" +
                            factura.Id_usuario_vendedor.Id_usuario + "," +
                             factura.Tipo_factura.Id_tipo_factura + "," +
                            factura.Total + "," +
                            descuento + "," +
                            factura.Id_cliente.Id_usuario + ", '" +
                            factura.Fecha.ToString("yyyy/MM/dd") + "'," +
                            "NULL" + ",0)";
            } else
            {
                consulta = "INSERT INTO Facturas (id_usuario_vendedor, id_tipo_factura, " +
                "total, id_descuento, id_usuario_cliente, fecha, nroFactura, borrado)" +
                            " VALUES (" +
                            factura.Id_usuario_vendedor.Id_usuario + "," +
                             factura.Tipo_factura.Id_tipo_factura + "," +
                            factura.Total + "," +
                            "NULL" + "," +
                            factura.Id_cliente.Id_usuario + ", '" +
                            factura.Fecha.ToString("yyyy/MM/dd") + "'," +
                            "NULL" + ",0)";
            }




            BDHelper.obtenerInstancia().conectarConTransaccion();
            BDHelper.obtenerInstancia().EjecutarConTransaccion(consulta);
            var id_factura = BDHelper.obtenerInstancia().ConsultaSQLScalar("SELECT IDENT_CURRENT('Facturas')");
            factura.Id_factura =Convert.ToInt32(id_factura);
            string nroFactura = (id_factura.ToString()).PadLeft(8, '0');
            consulta = "UPDATE FACTURAS SET nroFactura='" + nroFactura + "' WHERE id_factura=" + id_factura;
            BDHelper.obtenerInstancia().EjecutarConTransaccion(consulta);
            foreach (Detalle_Factura itemFactura in factura.FacturaDetalle)
                {
                    string consultaDetalle = "INSERT INTO Detalles_Facturas (id_factura, cantidad, " +
                    "subtotal, id_producto, borrado)" +
                                " VALUES (" +
                                id_factura + "," +
                                 itemFactura.Cantidad + "," +
                                itemFactura.Subtotal + "," +
                                itemFactura.Id_producto.Id_producto + ",0)";

                    BDHelper.obtenerInstancia().EjecutarConTransaccion(consultaDetalle); 
                     
                }
                foreach (Detalle_Cobro itemCobro in factura.DetalleCobro) 
                {
                Object marca_banco = "NULL";
                Object marca_tarjeta = "NULL";
                Object cuotas = "NULL";
                Object valor_cuota = "NULL";
                Object cod_confirmacion = "NULL";
                if (itemCobro.Id_marca_banco != null)
                {
                    marca_banco = itemCobro.Id_marca_banco.Id_marca_banco;
                }
                if (itemCobro.Id_marca_tarjeta != null)
                {
                    marca_tarjeta = itemCobro.Id_marca_tarjeta.Id_Marca_Tarjeta;
                }
                if (itemCobro.Cuotas != 0)
                {
                    cuotas = itemCobro.Cuotas;
                }
                if (itemCobro.Valor_couta != 0)
                {
                    valor_cuota = itemCobro.Valor_couta;
                }
                if (itemCobro.Codigo_confirmacion != 0)
                {
                    cod_confirmacion = itemCobro.Codigo_confirmacion;
                }
                string consultaDetalleCobro = "INSERT INTO Detalles_Cobros (id_factura, id_medio_cobro," +
                "id_marca_banco, id_marca_tarjeta, cuotas, monto, valor_cuota, codigo_autorizacion, borrado)" +
                " VALUES (" +
                id_factura + "," +
                itemCobro.Medio_pago.Id_medio_cobro + "," +
                marca_banco + "," +
                marca_tarjeta + "," +
                cuotas + "," +
                itemCobro.Monto + "," +
                valor_cuota + "," +
                cod_confirmacion + ",0)";
                BDHelper.obtenerInstancia().EjecutarConTransaccion(consultaDetalleCobro);
            }
            
            //VER ESTO
            return BDHelper.obtenerInstancia().Desconectar();
        }

        //public bool Create(Factura factura)
        //{
        //    BDHelper dbh = new BDHelper();
        //    try
        //    {
        //        dbh.Open();
        //        dm.BeginTransaction();

        //        string sql = string.Concat("INSERT INTO [dbo].[Facturas] ",
        //                                    "           ([nro_factura]   ",
        //                                    "           ,[fecha]         ",
        //                                    "           ,[cliente]       ",
        //                                    "           ,[tipoFactura]   ",
        //                                    "           ,[subtotal]    ",
        //                                    "           ,[descuento]    ",
        //                                    "           ,[borrado])      ",
        //                                    "     VALUES                 ",
        //                                    "           (@nro_factura   ",
        //                                    "           ,@fecha          ",
        //                                    "           ,@cliente        ",
        //                                    "           ,@tipoFactura    ",
        //                                    "           ,@subtotal     ",
        //                                    "           ,@descuento     ",
        //                                    "           ,@borrado)       ");


        //        var parametros = new Dictionary<string, object>();
        //        parametros.Add("nro_factura", factura.NroFactura);
        //        parametros.Add("fecha", factura.Fecha);
        //        parametros.Add("cliente", factura.Cliente.IdCliente);
        //        parametros.Add("tipoFactura", factura.TipoFactura.IdTipoFactura);
        //        parametros.Add("subtotal", factura.SubTotal);
        //        parametros.Add("descuento", factura.Descuento);
        //        parametros.Add("borrado", false);
        //        dm.EjecutarSQLCONPARAMETROS(sql, parametros);

        //        var newId = dm.ConsultaSQLScalar(" SELECT @@IDENTITY");
        //        factura.IdFactura = Convert.ToInt32(newId);


        //        foreach (var itemFactura in factura.FacturaDetalle)
        //        {
        //            string sqlDetalle = string.Concat(" INSERT INTO [dbo].[FacturasDetalle] ",
        //                                                "           ([id_factura]           ",
        //                                                "           ,[id_producto]          ",
        //                                                "           ,[precio_unitario]      ",
        //                                                "           ,[cantidad]             ",
        //                                                "           ,[borrado])             ",
        //                                                "     VALUES                        ",
        //                                                "           (@id_factura            ",
        //                                                "           ,@id_producto           ",
        //                                                "           ,@precio_unitario       ",
        //                                                "           ,@cantidad              ",
        //                                                "           ,@borrado)               ");

        //            var paramDetalle = new Dictionary<string, object>();
        //            paramDetalle.Add("id_factura", factura.IdFactura);
        //            paramDetalle.Add("id_producto", itemFactura.IdProducto);
        //            paramDetalle.Add("precio_unitario", itemFactura.PrecioUnitario);
        //            paramDetalle.Add("cantidad", itemFactura.Cantidad);
        //            paramDetalle.Add("borrado", false);

        //            dm.EjecutarSQLCONPARAMETROS(sqlDetalle, paramDetalle);
        //        }



        //        dm.Commit();

        //    }
        //    catch (Exception ex)
        //    {
        //        dm.Rollback();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        // Cierra la conexión 
        //        dm.Close();
        //    }
        //    return true;
        //}
    }
}
