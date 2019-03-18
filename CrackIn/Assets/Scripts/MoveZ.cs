using UnityEngine;
using System.Collections;

public class MoveZ : MonoBehaviour
{
    float posZ = 1;
    Transform myTransform;

    private void Start()
    {
        myTransform = GetComponent<Transform>();
    }
    void Update()
    {
        posZ = Time.deltaTime * 1000;
        Debug.Log("posZ "+posZ);
        // Move the object upward in world space 1 unit/second.
        //transform.Translate(myTransform.position.x, myTransform.position.y, posZ);
        myTransform.position = new Vector3(myTransform.position.x, myTransform.position.y, posZ);
    }
}

