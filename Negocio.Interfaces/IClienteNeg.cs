﻿using Dominio.Cliente;

namespace Negocio.Interface
{
    public interface IClienteNeg
    {
        long Salvar(Cliente cliente);
        void Salvar(object v);
    }
}
