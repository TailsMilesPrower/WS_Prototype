using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun2 : MonoBehaviour
{
    public GameObject objectToRotateSun;
    public GameObject objectToRotateCameraController;
    Quaternion targetRotation;
    Quaternion targetRotationCam;

    private void Start()
    {
        targetRotation = Quaternion.Euler(50, 0, 0);
        targetRotationCam = Quaternion.Euler(0, 0, 0);
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
            targetRotation = Quaternion.Euler(50, objectToRotateSun.transform.eulerAngles.y - 0.1f, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            targetRotation = Quaternion.Euler(50, objectToRotateSun.transform.eulerAngles.y + 0.1f, 0);
        }
        objectToRotateSun.transform.rotation = targetRotation;

        /*if (Input.GetKey(KeyCode.Q))
        {
            targetRotationCam = Quaternion.Euler(-70, objectToRotateCameraController.transform.eulerAngles.y - 1, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            targetRotationCam = Quaternion.Euler(-70, objectToRotateCameraController.transform.eulerAngles.y + 1, 0);
        }
        objectToRotateCameraController.transform.rotation = targetRotationCam;*/
    }
}

