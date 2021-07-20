using System.Collections.Generic;
using Series.Interfaces;

namespace Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> series = new List<Serie>();
        public void Atualiza(int id, Serie serie)
        {
            this.series[id] = serie;
        }

        public void Exclui(int id)
        {
            this.series[id].exclui();
        }

        public void Insere(Serie serie)
        {
            this.series.Add(serie);
        }

        public List<Serie> Lista()
        {
            return this.series;
        }

        public int ProximoId()
        {
            return this.series.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return this.series[id];
        }
    }
}