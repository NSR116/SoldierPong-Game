using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Wall : MonoBehaviour
{
    public int counter;
    public Text countertx;
    public Text finalScore;
    public GameObject endGame;
    public GameObject soldier1;
    public GameObject soldier2;
    public GameObject bomb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Bomb")
        {
            counter++;
            countertx.text = counter.ToString();
            finalScore.text = counter.ToString();
        }
    }

    private void Update()
    {
        if(counter == 10)
        {
            endGame.SetActive(true);
            soldier1.SetActive(false);
            soldier2.SetActive(false);
            bomb.SetActive(false);
            GetComponent<AudioSource>().Play();
            counter = 0;

        }

    }

  
}
