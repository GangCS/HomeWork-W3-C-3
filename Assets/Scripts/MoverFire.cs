using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverFire : MonoBehaviour
{
    [Tooltip("Movement vector in meters per second")][SerializeField] Vector3 velocity;

    void Update()
    {
        transform.position += velocity * Time.deltaTime;// Moving the FireBall object once per frame.
    }

    public void SetVelocity(Vector3 newVelocity)
    {
        this.velocity = newVelocity;
    }
}
