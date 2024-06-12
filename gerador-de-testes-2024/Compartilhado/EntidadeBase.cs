namespace gerador_de_testes_2024.Compartilhado;

public abstract class EntidadeBase
{
    public int Id { get; set; }

    public abstract void AtualizarRegistro(EntidadeBase novoRegistro);
    public abstract List<string> Validar();

    protected void VerificarNulo(ref List<string> erros, int campoTestado, string mostraCampo)
    {
        if (string.IsNullOrEmpty(campoTestado.ToString()))
            erros.Add($"O campo \"{mostraCampo}\" é obrigatório. Tente novamente ");
    }

    protected void VerificarNulo(ref List<string> erros, decimal campoTestado, string mostraCampo)
    {
        if (string.IsNullOrEmpty(campoTestado.ToString()) || campoTestado == 0)
            erros.Add($"O campo \"{mostraCampo}\" é obrigatório. Tente novamente ");
    }

    protected void VerificarNulo(ref List<string> erros, DateTime campoTestado, string mostraCampo)
    {
        if (string.IsNullOrEmpty(campoTestado.ToString()))
            erros.Add($"O campo \"{mostraCampo}\" é obrigatório. Tente novamente ");
    }

    protected void VerificarNulo(ref List<string> erros, string campoTestado, string mostraCampo)
    {
        if (string.IsNullOrEmpty(campoTestado))
            erros.Add($"O campo \"{mostraCampo}\" é obrigatório. Tente novamente ");
    }

    protected void VerificarNulo(ref List<string> erros, TimeSpan campoTestado, string mostraCampo)
    {
        if (campoTestado == TimeSpan.Zero)
            erros.Add($"O campo \"{mostraCampo}\" é obrigatório. Tente novamente ");
    }
}