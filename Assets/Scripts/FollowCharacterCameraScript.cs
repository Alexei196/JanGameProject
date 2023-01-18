using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharacterCameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject followedObject;
    private Vector3 cameraDistance = new Vector3(-7,12,-7);
    private Vector3 cameraRotation = new Vector3(55,45,0);

    // Update is called once per frame
    void Update()
    {
        transform.position = followedObject.transform.position + cameraDistance;
        transform.eulerAngles = cameraRotation;
    }
}
