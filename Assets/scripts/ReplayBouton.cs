using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayBouton : MonoBehaviour
{
    public GameObject ReplayButton;
    private object rb2d;
    private bool isDead;

    void OnCollisionEnter2D(Collision2D col)
    {
        isDead = true;
        rb2d velocity = Vector2.zero;
        ReplayButton.SetActive(true);
      
        GetComponent<Animator>().SetBool("isDead", true);
    }
    public void Replay()
    {
        //This line changes the scene to the Scene 0 in your build settings
        SceneManager.LoadScene(0);

    }
}
