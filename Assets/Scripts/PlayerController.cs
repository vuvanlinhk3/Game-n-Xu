using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 400;
    public int turingspeed = 100;
    Rigidbody rbplayer;
    void Start()
    {
        rbplayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.A))
        //{
        //    rbplayer.AddForce(0f, 0f, -turingspeed * Time.deltaTime, ForceMode.VelocityChange);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    rbplayer.AddForce(0f, 0f, turingspeed * Time.deltaTime, ForceMode.VelocityChange);
        //}

        float movement = Input.GetAxis("Horizontal");
        rbplayer.AddForce(0f, 0f, turingspeed *movement * Time.deltaTime, ForceMode.VelocityChange);
    }

    private void FixedUpdate()
    {
        rbplayer.AddForce(-speed * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
