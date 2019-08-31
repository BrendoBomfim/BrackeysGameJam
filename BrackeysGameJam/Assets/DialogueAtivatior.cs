using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAtivatior : MonoBehaviour
{
    private bool wasActivated;
    public RectTransform panelRectTransform;
    private void Start()
    {
        wasActivated = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && !wasActivated)
        {
            wasActivated = true;
            panelRectTransform.gameObject.SetActive(true);
        }
    }
}
