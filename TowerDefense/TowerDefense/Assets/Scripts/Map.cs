﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{

    public GameObject MapTile;

    public float GN = 0.16f;

    //  gebruik tiles voor de grid roep het aan en dan moet je ze plaatsen met een switch
    //  de castle is dan op 1 terug dus dan moet je de castle verplaatsen als hij word aangeroepen

    private int[,] myGrid =
     {

           {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
           {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
           {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
           {1,1,1,1,1,3,5,5,5,5,5,5,5,6,1,1,1,1,1,1},
           {1,1,1,1,1,0,1,2,2,2,2,1,1,0,1,1,1,1,1,1},
           {1,1,3,5,5,8,2,2,4,4,2,2,1,0,1,1,1,1,1,1},
           {1,1,0,1,1,2,2,4,4,4,4,2,2,0,1,1,1,1,1,1},
           {1,1,0,1,2,2,4,4,4,4,4,4,2,0,1,1,1,1,1,1},
           {1,1,0,1,1,2,2,4,4,4,4,2,2,7,5,5,5,5,5,5},
           {1,1,0,1,1,1,2,2,4,2,2,2,1,1,1,1,1,1,1,1},
           {1,1,0,1,1,1,1,1,2,2,1,1,1,1,1,1,1,1,1,1},
           {1,1,7,5,5,5,5,5,5,6,1,1,1,1,1,1,1,1,1,1},
           {1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1},
           {1,1,1,1,1,1,1,3,5,8,1,1,1,1,1,1,1,1,1,1},
           {1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1},
           {1,1,1,1,1,1,1,7,5,5,5,5,5,5,5,6,1,1,1,1},
           {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,1},
           {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,1}

    };


    private void Start()
    {
        for (var y = 0; y < 18; y++)
        {
            for (var x = 0; x < 20; x++)
            {

            Debug.Log("second forloop");

                switch (myGrid[y, x])
                {

                    case 0:
                        GameObject TileVertical = GameObject.Instantiate(Resources.Load<GameObject>("Tile"), new Vector2((GN * x), (GN * y)), Quaternion.identity) as GameObject;
                        // Tile.GetComponent<RectTransform>().SetParent(MapTile.transform);
                        TileVertical.SetActive(true);
                        break;
                    case 1:
                      GameObject GrassTile = GameObject.Instantiate(Resources.Load<GameObject>("GrassTile"), new Vector2((GN * x), (GN * y)), Quaternion.identity) as GameObject;
                      //  GrassTile.GetComponent<RectTransform>().SetParent(MapTile.transform);
                        GrassTile.SetActive(true);
                        break;
                    case 2:
                        GameObject BushTreeTile = GameObject.Instantiate(Resources.Load<GameObject>("BushTreeTile"), new Vector2((GN * x), (GN * y)), Quaternion.identity) as GameObject;
                      //  BushTreeTile.GetComponent<RectTransform>().SetParent(MapTile.transform);
                        BushTreeTile.SetActive(true);
                        break;
                    case 3:
                        GameObject BochtTileRight = GameObject.Instantiate(Resources.Load<GameObject>("BochtTile"), new Vector2((GN * x), (GN * y)), Quaternion.identity) as GameObject;
                        // BochtTile.GetComponent<RectTransform>().SetParent(MapTile.transform);
                        BochtTileRight.SetActive(true);
                        break;
                    case 4:
                        GameObject WaterTile = GameObject.Instantiate(Resources.Load<GameObject>("WaterTile"), new Vector2((GN * x), (GN * y)), Quaternion.identity) as GameObject;
                        WaterTile.SetActive(true);
                        break;
                    case 5:
                        GameObject TileHorizontal = GameObject.Instantiate(Resources.Load<GameObject>("Tile"), new Vector2((GN * x), (GN * y)), Quaternion.identity) as GameObject;
                        TileHorizontal.transform.eulerAngles = new Vector3(transform.rotation.x,transform.rotation.y,90);
                        TileHorizontal.SetActive(true);
                        break;
                    case 6:
                        GameObject BochtLeft = GameObject.Instantiate(Resources.Load<GameObject>("BochtTile"), new Vector2((GN * x), (GN * y)), Quaternion.identity) as GameObject;
                        BochtLeft.transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, 90);
                        BochtLeft.SetActive(true);
                        break;
                    case 7:
                        GameObject BochtTileDown = GameObject.Instantiate(Resources.Load<GameObject>("BochtTile"), new Vector2((GN * x), (GN * y)), Quaternion.identity) as GameObject;
                        BochtTileDown.transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, 270);
                        BochtTileDown.SetActive(true);
                        break;
                    case 8:
                        GameObject BochtTileDownRight = GameObject.Instantiate(Resources.Load<GameObject>("BochtTile"), new Vector2((GN * x), (GN * y)), Quaternion.identity) as GameObject;
                        BochtTileDownRight.transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, 180);
                        BochtTileDownRight.SetActive(true);
                        break;



                }

                }
            }
        }
    }
