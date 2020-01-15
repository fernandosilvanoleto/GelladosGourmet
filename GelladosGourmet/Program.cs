using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace GelladosGourmet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        /*
         * NIVELAMENTO MVC - 15/01/2020
         * 
         * NIVELAMENTO MVC PARA APLICAÇÕES WEB COM TEMPLATE ENGINE
        
        Responsabilidades no MVC

        Model
            estrutura dos dados e suas transformações (domain model)
            também chamado de "o sistema"
            composto de ENTITES E SERVICES (relacionados às entities)
                repositórios (objetos que acessam dados persistentes)
            coração do negócio
            regra de negócio
            inteligência do sistema
            acesso ao banco de dados

        Controllers
            receber e tratar as interações do usuário com o sistema
            receber as ações
            intermediário

        Views
            definir a estrutura e comportamento das telas
            apresentação

        
        Comunicação entre as camadas ==>

        View (Telas) com:
            Controlador

        Controlador (Requisições) com:
            View
            Model

        Model com:
            Controlador

        Model dividido em:
            Service Layer - Entities
            Data Access Layer - Entities

         */



    }
}
