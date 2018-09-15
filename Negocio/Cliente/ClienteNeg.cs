using Dominio.Contratos;
using Dominio.Results;
using Negocio.Interface;
using Repositorio.Cliente;
using System;
using System.Collections.Generic;

namespace Negocio.Cliente
{
    public class ClienteNeg : IClienteNeg
    {
        private readonly IClienteRep _clienteRep;

        public ClienteNeg()
        {
            _clienteRep = new ClienteRep();
        }

        public Step3Result Consultar(object v)
        {
            return new Step3Result
            {
                DataEmissao = DateTime.Now,
                Contribuicoes = new List<ContribuicaoEventoResult>{
                    new ContribuicaoEventoResult
                    {
                        Contribuinte = "Jeferson de Souza",
                        ValorContruibuido = 600M
                    },
                    new ContribuicaoEventoResult
                    {
                        Contribuinte = "Carlos Pereira",
                        ValorContruibuido = 400M
                    },
                    new ContribuicaoEventoResult
                    {
                        Contribuinte = "Rafael",
                        ValorContruibuido = 100M
                    }
                },
                Status = new List<StatusContribuicaoResult>
                {
                    new StatusContribuicaoResult
                    {
                        Mensagem = "Aproveite o seu aniversário",
                        Status = "Registrado"
                    },
                    new StatusContribuicaoResult
                    {
                        Mensagem = "Aproveite o seu aniversário",
                        Status = "Processando"
                    },
                    new StatusContribuicaoResult
                    {
                        Mensagem = "Aproveite o seu aniversário",
                        Status = "Processado"
                    }
                }
            };            
        }

        public long Salvar(Dominio.Cliente.Cliente cliente)
        {
            return _clienteRep.Salvar(cliente);
        }

        public void Salvar(object v)
        {
            throw new System.NotImplementedException();
        }
    }
}
