using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    public float Distance = 0;
    int = []

    private void Update()
    {

        if (Input.GetMouseButton(0))
        {

            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Tower")
                {
                    Debug.Log("efgdcbv");
                    Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Distance);
                    Vector3 ObjectPos = Camera.main.ScreenToWorldPoint(mousePosition);
                    transform.position = ObjectPos;

                }
            }
            else
            {
                Debug.Log("u missed honey");
            }
        }

    }
}
 