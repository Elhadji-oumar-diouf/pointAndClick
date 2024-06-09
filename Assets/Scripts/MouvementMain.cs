using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementMain : MonoBehaviour
{
    public Transform destination;
    // Start is called before the first frame update
    void Start()
    {
        MoveToDestination();
    }

    public void MoveToDestination()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log($"click de la souris");

            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right);
            if (hit.collider != null )
            {

                //Debug.Log($"Collision avec {hit.collider.name}");
                Debug.Log($"click sur avec {hit.transform.name}");
            }
            //transform.position = Vector3.MoveTowards(transform.position, destination.position, 1f);
        }


    }
}
