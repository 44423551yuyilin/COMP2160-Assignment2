using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    
    public Rigidbody rigidbody;
    public float driveSpeed;
    public float rotateSpeed;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        //car move
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(driveSpeed * Vector3.forward);

        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(driveSpeed * Vector3.back);

        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(driveSpeed * Vector3.forward);
            this.transform.Rotate(Vector3.up * Time.deltaTime * -rotateSpeed);

        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(driveSpeed * Vector3.forward);
            this.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);

        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(driveSpeed * Vector3.back);
            this.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);

        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(driveSpeed * Vector3.back);
            this.transform.Rotate(Vector3.up * Time.deltaTime * -rotateSpeed);

        }

    }



}
