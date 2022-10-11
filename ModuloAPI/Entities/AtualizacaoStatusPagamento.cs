using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloAPI.Entities
{
    public class AtualizacaoStatusPagamento
    {
        public string _status { get; set; }

        private static readonly string[] STATUS = new[]
        {
            "Aguardando Pagamento",
            "Pagamento Aprovado",
            "Cancelada",
            "Enviado para transportadora",
            "entregue"
        };

        public AtualizacaoStatusPagamento()
        {
            _status = STATUS[0];

            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
        }

        public AtualizacaoStatusPagamento(int id)
        {
            _id = id;

            setStatus(STATUS[0]);

            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
        }
    }
}
