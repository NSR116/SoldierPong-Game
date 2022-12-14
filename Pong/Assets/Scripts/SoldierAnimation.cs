using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAnimation : MonoBehaviour
{
    public float amplitude;
    public float speed;
    private float temp;
    public float pos;
    private Vector3 tempPos;

    // Start is called before the first frame update
    void Start()
    {
        temp = transform.position.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        tempPos.y= temp + amplitude * Mathf.Sin(speed * Time.time);
        tempPos.x = pos;
        transform.position = tempPos;
    }
}
