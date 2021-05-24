using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarlonLtda.CursoWeb.Aplicacao.Config
{
public static    class ExtensaoServico
    {
        public static IServiceCollection AdicionarServico(this IServiceCollection service)
        {
            return service;
        }
    }
}
