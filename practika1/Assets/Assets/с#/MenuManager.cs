using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public List<GameObject> menuList;
    public bool closeAllWindow;

    public void CloseAllWindow(bool value) => closeAllWindow = value;
    public void OpenWindow(GameObject openObject)
    {
        if (closeAllWindow)
            foreach (GameObject menu in menuList) 
                menu.SetActive(false);
        openObject.SetActive(true);
    }

}
