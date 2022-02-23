using System.Collections.Generic;

namespace projeto
{
    public interface ILista<series> //Criação de repositório, o <T> é um tipo genérico
    {
         List<series> Lista();
         series RetornaPorID(int Id);
         void Insere(series entidade);
         void Excluir(int Id);
         void Atualiza(int Id, series entidade);
         int ProximoId();
    }
}