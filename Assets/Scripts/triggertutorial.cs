using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggertutorial : MonoBehaviour
{
    public Transform texto1;
    public Transform texto2;
    public GameObject trigger;

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("true");
        texto1.gameObject.SetActive(true);
        texto2.gameObject.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("false");
        texto1.gameObject.SetActive(false);
        Destroy(trigger);
    }

}
