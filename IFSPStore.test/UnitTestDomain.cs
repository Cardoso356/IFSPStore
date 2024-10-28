using IFSPStore.Domain.Entities;
using System.Diagnostics;
using System.Text.Json;

namespace IFSPStore.test
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void TestCidade()
        {
            Cidade cidade = new Cidade(1, "Birigui", "SP");

            Debug.WriteLine(JsonSerializer.Serialize(cidade));

            Assert.AreEqual(cidade.Nome, "Birigui");
            Assert.AreEqual(cidade.Estado, "SP");
        }

        [TestMethod]
        public void TestGrupo()
        {
            Grupo grupo = new Grupo(1, "Limpeza");
            Debug.WriteLine(JsonSerializer.Serialize(grupo));

            Assert.AreEqual(grupo.Nome, "Limpeza");
        }

        [TestMethod]
        public void TestProduto()
        {
            Produto produto = new Produto(1, "Sabão em pó OMO",15,5, DateTime.Parse("2002/05/03 05:42:00"), 5);
            Debug.WriteLine(JsonSerializer.Serialize(produto));

            Assert.AreEqual(produto.Nome, "Sabão em pó OMO");
            Assert.AreEqual(produto.Preco, 15);
            Assert.AreEqual(produto.Quantidade, 5);
            Assert.AreEqual(produto.DataCompra, DateTime.Parse("2002/05/03 05:42:00"));
            Assert.AreEqual(produto.UnidadeVenda, 5);
        }

        [TestMethod]
        public void TestUsuario()
        {
            Usuario usuario = new Usuario(1,"Leonardo","1234","Leo12","leo@gmail.com", DateTime.Parse("2002/05/03 05:42:00"), DateTime.Parse("2002/05/05 22:00:00"), true);
            Debug.WriteLine(JsonSerializer.Serialize(usuario));

            Assert.AreEqual(usuario.Nome, "Leonardo");
            Assert.AreEqual(usuario.Senha, "1234");
            Assert.AreEqual(usuario.Login, "Leo12");
            Assert.AreEqual(usuario.Email, "leo@gmail.com");
            Assert.AreEqual(usuario.DataCadastro, DateTime.Parse("2002/05/03 05:42:00"));
            Assert.AreEqual(usuario.DataLogin, DateTime.Parse("2002/05/05 22:00:00"));
            Assert.AreEqual(usuario.Binary, true);
        }

        [TestMethod]
        public void TestCliente()
        {
            Cidade cidade = new Cidade(1, "Birigui", "SP");

            Debug.WriteLine(JsonSerializer.Serialize(cidade));

            Assert.AreEqual(cidade.Nome, "Birigui");
            Assert.AreEqual(cidade.Estado, "SP");

            Cliente cliente = new Cliente(1, "Alan", "Rua Padre Geraldo", "Fátima", "067.278.132-26", cidade);
            Debug.WriteLine(JsonSerializer.Serialize(cliente));

            Assert.AreEqual(cliente.Nome, "Alan");
            Assert.AreEqual(cliente.Endereco, "Rua Padre Geraldo");
            Assert.AreEqual(cliente.Bairro, "Fátima");
            Assert.AreEqual(cliente.Documento, "067.278.132-26");
            Assert.AreEqual(cliente.Cidade, cidade);
        }

        [TestMethod]
        public void TestVenda()
        {
            Usuario usuario = new Usuario(1, "Leonardo", "1234", "Leo12", "leo@gmail.com", DateTime.Parse("2002/05/03 05:42:00"), DateTime.Parse("2002/05/05 22:00:00"), true);

            Cidade cidade = new Cidade(1, "Birigui", "SP");

            Cliente cliente = new Cliente(1, "Alan", "Rua Padre Geraldo", "Fátima", "067.278.132-26", cidade);

            Grupo grupo = new Grupo(1, "Limpeza");

            Produto produto = new Produto(1, "Sabão em pó OMO", 15, 5, DateTime.Parse("2002/05/03 05:42:00"), 5);

            List<VendaItem> itens = new List<VendaItem>();

            Venda venda = new Venda(1, DateTime.Parse("2002/06/08 12:42:00"), 45, usuario, cliente, itens); //venda

            VendaItem vendaitem = new VendaItem(1, produto, 5, 3, 8, venda); //vendaitem

            itens.Add(vendaitem); //adiciona a lista

            Debug.WriteLine(JsonSerializer.Serialize(venda));

            Assert.AreEqual(venda.Data, DateTime.Parse("2002/06/08 12:42:00"));
            Assert.AreEqual(venda.ValorTotal, 45);
            Assert.AreEqual(venda.Usuario, usuario);
            Assert.AreEqual(venda.Cliente, cliente);
            Assert.AreEqual(venda.Items, itens);
        }


    }
}