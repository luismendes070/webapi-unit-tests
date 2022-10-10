using ModuloAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ModuloAPI.Context
{
    public class AgendaContext : DBContext
    {
        public AgendaContext(DBContextOptions<AgendaContext> options) : base(options) { }
    }

    public DBSet<Venda> Vendas { get; set; }
}
