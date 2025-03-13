using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenScaling : MonoBehaviour
{
    [SerializeField] private Dropdown dropdown;
    public int picked;

    public void GetDropDownValue()
    {
        picked = dropdown.value;
        Debug.Log(picked);

        if(picked == 0)
        {
            Screen.SetResolution(1280, 720, false);
            Debug.Log("Разрешение поменялось на " + dropdown.options[picked].text);
        }
        if (picked == 1)
        {
            Screen.SetResolution(1366, 768, false);
            Debug.Log("Разрешение поменялось на " + dropdown.options[picked].text);
        }
        if (picked == 2)
        {
            Screen.SetResolution(1600, 768, false);
            Debug.Log("Разрешение поменялось на " + dropdown.options[picked].text);
        }
        if (picked == 3)
        {
            Screen.SetResolution(1920, 1080, false);
            Debug.Log("Разрешение поменялось на " + dropdown.options[picked].text);
        }

    }

}
