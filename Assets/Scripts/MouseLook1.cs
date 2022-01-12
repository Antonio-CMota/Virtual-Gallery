using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseLook1 : MonoBehaviour
{
    public bool onClick;

    void OnMouseDown()
    { 
        onClick = true;

    }

    void Update()
    {
        if (onClick == true)
        {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}


