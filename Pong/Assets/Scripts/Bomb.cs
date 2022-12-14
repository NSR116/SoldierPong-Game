using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class Bomb : MonoBehaviour
{



    private void Start()
    {
       
        float x = Random.value < 0.5 ? -1.0f : 1.0f;
        float y = Random.value < 0.5 ? Random.Range(-1f, -0.5f) : Random.Range(0.5f,0.1f);
        Vector2 dir = new Vector2(x, y);
        float magn = 10;

        GetComponent<Rigidbody2D>().AddForce(dir * magn, ForceMode2D.Impulse);

    }
    
}
