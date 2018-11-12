using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

   
    public int health = 50;
    public float MovementSpeed = 0.1f;
    Map myGrid;
    public int numX = 0;
    public int numY = 0;
	void Start () {
     
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Enemy")
        {
            Debug.Log("Shoot!!");
        }
    }
	                                // Update is called once per frame
	                                void Update () {
                                        float distance = Vector3.Distance(gameObject.transform.position, myGrid[numX, numY].transform.position); * Time.deltaTime, 0, 0);



    }
}
