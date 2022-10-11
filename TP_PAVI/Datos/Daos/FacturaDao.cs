using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Daos
{
    internal class FacturaDao : IFactura
    {
        public bool Create(Factura factura)
        {
            string consulta = "INSERT INTO Facturas (id_usuario_vendedor, id_tipo_factura, " +
                "total, id_descuento, id_usuario_cliente, fecha, nroFactura, borrado)" +
                            " VALUES (" +
                            factura.Id_usuario_vendedor.Id_usuario + "," +
                             factura.Tipo_factura.Id_tipo_factura + "," +
                            factura.Total + "," +
                            factura.Id_descuento.Id_descuento + "," +
                            factura.Id_cliente.Id_usuario + ", '"+
                            factura.Fecha.ToString("dd/MM/yyyy") + "'," +
                            factura.Nro_factura+ ",0)";


            BDHelper.obtenerInstancia().actualizar(consulta);
            foreach (var itemFactura in factura.FacturaDetalle)
            {
                string consultaDetalle = "INSERT INTO Detalles_Facturas (id_factura, cantidad, " +
                "subtotal, id_producto, borrado)" +
                            " VALUES (" +
                            factura.Id_factura + "," +
                             itemFactura.Cantidad + "," +
                            itemFactura.Subtotal + "," +
                            itemFactura.Id_producto.Id_producto + ",0)";
                BDHelper.obtenerInstancia().actualizar(consultaDetalle);
            }
            //VER ESTO
            return (BDHelper.obtenerInstancia().actualizar(consulta)) == 1;
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
