using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.App.Infra
{
    public class ConfigureDI
    {
        public static ServiceCollection? Services;
        public static IServiceProvider ServicesProvider;


        public static void ConfigureServices()
        {
            #region Banco_de_Dados
            Services = new ServiceCollection();
            var strCon = File.ReadAllText("Config/ConfigBanco.txt");

            Services.AddDbContext<MySQLContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure();
                });
            });
            #endregion

            #region Repositórios
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            #endregion

            #region Formulários
            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
