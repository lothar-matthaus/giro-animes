﻿
using Giro.Animes.Domain.Entities.Base;
using System.Reflection;

namespace Giro.Animes.Domain.Entities
{
    public class Episode : EntityBase
    {
        /// <summary>
        /// Coleção de títulos do episódio
        /// </summary>
        public IEnumerable<EpisodeTitle> Titles { get; private set; }

        /// <summary>
        /// Sinopses do episódio
        /// </summary>
        public IEnumerable<EpisodeSinopse> Sinopses { get; private set; }

        /// <summary>
        /// Número do episódio
        /// </summary>
        public int Number { get; private set; }

        /// <summary>
        /// Duração do episódio em minutos
        /// </summary>
        public int Duration { get; private set; }

        /// <summary>
        /// Arquivo de vídeo do episódio em questão
        /// </summary>
        public IEnumerable<EpisodeFile> Files { get; private set; }

        /// <summary>
        /// Identificador do anime a qual o episódio pertence
        /// </summary>
        public long AnimeId { get; private set; }

        /// <summary>
        /// Propriedade de navegação para o anime a qual o episódio pertence
        /// </summary>
        public Anime Anime { get; private set; }

        ///// <summary>
        ///// Idiomas de áudio que o episódio possui
        ///// </summary>
        //public IEnumerable<Language> AudioLanguages { get; private set; }

        ///// <summary>
        ///// Idiomas de legendas que o episódio possui
        ///// </summary>
        //public IEnumerable<Language> SubtitleLanguages { get; set; }

        /// <summary>
        /// Construtor padrão para garantir a construção do objeto no Entity Framework
        /// </summary>
        public Episode()
        {

        }

        /// <summary>
        /// Construtor privado com parâmetros. Garante a construção do objeto através do método Create
        /// </summary>
        /// <param name="titles">Coleção de títulos do episódio</param>
        /// <param name="number">Número do episódio</param>
        /// <param name="duration">Duração do episódio em minutos</param>
        /// <param name="url">URL do episódio</param>
        private Episode(IEnumerable<EpisodeFile> files, IEnumerable<EpisodeTitle> titles, IEnumerable<EpisodeSinopse> sinopses, int number, int duration, string url)
        {
            Titles = titles;
            Number = number;
            Duration = duration;
            Files = files;
            Sinopses = sinopses;
        }

        /// <summary>
        /// Método estático para criar um objeto Episode com validações de propriedades e retorno do objeto
        /// </summary>
        /// <param name="titles">Coleção de títulos do episódio</param>
        /// <param name="number">Número do episódio</param>
        /// <param name="duration">Duração do episódio em minutos</param>
        /// <param name="url">URL do episódio</param>
        /// <returns>Uma nova instância de Episode</returns>
        public static Episode Create(IEnumerable<EpisodeFile> files, IEnumerable<EpisodeTitle> titles, IEnumerable<EpisodeSinopse> sinopses, int number, int duration, string url) => new Episode(files, titles, sinopses, number, duration, url);
    }
}
