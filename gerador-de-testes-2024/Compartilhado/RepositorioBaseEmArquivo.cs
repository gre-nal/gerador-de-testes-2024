using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace gerador_de_testes_2024.Compartilhado;

public class RepositorioBaseEmArquivo<T>
{
    private readonly string caminho = string.Empty;
    protected int backupId;
    protected List<T> registros = new();

    public RepositorioBaseEmArquivo(string nomeArquivo)
    {
        caminho = $"C:\\temp\\GeradorTestes\\{nomeArquivo}";

        registros = DeserializarRegistros();
    }

    protected int contadorId
    {
        get
        {
            if (backupId != 0) return backupId;
            if (registros.Count != 0)
            {
                var lastItem = registros.LastOrDefault();
                if (lastItem != null && lastItem.GetType().GetProperty("Id") != null)
                {
                    var idProperty = lastItem.GetType().GetProperty("Id");
                    var lastItemId = (int?)idProperty.GetValue(lastItem);
                    return lastItemId.GetValueOrDefault() + 1;
                }
            }

            return 1;
        }
        set { }
    }

    public void Atualizar()
    {
        SerializarRegistros();
    }

    public void Cadastrar(T novoRegistro)
    {
        if (novoRegistro.GetType().GetProperty("Id") != null)
        {
            var idProperty = novoRegistro.GetType().GetProperty("Id");
            idProperty.SetValue(novoRegistro, contadorId);
        }

        backupId = 0;

        registros.Add(novoRegistro);

        SerializarRegistros();
    }

    public bool Editar(int id, T novaEntidade)
    {
        var registro = SelecionarPorId(id);

        if (registro == null)
            return false;

        if (registro.GetType().GetMethod("AtualizarRegistro") != null)
        {
            var atualizarRegistroMethod = registro.GetType().GetMethod("AtualizarRegistro");
            atualizarRegistroMethod.Invoke(registro, new object[] { novaEntidade });
        }

        SerializarRegistros();

        return true;
    }

    public bool Excluir(int id)
    {
        var registro = SelecionarPorId(id);
        if (registro != null)
        {
            if (registro.Equals(registros.Last())) backupId = contadorId;
            registros.Remove(registro);
            SerializarRegistros();
            return true;
        }

        return false;
    }

    public bool Existe(int id)
    {
        if (registros.Any(x => x.GetType().GetProperty("Id") != null))
        {
            var idProperty = registros.First().GetType().GetProperty("Id");
            return registros.Any(x => (int?)idProperty.GetValue(x) == id);
        }

        return false;
    }

    public int PegarId()
    {
        return contadorId;
    }

    public List<T> SelecionarTodos()
    {
        return registros;
    }

    public T SelecionarPorId(int id)
    {
        if (registros.Any(x => x.GetType().GetProperty("Id") != null))
        {
            var idProperty = registros.First().GetType().GetProperty("Id");
            return registros.FirstOrDefault(x => (int?)idProperty.GetValue(x) == id);
        }

        return default;
    }

    protected void SerializarRegistros()
    {
        var arquivo = new FileInfo(caminho);

        arquivo.Directory?.Create();

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            ReferenceHandler = ReferenceHandler.Preserve,
            PropertyNameCaseInsensitive = true
        };

        var registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(registros, options);

        File.WriteAllBytes(caminho, registrosEmBytes);
    }

    protected List<T> DeserializarRegistros()
    {
        var arquivo = new FileInfo(caminho);

        if (!arquivo.Exists)
            return new List<T>();

        var registrosEmBytes = File.ReadAllBytes(caminho);

        var options = new JsonSerializerOptions
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            PropertyNameCaseInsensitive = true
        };

        var registros = JsonSerializer.Deserialize<List<T>>(registrosEmBytes, options);

        return registros;
    }
}
