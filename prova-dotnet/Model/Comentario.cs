using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prova_dotnet.Model
{
    public class Comentario
    {
        public int ComentarioID { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public Post post { get; set; }
    }
}