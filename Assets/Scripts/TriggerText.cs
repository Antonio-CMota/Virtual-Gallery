using UnityEngine;

public class TriggerText : MonoBehaviour
{

    public Transform texto;


    private void OnTriggerStay(Collider other)
    {
        Debug.Log("true");  
        texto.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("false");
        texto.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
