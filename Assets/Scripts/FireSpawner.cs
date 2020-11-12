using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpawner : MonoBehaviour
{
    [SerializeField] protected KeyCode keyToPress;
    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected Vector3 velocityOfSpawnedObject;

    protected virtual GameObject spawnObject()
    {
        // spawn the new object.
        Vector3 positionOfSpawnedObject = transform.position;  // span at the containing object position.
        
        Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.

        GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject); // Instantiate

        if (this.tag == "P1"){//Shooter's tag
            newObject.tag = "P1_fireball";// Set fire ball tag for checking collision
            newObject.transform.Rotate(new Vector3(0, 0, -180));// Change Direction for fire ball from right.
        }
        if (this.tag == "P2"){//Shooter's tag
            newObject.tag = "P2_fireball";// Set fire ball tag for checking collision
        }

        // modify the velocity of the new object.
        MoverFire newObjectMover = newObject.GetComponent<MoverFire>();
        if (newObjectMover){ newObjectMover.SetVelocity(velocityOfSpawnedObject); }
        return newObject;
    }

    private void Update()
    {
        if (Input.GetKeyDown(keyToPress)){ spawnObject(); }
    }
}
