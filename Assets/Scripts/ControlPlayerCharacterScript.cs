using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayerCharacterScript : MonoBehaviour
{
    private Vector3 worldPosition, desiredWorldPosition;
    private float maxSpeed = 0.2f;

    void Start(){
        desiredWorldPosition = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1")) {
            float distance;
            Plane plane  = new Plane(Vector3.up, 0);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(plane.Raycast(ray, out distance)) {
                desiredWorldPosition = ray.GetPoint(distance);
                desiredWorldPosition.y = 1.0f;
            }

        }
        transform.position = Vector3.MoveTowards(transform.position, desiredWorldPosition, maxSpeed);
    }
}
