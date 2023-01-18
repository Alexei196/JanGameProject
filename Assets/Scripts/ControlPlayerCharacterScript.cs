using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayerCharacterScript : MonoBehaviour
{
    private Vector3 movementVector;
    private float speed = 2.5f;

    // Update is called once per frame
    void Update()
    {
        movementVector = new Vector3(0.0f,0.0f,0.0f);
        movementVector.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        movementVector.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.position += movementVector;
    }
}
