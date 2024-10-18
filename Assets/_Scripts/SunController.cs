using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunController : MonoBehaviour
{
    public GameObject objectToRotate;
    Quaternion targetRotation;


    private void Start()
    {
        targetRotation = Quaternion.Euler(50, 0, 0);
    }

    private void Update()
    {
        CheckRotation();
    }

    // Update is called once per frame
    void CheckRotation()
    {

        if (Input.GetKey(KeyCode.Q))
        {
            targetRotation = Quaternion.Euler(50, objectToRotate.transform.eulerAngles.y + 1, objectToRotate.transform.eulerAngles.z);
        }
        if (Input.GetKey(KeyCode.E))
        {
            targetRotation = Quaternion.Euler(50, objectToRotate.transform.eulerAngles.y - 1, objectToRotate.transform.eulerAngles.z);
        }
        objectToRotate.transform.rotation = targetRotation;
    }
}