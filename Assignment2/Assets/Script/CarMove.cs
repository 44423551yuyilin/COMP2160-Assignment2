using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float speed = 15;
    public float rotateSpeed = 90;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))

        {

            this.transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }

        if (Input.GetKey(KeyCode.S))

        {

            this.transform.Translate(Vector3.back * Time.deltaTime * speed);

        }

        if (Input.GetKey(KeyCode.A))

        {

            this.transform.Rotate(Vector3.up * Time.deltaTime * -rotateSpeed);

        }

        if (Input.GetKey(KeyCode.D))

        {

            this.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);

        }


    }
}
