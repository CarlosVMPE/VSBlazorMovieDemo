using Microsoft.AspNetCore.Components;

namespace VSCodeBlazorMovieReview.Components.Pages
{
    public partial class ListaElementos : ComponentBase
    {
        private List<string> elementos = new();
        private string nuevoElemento;

        private void AgregarElementos()
        {
            if (!string.IsNullOrWhiteSpace(nuevoElemento))
            {
                elementos.Add(nuevoElemento);
                nuevoElemento = string.Empty;
            }
        }
    }

}