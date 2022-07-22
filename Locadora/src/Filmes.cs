using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.src
{
    public class Filmes
    {
        public string Titulo { get; set; }
        public int Classificacao { get; set; }
        public int Duracao { get; set; }
        public string Estudio { get; set; }
        public string Idioma { get; set; }
        public string TipoReproducao { get; set; }
        public Categoria Categoria { get; set; }
        public string Alugado { get; set; }

        public Filmes(string titulo,
            int classificacao, int duracao, string estudio, string idioma, string tipoReproducao, Categoria categoria)
        {
            Titulo = titulo;        
            Classificacao = classificacao;
            Duracao = duracao;
            Estudio = estudio;
            Idioma = idioma;
            TipoReproducao = tipoReproducao;
            Categoria = categoria;
        }

        public Filmes(string alugado)
        {
            Alugado = alugado;
        }

        public override string ToString()
        {
            return $"\n Título do filme: {Titulo}" +
                $"\n Categoria: {Categoria}" +
                $"\n Classificação Indicativa: {Classificacao}" +
                $"\n Duração: {Duracao}" +
                $"\n Estúdio: {Estudio}" +
                $"\n Idioma: {Idioma}" +
                $"\n Tipo de Reprodução: {TipoReproducao}";
        }
        
    }

    public enum Categoria
    {
        COMEDIA, ROMANCE, FICCAO, ACAO, SUSPENSE
    }
}
