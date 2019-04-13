using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTriggerLoadPortal: MonoBehaviour
{
    public GameObject guiObject;
    public string levelToLoad;

    void Start() 
    {
        guiObject.SetActive(false);        
    }
    void OnTriggerStay (Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            guiObject.SetActive(true);
            if(guiObject.activeInHierarchy == true && Input.GetButtonDown("UseTeleport"))
            {
                Application.LoadLevel(levelToLoad);
            }
        }
    }
    void OnTriggerExit()
    {
        guiObject.SetActive(false);
    }
}
