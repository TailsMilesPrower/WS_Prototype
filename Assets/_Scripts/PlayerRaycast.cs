using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    public LayerMask layersToHit;
    public Transform player;
    public Transform sun;

    private void Update()
    {
        RaycastHit rayHit = new RaycastHit();
        Ray ray = new Ray(sun.transform.position, player.position - transform.position);
    }

    /*void CheckForColliders()
    {
        if (Physics.Raycast(startPoint, endPoint))
        {
            Debug.Log("You are burning");
        }

        if (Physics.Raycast(theRay, out RaycastHit hit, range, layersToHit))
        {
            if (hit.collider.tag == "object")
            {
                Debug.Log("It's in the shadows");
            }
            else if (hit.collider.tag == "player")
            {
                Debug.Log("It's burning!");
            }
        }
    }*/
}
