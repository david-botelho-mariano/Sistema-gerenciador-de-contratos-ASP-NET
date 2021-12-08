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
                new Gestor{ativo="nao", dataNascimento=DateTime.Parse("1999-01-01"), cpf="9111111", email="teste@gmail.com1", enderecoCompleto="end1", GestorID=1, nomeCompleto="jose1", rg=1, senha="password1"},
                new Gestor{ativo="nao", dataNascimento=DateTime.Parse("1999-01-02"), cpf="8222222222", email="teste@gmail.com2", enderecoCompleto="end2", GestorID=2, nomeCompleto="jose2", rg=2, senha="password2"},
                new Gestor{ativo="nao", dataNascimento=DateTime.Parse("1999-01-03"), cpf="7333333333", email="teste@gmail.com3", enderecoCompleto="end3", GestorID=3, nomeCompleto="jose3", rg=3, senha="password3"},
                new Gestor{ativo="sim", dataNascimento=DateTime.Parse("1999-01-04"), cpf="64444444444", email="teste@gmail.com4", enderecoCompleto="end4", GestorID=4, nomeCompleto="jose4", rg=4, senha="password4"}
            };

            gestores.ForEach(s => context.Gestores.Add(s));
            context.SaveChanges();

            var contatos = new List<Contato>
            {
                new Contato{bairro="centro", celular=98, cep=76, cidade="Palmas", complemento="quarteto", dataNascimento=DateTime.Parse("2005-01-01"), email="exemplo123123123@uft.com",enderecoEmpresa="jk", estado="Tocantins", fax="00012", funcao="supervisor", nome="eduardo", ContatoID=1, numero=4984, telefone=2387, telefoneComercial=4783},
                new Contato{bairro="norte", celular=92384938, cep=718237, cidade="Palmas", complemento="aeroporto", dataNascimento=DateTime.Parse("2001-01-01"), email="exemplo@unitins.com",enderecoEmpresa="404 norte", estado="Tocantins", fax="12312", funcao="gerente", nome="Carlos", ContatoID=2, numero=1232133, telefone=1498493, telefoneComercial=123981293}
            };

            contatos.ForEach(s => context.Contatos.Add(s));
            context.SaveChanges();

            var contratantes = new List<Contratante>
            {
                new Contratante{ContratanteID = 1, cnpj ="12367", razaoSocial="razao teste", porteDaEmpresa=500, ramoDeAtividade="vacinas", optantePeloSimples="sim", nomeFantasia="pepsi", inscricaoEstadual=1554894, inscricaoMunicipal=119829, ContatoID=1}
            };

            contratantes.ForEach(s => context.Contratantes.Add(s));
            context.SaveChanges();

            var contratados = new List<Contratado>
            {
                new Contratado{ContratadoID=1 , cnpj="576746", razaoSocial="testando razao", porteDaEmpresa=453, ramoDeAtividade="carros", optantePeloSimples="nao", nomeFantasia="coca", inscricaoEstadual=9898, inscricaoMunicipal=1122, ContatoID=2}
            };

            contratados.ForEach(s => context.Contratados.Add(s));
            context.SaveChanges();

            var contratos = new List<Contrato> {
                new Contrato{ContratoID=1, ativo="sim", objetoContrato="teste", vigenciaContrato=2030, ContratanteID=1, ContratadoID=1},
                new Contrato{ContratoID=2, ativo="sim", objetoContrato="teste2", vigenciaContrato=2099, ContratanteID=1, ContratadoID=1},
                new Contrato{ContratoID=3, ativo="sim", objetoContrato="teste3", vigenciaContrato=2010, ContratanteID=1, ContratadoID=1},
                new Contrato{ContratoID=4, ativo="nao", objetoContrato="teste4", vigenciaContrato=2000, ContratanteID=1, ContratadoID=1}
            };

            contratos.ForEach(s => context.Contratos.Add(s));
            context.SaveChanges();
        }

    }
}