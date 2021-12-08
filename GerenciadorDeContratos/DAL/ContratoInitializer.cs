using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GerenciadorDeContratos.Models;


namespace GerenciadorDeContratos.DAL
{
    //public class ContratoInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ContratoContext>
    public class ContratoInitializer : System.Data.Entity.DropCreateDatabaseAlways<ContratoContext>
    {

        protected override void Seed(ContratoContext context)
        {

            var gestores = new List<Gestor>
            {
                new Gestor{ativo=1, dataNascimento=DateTime.Parse("1999-01-01"), cpf="112323", email="teste@gmail.com", enderecoCompleto="end", GestorID=1, nomeCompleto="jose", rg=12343356, senha="password"}
            };

            gestores.ForEach(s => context.Gestores.Add(s));
            context.SaveChanges();

            var contatos = new List<Contato>
            {
                new Contato{bairro="centro", celular=98, cep=76, cidade="Palmas", complemento="quarteto", dataNascimento=DateTime.Parse("2005-01-01"), email="exemplo123123123@gmail.com",enderecoEmpresa="jk", estado="Tocantins", fax="00012", funcao="supervisor", nome="eduardo", ContatoID=1, numero=4984, telefone=2387, telefoneComercial=4783},
                new Contato{bairro="norte", celular=92384938, cep=718237, cidade="Palmas", complemento="aeroporto", dataNascimento=DateTime.Parse("2001-01-01"), email="exemplo@gmail.com",enderecoEmpresa="404 norte", estado="Tocantins", fax="12312", funcao="gerente", nome="Carlos", ContatoID=2, numero=1232133, telefone=1498493, telefoneComercial=123981293}
            };

            contatos.ForEach(s => context.Contatos.Add(s));
            context.SaveChanges();

            var contratantes = new List<Contratante>
            {
                new Contratante{ContratanteID = 1, cnpj ="12367", razaoSocial="razao", porteDaEmpresa=500, ramoDeAtividade="vacinas", optantePeloSimples="optante", nomeFantasia="fantasia", inscricaoEstadual=1554894, inscricaoMunicipal=119829, ContatoID=1}
            };

            contratantes.ForEach(s => context.Contratantes.Add(s));
            context.SaveChanges();

            var contratados = new List<Contratado>
            {
                new Contratado{ContratadoID=1 , cnpj="576746", razaoSocial="testando", porteDaEmpresa=453, ramoDeAtividade="carros", optantePeloSimples="nao", nomeFantasia="coca", inscricaoEstadual=9898, inscricaoMunicipal=1122, ContatoID=2}
            };

            contratados.ForEach(s => context.Contratados.Add(s));
            context.SaveChanges();

            var contratos = new List<Contrato> {
                new Contrato{ContratoID=1, objetoContrato="teste", vigenciaContrato=2030, ContratanteID=1, ContratadoID=1}
            };

            contratos.ForEach(s => context.Contratos.Add(s));
            context.SaveChanges();
        }

    }
}