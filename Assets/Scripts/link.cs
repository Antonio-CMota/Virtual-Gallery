using UnityEngine;

public class link : MonoBehaviour
{

    public string linkk = "";

    public void OpenLink()
    {
        Application.OpenURL(linkk);
     
    }
}
