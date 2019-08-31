using UnityEngine;
using TMPro;
using System.Collections;
using System;

public class DialogueControl : MonoBehaviour
{
    public RectTransform panelRectTransform;
    public float growX = 4f;
    public float growY = 0.2f;
    public int dismissTime = 2;
    public int repeatTimes = 100;

    void Start()
    {
        StartCoroutine(InvokeMethod(ScalePanel, dismissTime, repeatTimes));
    }

    private void ScalePanel()
    {
        panelRectTransform.sizeDelta = new Vector2(panelRectTransform.sizeDelta.x + growX, panelRectTransform.sizeDelta.y + growY);
    }


    public IEnumerator InvokeMethod(Action method, float dismissTime, int invokeCount)
    {
        for (int i = 0; i < invokeCount; i++)
        {
            method();

            yield return new WaitForFixedUpdate();
        }
        yield return new WaitForSeconds(dismissTime);
        gameObject.SetActive(false);
    }
}


