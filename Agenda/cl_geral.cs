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
        //======================================================================
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
                    LISTA_CONTATOS.Add(new cl_contato() { nome = nome, numero = numero });
                }
                ficheiro.Dispose();
            }
        }

        //======================================================================
        public static void GravarNovoRegistro(string nome, string numero)
        {
            //grava na lista
            LISTA_CONTATOS.Add(new cl_contato() { nome = nome, numero = numero });

            //atualiza o ficheiro
            GravarFicheiro();
        }

        //======================================================================
        public static void GravarFicheiro()
        {
            //Verifica se existe a arquivo de contato
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\ficheiro_contatos.txt";

            StreamWriter sr = new StreamWriter(nome_ficheiro, false, Encoding.Default);

            foreach (cl_contato contato in LISTA_CONTATOS)
            {
                sr.WriteLine(contato.nome);
                sr.WriteLine(contato.numero);
            }
            sr.Dispose();
        }

        //===============================================================================================
        public static cl_contato BuscaContato(int index)
        {
            var contato = LISTA_CONTATOS[index];
            return contato;
        }

        //===============================================================================================

        public static void InserirContatoLista(string nome, string numero, int index)
        {
            //Atualiza o registro na lista e na base de dados

            var contato = new cl_contato() { nome = nome, numero = numero };

            LISTA_CONTATOS[index].nome = nome;
            LISTA_CONTATOS[index].numero = numero;
            
        }
    }
}
