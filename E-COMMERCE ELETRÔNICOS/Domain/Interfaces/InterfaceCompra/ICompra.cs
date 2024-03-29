﻿using Domain.Interfaces.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceCompra
{
    public interface ICompra : IGeneric<Compra>
    {
        public Task<Compra> CompraPorEstado(string userId, EnumEstadoCompra estado);
    }
}
