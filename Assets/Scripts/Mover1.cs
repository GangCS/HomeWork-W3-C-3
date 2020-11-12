using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover1 : MonoBehaviour
{
    [Tooltip("Speed of movement, in meters per second")] [SerializeField] float speed = 5f;
    void Update()
    {
        if(this.tag == "P1")// We are setting the location movement for player 1
        {
            if (Input.GetKey(KeyCode.UpArrow)){ transform.position += new Vector3(0, speed * Time.deltaTime, 0); }

            if (Input.GetKey(KeyCode.LeftArrow)){ transform.position += new Vector3(-speed * Time.deltaTime, 0, 0); }

            if (Input.GetKey(KeyCode.DownArrow)){ transform.position += new Vector3(0, -speed * Time.deltaTime, 0); }

            if (Input.GetKey(KeyCode.RightArrow)){ transform.position += new Vector3(speed * Time.deltaTime, 0, 0); }
        }

        if (this.tag == "P2")// We are setting the location movement for player 2
        {
            if (Input.GetKey(KeyCode.W)){ transform.position += new Vector3(0, speed * Time.deltaTime, 0); }

            if (Input.GetKey(KeyCode.A)){ transform.position += new Vector3(-speed * Time.deltaTime, 0, 0); }

            if (Input.GetKey(KeyCode.S)){ transform.position += new Vector3(0, -speed * Time.deltaTime, 0); }

            if (Input.GetKey(KeyCode.D)){ transform.position += new Vector3(speed * Time.deltaTime, 0, 0); }
        }
    }
}
