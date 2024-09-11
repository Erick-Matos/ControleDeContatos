using ControleDeContatos.Models;

namespace ControleDeContatos.Repositrio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);    
    }
}
