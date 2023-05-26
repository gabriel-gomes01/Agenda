using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Agenda
{
    static class cl_geral
    {
        public static string versao = "v 1.0.0";

        //Lista contatos
        public static List<cl_contato> LISTA_CONTATOS;

        public static void ConstroiListaContato()
        {
            //Carrega a lista de contatos

            //Verifica se existe a arquivo de contato
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\ficheiro_contatos.txt";
            //Cria a Lista vazia
            LISTA_CONTATOS = new List<cl_contato>();

            if (File.Exists(nome_ficheiro))
            {
                StreamReader ficheiro = new StreamReader(nome_ficheiro, Encoding.Default);
               
                while (!ficheiro.EndOfStream)
                {
                    //carrega nome
                    string nome = ficheiro.ReadLine();
                    //carrega numero
                    string numero = ficheiro.ReadLine();

                    //adicionar a lista de contato
                    //cl_contato novo_contato = new cl_contato();
                    //novo_contato.nome = nome;
                    //novo_contato.numero = numero;
                    //LISTA_CONTATOS.Add(novo_contato);
                    LISTA_CONTATOS.Add(new cl_contato() { nome = nome, numero = numero });
                }
                ficheiro.Dispose();
            }
        }
    }
}
