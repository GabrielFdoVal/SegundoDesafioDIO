using SegundoDesafioDIO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoDesafioDIO
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Serie entidade)
        {
            if (!entidade.estaVazio())
            {
                listaSerie.Add(entidade);
            }                
        }

        public List<Serie> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Serie RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
