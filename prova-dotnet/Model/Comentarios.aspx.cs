using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prova_dotnet.Model
{
    public partial class Comentarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var contexto = new MeuContexto())
            {
                var posts = contexto.Posts.ToList();
                foreach (var post in posts)
                {
                    Response.Write(post.Titulo);
                    Response.Write(post.Conteudo);
                }
            }
        }

    }
}