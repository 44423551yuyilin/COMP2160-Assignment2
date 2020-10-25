using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public int speed = 5;
    public float rotspeed = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //car move
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * vertical * speed * Time.deltaTime);
        transform.Rotate(0, horizontal * rotspeed * Time.deltaTime, 0);
    }
}
