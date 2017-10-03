using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prova_dotnet.Model
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var contexto = new MeuContexto())
            {
                Post post = new Post();
                post.Titulo = "Titulo";
                post.Conteudo = "Conteúdo";

                contexto.Posts.Add(post);
                contexto.SaveChanges();

                Response.Redirect("Comentarios.aspx");
            };
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}