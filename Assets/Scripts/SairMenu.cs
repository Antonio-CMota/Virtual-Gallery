using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SairMenu : MonoBehaviour
{
    public GameObject dCanvas;
    public MouseLook2 mouseLook2;


    public void Sair()
    {
            Debug.Log("desativar");
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            dCanvas.SetActive(false);
    }
}