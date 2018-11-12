using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{

    public float Distance = 0;
    bool CanClick = false;
    public GameObject Tower;


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Enemy")
        {
            Debug.Log("Shoot!!");
        }
    }

    void Click()
    {


        if (Input.GetMouseButton(0))
        {
            CanClick = true;
            if(CanClick == true)
            { 
                 RaycastHit hit;
                 var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.tag == "Tower")
                    {
                        
                        Debug.Log("efgdcbv");
                        Instantiate(Tower);
                        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Distance);
                        Vector3 ObjectPos = Camera.main.ScreenToWorldPoint(mousePosition);
                      //  GameObject.Find < Tower(Clone) >
                        transform.position = ObjectPos;
                        


                    }
                }
                else
                {
                    Debug.Log("u missed honey");
                }
            }

            CanClick = false;

        }
    }

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && CanClick == false)
        {

            Click();
        }
    }
}
 