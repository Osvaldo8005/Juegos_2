using UnityEngine;

public class URLweb : MonoBehaviour
{
    // Este método se puede asignar a un botón desde el Inspector de Unity.
    public void AbrirEnlace(string url)
    {
        // Abre el enlace en el navegador predeterminado.
        Application.OpenURL(url);
    }
}

