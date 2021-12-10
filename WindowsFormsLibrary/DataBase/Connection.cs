using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;

namespace CursoWindowsFormsBiblioteca.Database
{
    public class Connection
    {
        public string Mensagem;
        public bool Status;
        public string Diretorio;

        public Connection(string diretorio)
        {
            Status = true;
            try
            {
                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }

                Diretorio = diretorio;
                Mensagem = "Conexão com fichario feita com sucesso";
            }
            catch (Exception ex)
            {
                Status = false;
                Mensagem = $"Conexão com ficharo falhou, {ex.Message}";
            }
        }

        public void Incluir(string Id, string jsonUnit)
        {
            Status = true;
            try
            {
                if (File.Exists($"{Diretorio}\\{Id}.json"))
                {
                    Status = false;
                    Mensagem = "Inclusão não permitida pq o Id ja existe!";
                }
                else
                {
                    File.WriteAllText($"{Diretorio}\\{Id}.json", jsonUnit);
                    Status = true;
                    Mensagem = "Inclusão concluida!";
                }
            }
            catch (Exception ex)
            {
                Status = false;
                Mensagem = $"Conexão falhou {ex.Message}";
            }
        }

        public string Buscar(string Id)
        {
            Status = true;
            try
            {
                if (!File.Exists($"{Diretorio}\\{Id}.json") && String.IsNullOrEmpty(Id) && Information.IsNumeric(Id) == true)
                {
                    Status = false;
                    Mensagem = $"O arquivo identificador não existe";
                }
                else
                {
                    Status = true;
                    string conteudo = File.ReadAllText($"{Diretorio}\\{Id}.json");
                    Mensagem = $"Arquivo lido com sucesso! ID {Id}";
                    return conteudo;
                }
            }
            catch (Exception ex)
            {
                Status = false;
                Mensagem = $"Erro ao buscar o conteudo do identificador {ex.Message}";
            }

            return "";
        }

        public void Apagar(string Id)
        {
            Status = true;
            try
            {
                if (!File.Exists($"{Diretorio}\\{Id}.json"))
                {
                    Status = false;
                    Mensagem = "Falhou, o id não existe no diretorio!";
                }
                else
                {
                    File.Delete($"{Diretorio}\\{Id}.json");
                    Status = true;
                    Mensagem = $"Deletado com sucesso, ID: {Id}";
                }
            }
            catch (Exception ex)
            {
                Status = false;
                Mensagem = $"Erro ao buscar o conteudo do identificador {ex.Message}";
            }
        }

        public void Alterar(string id, string jsonUnit)
        {
            Status = true;
            try
            {
                if (!File.Exists($"{Diretorio}\\{id}.json"))
                {
                    Status = false;
                    Mensagem = $"Alteração n permitida pq o Id n existe {id}";
                }
                else
                {
                    File.Delete($"{Diretorio}\\{id}.json");
                    File.WriteAllText($"{Diretorio}\\{id}.json", jsonUnit);
                    Mensagem = $"Inclusão feita com sucesso {id}";
                    Status = true;
                }
            }
            catch (Exception ex)
            {
                Status = false;
                Mensagem = ex.Message;
            }
        }

        public List<string> BuscarTodos()
        {
            Status = true;
            var list = new List<string>();
            try
            {
                var arquivos = Directory.GetFiles(Diretorio, "*.json");
                for (int i = 0; i <= arquivos.Length - 1; i++)
                {
                    string conteudo = File.ReadAllText(arquivos[i]);
                    list.Add(conteudo);
                }
                return list;
            }
            catch (Exception ex)
            {
                Status = false;
                Mensagem = $"não foi possível ler os arquivos no data source {ex.Message}";
            }
            return list;
        }

    }
}
