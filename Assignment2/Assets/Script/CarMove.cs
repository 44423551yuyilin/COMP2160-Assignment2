using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 15;
    public float rotateSpeed = 90;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))

        {
            //rb.AddForce(Vector3.forward * speed);
            this.transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }

        if (Input.GetKey(KeyCode.S))

        {
            //rb.AddForce(Vector3.back * speed);
            this.transform.Translate(Vector3.back * Time.deltaTime * speed);

        }

        if (Input.GetKey(KeyCode.W)&&Input.GetKey(KeyCode.A))

        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
            this.transform.Rotate(Vector3.up * Time.deltaTime * -rotateSpeed);

        }

        if (Input.GetKey(KeyCode.W)&&Input.GetKey(KeyCode.D))

        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
            this.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);

        }

        if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime * speed);
            this.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
        }


        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))

        {
            this.transform.Translate(Vector3.back * Time.deltaTime * speed);
            this.transform.Rotate(Vector3.up * Time.deltaTime * -rotateSpeed);

        }

    }

    void FixedUpdate()
    {

    }
}
