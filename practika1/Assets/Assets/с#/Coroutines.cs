using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Coroutines : MonoBehaviour
{
    public int Length;
    Text Text;
    private void Start()
    {
        Text = GetComponent<Text>();
        StartCoroutine(Name());
    }

    IEnumerator Name()
    {
        Color a = Text.color;
        Color b = Color.red;
        for (int i = Length; i >= 0; i--)
        {
            yield return new WaitForSeconds(1);

            Text.color = Color.Lerp(a, b, 10 / Length * (Length- i) * 0.1f);
            Text.text = i.ToString();
        }
    }
}

