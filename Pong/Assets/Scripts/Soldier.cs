using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{

    public float speed = 0.1f;
    public Rigidbody2D bodyForce;
   

    public string controll1;
    public string controll2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(controll1))
        {
            bodyForce.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
        }
         else if (Input.GetKey(controll2))
        {
            bodyForce.AddForce(Vector2.down * speed, ForceMode2D.Impulse);
        }

    }
}
