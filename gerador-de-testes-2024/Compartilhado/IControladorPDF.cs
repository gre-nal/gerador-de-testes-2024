namespace gerador_de_testes2024.Compartilhado;

internal interface IControladorPDF
{
    string ToolTipPDF { get; }
    void GerarPDF();
}