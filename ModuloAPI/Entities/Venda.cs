using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloAPI.Entities
{
    private static readonly string[] STATUS = new[]
    {
        "Pagamento aprovado", "Enviado para transportadora", "Entregue", "Cancelada"
    };

    public class Venda
    {
        private int _id {get; set;}

        public Venda()
        {
            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
        }

        public Venda(int id)
        {
            _id = id;
            
            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
        }
    }
}