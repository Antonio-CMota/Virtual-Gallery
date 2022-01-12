using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    public bool onClick;
    public Transform textsair;
    public Transform textentrar;


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

        }
    }

}


