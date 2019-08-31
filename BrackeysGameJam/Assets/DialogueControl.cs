using UnityEngine;
using TMPro;

public class DialogueControl : MonoBehaviour
{
    public TextMeshProUGUI levelText;
    private string dialogueText;
    public RectTransform panelRectTransform;

    void Start()
    {
        dialogueText = levelText.text;
        //levelText.
        //levelText.text = "";
        //gameObject.SetActive(true);
        panelRectTransform.sizeDelta = new Vector2(panelRectTransform.sizeDelta.x, panelRectTransform.sizeDelta.y);

    }


}
