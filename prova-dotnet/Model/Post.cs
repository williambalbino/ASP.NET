using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prova_dotnet.Model
{
    public class Post
    {
        public int PostID { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Conteudo { get; set; }
        public ICollection<Comentario> Comentarios { get; set; }
    }
}