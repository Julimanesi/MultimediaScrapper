﻿using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GoogleScrapper
{
    public class YoutubeApi
    {
        public string Busqueda { get; set; } = string.Empty;
        public int maxResults { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public string regionCode { get; set; } = string.Empty;
        public SearchResource.ListRequest.VideoDurationEnum videoDuration { get; set; }
        public SearchResource.ListRequest.OrderEnum orden { get; set; }
        public SearchResource.ListRequest.SafeSearchEnum safeSearch { get; set; }
        public SearchResource.ListRequest.VideoCaptionEnum subtitulos { get; set; }
        public SearchResource.ListRequest.VideoDefinitionEnum definicion { get; set; }
        public SearchResource.ListRequest.VideoTypeEnum tipoVideo { get; set; }
        public string CategoriaVideo { get; set; } = string.Empty;
        public string TipoBusqueda { get; set; } = string.Empty;
        public SearchListResponse? ListaRespuesta { get; set; }
        public SearchResource.ListRequest.ChannelTypeEnum TipoCanal { get; set; }
        public string Idioma { get; set; } = string.Empty;
        public string Pais { get; set; } = string.Empty;

        public YoutubeApi()
        {
        }

        public YoutubeApi(string busqueda,int maxResults, DateTime fechaInicio, DateTime fechaFin, string regionCode, SearchResource.ListRequest.VideoDurationEnum videoDuration, SearchResource.ListRequest.OrderEnum orden, SearchResource.ListRequest.SafeSearchEnum safeSearch, SearchResource.ListRequest.VideoCaptionEnum subtitulos, SearchResource.ListRequest.VideoDefinitionEnum definicion, SearchResource.ListRequest.VideoTypeEnum tipoVideo, string categoriaVideo,string tipoBusqueda, SearchResource.ListRequest.ChannelTypeEnum tipocanal, string idioma,string pais)
        {
            this.Busqueda = busqueda;
            this.maxResults = maxResults;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.regionCode = regionCode;
            this.videoDuration = videoDuration;
            this.orden = orden;
            this.safeSearch = safeSearch;
            this.subtitulos = subtitulos;
            this.definicion = definicion;
            this.CategoriaVideo = categoriaVideo;
            this.tipoVideo = tipoVideo;
            this.TipoBusqueda = tipoBusqueda;
            TipoCanal = tipocanal;
            Idioma = idioma;
            Pais = pais;
        }

        //private async Task Run(int maxResults ,DateTime fechaInicio ,DateTime fechaFin ,string regionCode,SearchResource.ListRequest.VideoDurationEnum videoDuration, SearchResource.ListRequest.OrderEnum orden, SearchResource.ListRequest.SafeSearchEnum safeSearch, SearchResource.ListRequest.VideoCaptionEnum subtitulos, SearchResource.ListRequest.VideoDefinitionEnum definicion,string categoria)
        public async Task Run()
        {
            try
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = KeyAndPasswords.YoutubeApiKey,
                    ApplicationName = this.GetType().ToString()
                });

                var searchListRequest = youtubeService.Search.List("snippet");
                searchListRequest.Q = Busqueda; // Replace with your search term.
                searchListRequest.Type = TipoBusqueda;
                searchListRequest.MaxResults = this.maxResults;
                searchListRequest.PublishedAfter = this.fechaInicio.ToString("yyyy-MM-ddTHH:mm:ssZ");
                searchListRequest.PublishedBefore = this.fechaFin.ToString("yyyy-MM-ddTHH:mm:ssZ");
                searchListRequest.RegionCode = this.regionCode;
                searchListRequest.RegionCode = Pais;
                if (Idioma != "" && Idioma != "iv")
                    searchListRequest.RelevanceLanguage = Idioma;
                searchListRequest.SafeSearch = this.safeSearch;
                searchListRequest.Order = this.orden;
                if (TipoBusqueda == "video")
                {
                    searchListRequest.VideoDuration = this.videoDuration;
                    searchListRequest.VideoCaption = this.subtitulos;
                    searchListRequest.VideoDefinition = this.definicion;
                    if (this.CategoriaVideo != null && this.CategoriaVideo != "")
                        searchListRequest.VideoCategoryId = this.CategoriaVideo;
                    searchListRequest.VideoType = this.tipoVideo;
                }
                if (TipoBusqueda == "channel")
                    searchListRequest.ChannelType = TipoCanal;
                // Call the search.list method to retrieve results matching the specified query term.
                ListaRespuesta = await searchListRequest.ExecuteAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al buscar videos en Youtube(API)");
            }
        }

        public static async Task<PlaylistItemListResponse?> GetPlaylistItems(string playListId, string? pageToken = null)
        {
            try
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = KeyAndPasswords.YoutubeApiKey,
                    //ApplicationName = this.GetType().ToString()
                });
                var playlistItemsListRequest = youtubeService.PlaylistItems.List("snippet,contentDetails,status");
                playlistItemsListRequest.PlaylistId = playListId;
                playlistItemsListRequest.MaxResults = 50;
                if (pageToken != null)
                    playlistItemsListRequest.PageToken = pageToken;
                return await playlistItemsListRequest.ExecuteAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al buscar videos de la lista de reproducción en Youtube(API)");
                return null;
            }
        }

        public static async Task<ChannelListResponse?> GetCanalesInfo(string identificador,bool esId = true)
        {
            try
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = KeyAndPasswords.YoutubeApiKey,
                    //ApplicationName = this.GetType().ToString()
                });
                var canalInfo = youtubeService.Channels.List("snippet,contentDetails,statistics");
                if(esId)
                    canalInfo.Id= identificador;
                else
                    canalInfo.ForUsername = identificador;
                canalInfo.MaxResults = 50;
                return await canalInfo.ExecuteAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al buscar videos de la lista de reproducción en Youtube(API)");
                return null;
            }
        }

        public static async Task<VideoListResponse?> GetVideosInfo(string videoId)
        {
            try
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = KeyAndPasswords.YoutubeApiKey,
                    //ApplicationName = this.GetType().ToString()
                });
                var videoInfo = youtubeService.Videos.List("snippet,contentDetails,statistics,recordingDetails,player,topicDetails");
                videoInfo.Id = videoId;
                videoInfo.MaxResults = 50;
                return await videoInfo.ExecuteAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al obtener info del video en Youtube(API)");
                return null;
            }
        }

        public static async Task<Playlist?> GetPlayListInfo(string playListId)
        {
            try
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = KeyAndPasswords.YoutubeApiKey,
                    //ApplicationName = this.GetType().ToString()
                });
                var playListInfo = youtubeService.Playlists.List("snippet,status,contentDetails");
                playListInfo.Id = playListId;
                playListInfo.MaxResults = 50;
                var resultado = await playListInfo.ExecuteAsync();
                if(resultado != null && resultado.Items.Count > 0)
                {
                    return resultado.Items[0];
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al obtener info del video en Youtube(API)");
                return null;
            }
        }

        public static async Task<Channel?> GetCanalInfo(string identificador, bool esId = true)
        {
            try
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = KeyAndPasswords.YoutubeApiKey,
                    //ApplicationName = this.GetType().ToString()
                });
                var canalInfo = youtubeService.Channels.List("snippet,contentDetails,statistics");
                if (esId)
                    canalInfo.Id = identificador;
                else
                    canalInfo.ForUsername = identificador;
                canalInfo.MaxResults = 50;
                var resultado = await canalInfo.ExecuteAsync();
                if (resultado != null && resultado.Items.Count > 0)
                {
                    return resultado.Items[0];
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al buscar videos de la lista de reproducción en Youtube(API)");
                return null;
            }
        }

        public static async Task<Video?> GetVideoInfo(string videoId)
        {
            try
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = KeyAndPasswords.YoutubeApiKey,
                    //ApplicationName = this.GetType().ToString()
                });
                var videoInfo = youtubeService.Videos.List("snippet,contentDetails,statistics,recordingDetails,player,topicDetails");
                videoInfo.Id = videoId;
                videoInfo.MaxResults = 50;
                var resultado = await videoInfo.ExecuteAsync();
                if (resultado != null && resultado.Items.Count > 0)
                {
                    return resultado.Items[0];
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al obtener info del video en Youtube(API)");
                return null;
            }
        }

        public static string ParsearIdDesdeURLVideo(string url)
        {
            string videoId = "";
            if (url.Contains("youtube.com") && url.Contains("="))
            {
                var IdVideo = url.Contains("&") ? url.Split('=')[1].Split("&")[0] : url.Split('=')[1];
                if (IdVideo != null)
                {
                    videoId = IdVideo;
                }
                else
                {
                    MessageBox.Show("La URL no se reconoce como una proveniente de YouTube", "Error al obtener el Id del Video");
                }
            }
            return videoId;
        }

    }
}
