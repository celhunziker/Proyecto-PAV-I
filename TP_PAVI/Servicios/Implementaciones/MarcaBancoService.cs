﻿using AppBTS.Datos.Daos;
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
    internal class MarcaBancoService : IMarcaBancoService
    {
        private IMarcaBanco dao;
        public MarcaBancoService()
        {
            dao = new MarcaBancoDao();
        }
        public List<Marca_Banco> traerTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
