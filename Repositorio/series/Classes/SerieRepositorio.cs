using System;
using System.Collections.Generic;

namespace projeto
{
    public class SerieRepositorio : ILista<series>
    {
        private List<series> listaSerie = new List<series>();
        
        public void Atualiza(int Id, series objeto)
        {
            listaSerie[Id] = objeto;
        }

        public void Excluir(int Id)
        {
            listaSerie[Id].Excluir();
        }

        public void Insere(series objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<series> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count();
        }

        public series RetornaPorID(int Id)
        {
            return listaSerie[Id];
        }
    }
}