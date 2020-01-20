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

        /*
         * Nivelamento: Entity Framework - 20/01/2020
         * 
         * Problema:
               Uma grande dificuldade de se criar sistemas orientados a objetos juntamente com a comunicação com o banco de dados relacional!!!
         
        Outras Questões:
            Contexto de persistência (monitorar alterações nos objetos que estão atrelados a uma conexão em um dado momento)
                - Alterações
                - Transação
                - Concorrência

        Mapa de Identidade (cache de objetos já encarregados na memória)

        Carregamento tardio (lazy loading)

        Solução: Mapeamento Objeto-Relacional
        ORM (Object-Relational Mapping)
        Permite programar em nível de objetos e comunicar de forma transparente com um banco de dados relacional!!!

        Entity Framework é um ORM!!!

        Duas Principais Classes:
        DbContext
            um objeto DbContext encapsula uma sessão com o banco de dados (conectividade) para um determinado modelo de dados (representando por DbSet's)
                É usado para consultar e salvar entidades no banco de dados
                Definie quais entidades farão parte do modelo de dados do sistema
                Pode definir várias configurações
                É uma combinação dos padrões Unity of Work e Repository
                    Unity of Work
                        consistência
                        mantém uma lista de objetos afetados por uma transação e coordena a escrita de mudanças e trata possíveis problemas de concorrência
                    Repository
                        define um objeto capaz de realizar operações de acesso a dados (consultar, salvar, atualizar, deletar) para uma entidade

        DbSet<TEntity>
            genérico
            representa a coleção de entidades de um dado tipo em um contexto
            Tipicamente corresponde a uma tabela do banco de dados

        PROCESSO GERAL PARA SE EXECUTAR OPERAÇÕES

                LINQ ==> DbSet (operações de LINQ e lambda) ==> SQL (conversão em tempo de execução comandos LINQ e lambda em SQL) ==> Banco de Dados (Importante saber)

         */

        /*
         * Entendendo a estrtutura do projeto GelladosGourment - 20/01/2020
         * Explicação e teoria
         */


    }
}
