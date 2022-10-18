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
                //DA EL MISMO ERROR QUE CON DESCUENTO
                string consultaDetalleCobro = "INSERT INTO Detalles_Cobros (id_factura, id_medio_cobro," +
                "id_marca_banco, id_marca_tarjeta, cuotas, monto, valor_cuota, codigo_autorizacion, borrado)" +
                " VALUES (" +
                id_factura + "," +
                itemCobro.Medio_pago.Id_medio_cobro + "," +
                itemCobro.Id_marca_banco.Id_marca_banco + "," +
                itemCobro.Id_marca_tarjeta.Id_Marca_Tarjeta + "," +
                itemCobro.Cuotas + "," +
                itemCobro.Valor_couta + "," +
                itemCobro.Codigo_confirmacion + ",0";
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
