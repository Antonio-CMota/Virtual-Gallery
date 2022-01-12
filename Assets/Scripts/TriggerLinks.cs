using UnityEngine;

public class TriggerLinks : MonoBehaviour
{

    public Transform canvas;


    private void OnTriggerStay(Collider other)
    {
        Debug.Log("true");
        canvas.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("false");
        canvas.gameObject.SetActive(false);
    }

}
