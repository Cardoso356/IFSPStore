using Microsoft.Extensions.DependencyInjection;
using IFSPStore.Repository.Context;
using Microsoft.EntityFrameworkCore;
using IFSPStore.Domain.Base;
using IFSPStore.Repository.Repository;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Services;
using AutoMapper;
using IFSPStore.Service.Validators;
using System.Text.Json;

namespace IFSPStore.Test
{
    //é o teste do service
    [TestClass] //para aparecer no gerenciador de testes
    public class UnitTestService
    {
        private ServiceCollection? services;

        public ServiceProvider ConfigureServices() //isso vai condifura a injeção de dependencia
        {
            services = new ServiceCollection();
            services.AddDbContext<MySQLContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPStore";
                var username = "root";
                var password = "ifsp"; //senha do MySQL
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password};";
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            services.AddSingleton(new MapperConfiguration(config =>
                            {
                                config.CreateMap<Usuario, Usuario>();
                            }).CreateMapper());
            return services.BuildServiceProvider(); 
        }

        [TestMethod]
        public void TestUsuario()
        {
            var sp = ConfigureServices();
            var usuarioService = sp.GetService<IBaseService<Usuario>>();
            var usuario = new Usuario()
            {
                Nome = "Murilo",
                Login = "mui",
                Email = "murilo@gmail.com",
                Senha = "123hgyug*!FG",
                DataCadastro = DateTime.Now,
                DataLogin = DateTime.Parse("2023-02-06 08:20:12"),
                Ativo = true
            };

            var result = usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            Console.Write(JsonSerializer.Serialize(result));


        }
    }
}
