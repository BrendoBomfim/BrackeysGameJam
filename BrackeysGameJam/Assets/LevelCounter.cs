using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelCounter : MonoBehaviour
{
    public TextMeshProUGUI levelText;
    void Start()
    {
        levelText.text = SceneManager.GetActiveScene().buildIndex.ToString();
    }


}
