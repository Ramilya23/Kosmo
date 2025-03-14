using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class Data : MonoBehaviour
{
    public float a;
    public void SavePrefs()
    {
        PlayerPrefs.SetFloat("A", a);
    }
    public void LoadPrefs()
    {
        a = PlayerPrefs.GetFloat("a");
    }
}
