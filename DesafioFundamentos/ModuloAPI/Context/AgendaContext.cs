using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
    public class AgendaContext : Dbcontext
    {
       public AgendaContext(DbcontextOptions<AgendaContext> options) : base(options) 
       {

       }
       public DbSet<Contato> contatos {get; set;}
    }
}