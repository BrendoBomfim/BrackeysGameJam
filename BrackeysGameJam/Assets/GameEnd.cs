using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{

    public GameObject EndUI;

    public List<Animation> anims = new List<Animation> { };

    public float UIDelay = 5;

   public void GoGameEnd()
    {
        foreach(var a in anims)
        {
            a.Play();
        }

        var player = GameObject.FindWithTag("Player");
        player.GetComponent<Animator>().SetBool("End", true);
        player.GetComponent<Movement>().enabled = false;
        Invoke("GameEndUI", UIDelay);

    }

    void GameEndUI()
    {
        EndUI.SetActive(true);
    }

    public void GoTitle()
    {
        SceneManager.LoadScene(0);

    }
}
