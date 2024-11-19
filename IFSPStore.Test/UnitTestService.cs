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
                var password = "cardoso"; //senha do MySQL
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

            services.AddScoped<IBaseRepository<Grupo>, BaseRepository<Grupo>>();
            services.AddScoped<IBaseService<Grupo>, BaseService<Grupo>>();
            services.AddSingleton(new MapperConfiguration(config =>
                            {
                                config.CreateMap<Grupo, Grupo>();
                            }).CreateMapper());


            services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            services.AddSingleton(new MapperConfiguration(config =>
                            {
                                config.CreateMap<Cidade, Cidade>();
                            }).CreateMapper());


            services.AddScoped<IBaseRepository<Produto>, BaseRepository<Produto>>();
            services.AddScoped<IBaseService<Produto>, BaseService<Produto>>();
            services.AddSingleton(new MapperConfiguration(config =>
                            {
                                config.CreateMap<Produto, Produto>();
                            }).CreateMapper());


            services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            services.AddSingleton(new MapperConfiguration(config =>
                            {
                                config.CreateMap<Cliente, Cliente>();
                            }).CreateMapper());


            services.AddScoped<IBaseRepository<Venda>, BaseRepository<Venda>>();
            services.AddScoped<IBaseService<Venda>, BaseService<Venda>>();
            services.AddSingleton(new MapperConfiguration(config =>
                            {
                                config.CreateMap<Venda, Venda>();
                            }).CreateMapper());


            services.AddScoped<IBaseRepository<VendaItem>, BaseRepository<VendaItem>>();
            services.AddScoped<IBaseService<VendaItem>, BaseService<VendaItem>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<VendaItem, VendaItem>();
            }).CreateMapper());


            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestUsuario() //método da inserção
        {
            var sp = ConfigureServices();
            var usuarioService = sp.GetService<IBaseService<Usuario>>();
            var usuario = new Usuario()
            {
                Nome = "Guilherme Cardoso da Silva",
                Login = "Cardoso",
                Email = "cardoso.silva1@gmail.com",
                Senha = "123hgyug*!FG",
                DataCadastro = DateTime.Now,
                DataLogin = DateTime.Parse("2023-02-06 08:20:12"),
                Ativo = true
            };

            var result = usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            Console.Write(JsonSerializer.Serialize(result));

        }

        [TestMethod]
        public void TestSelectUsuario() //método da listagem
        {
            var sp = ConfigureServices();
            var UsuarioService = sp.GetService<IBaseService<Usuario>>();

            var result = UsuarioService.Get<Usuario>();

            Console.Write(JsonSerializer.Serialize(result));
        }


        [TestMethod]
        public void TestGrupo()
        {
            var sp = ConfigureServices();
            var grupoService = sp.GetService<IBaseService<Grupo>>();
            var grupo = new Grupo()
            {
                Nome = "Limpeza"
            };

            var result = grupoService.Add<Grupo, Grupo, GrupoValidator>(grupo);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectGrupo() //método da listagem
        {
            var sp = ConfigureServices();
            var grupoService = sp.GetService<IBaseService<Grupo>>();

            var result = grupoService.Get<Grupo>();

            Console.Write(JsonSerializer.Serialize(result));

        }


        [TestMethod]
        public void TestProduto() //depende de grupo
        {
            var sp = ConfigureServices();
            var produtoService = sp.GetService<IBaseService<Produto>>();
            var produto = new Produto()
            {
                Nome = "Detergente",
                Preco = 5.00f,
                Quantidade = 2,
                DataCompra = DateTime.Parse("2024-11-19 10:32:10"),
                UnidadeVenda = "2"
                //Grupo = 
            };
            var result = produtoService.Add<Produto, Produto, ProdutoValidator>(produto);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectProduto() //método da listagem
        {
            var sp = ConfigureServices();
            var produtoService = sp.GetService<IBaseService<Produto>>();

            var result = produtoService.Get<Produto>();

            Console.Write(JsonSerializer.Serialize(result));

        }

        [TestMethod]
        public void TestCidade()
        {
            var sp = ConfigureServices();
            var cidadeService = sp.GetService<IBaseService<Cidade>>();
            var cidade = new Cidade()
            {
                Nome = "Penápolis",
                Estado = "SP"
            };

            var result = cidadeService.Add<Cidade, Cidade, CidadeValidator>(cidade);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectCidade() //método da listagem
        {
            var sp = ConfigureServices();
            var cidadeService = sp.GetService<IBaseService<Cidade>>();

            var result = cidadeService.Get<Cidade>();

            Console.Write(JsonSerializer.Serialize(result));

        }


        [TestMethod]
        public void TestCliente() //depende de cidade
        {
            var sp = ConfigureServices();
            var clienteService = sp.GetService<IBaseService<Cliente>>();
            var cliente = new Cliente()
            {
                Nome = "Michael Jackson",
                Documento = "49282918831",
                Endereco = "Rua dos Ricos",
                Bairro = "Beverly Hills"
                //Cidade = 
            };

            var result = clienteService.Add<Cliente, Cliente, ClienteValidator>(cliente);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectCliente() //método da listagem
        {
            var sp = ConfigureServices();
            var clienteService = sp.GetService<IBaseService<Cliente>>();

            var result = clienteService.Get<Cliente>();

            Console.Write(JsonSerializer.Serialize(result));

        }


    }
}
