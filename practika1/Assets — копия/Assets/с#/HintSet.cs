using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HintSet : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Text hint;
    public string Value;
    private void Start() => hint = GameObject.FindGameObjectWithTag("Hint").GetComponent<Text>();
    public void OnPointerEnter(PointerEventData eventData) => hint.text = Value;
    public void OnPointerExit(PointerEventData eventData) => hint.text = string.Empty;
}