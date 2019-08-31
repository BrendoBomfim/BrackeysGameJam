using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelCounter : MonoBehaviour
{
    public TextMeshProUGUI levelText;
    void Start()
    {
        levelText.text = SceneManager.GetActiveScene().buildIndex.ToString();
    }


}
