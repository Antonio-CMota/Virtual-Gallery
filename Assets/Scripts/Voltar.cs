using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voltar : MonoBehaviour
{
    public bool onClick;
    public Transform textsair;
    public Transform textentrar;
    public Transform caixasair;

    void OnMouseDown()
    {
        onClick = true;
    }
    void Update()
    {
        if (onClick == true)
        {
            Debug.Log("click");
            textsair.gameObject.SetActive(false);
            textentrar.gameObject.SetActive(true);
            caixasair.gameObject.SetActive(false);
        }
    }
}

