using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getXZCoordinates : MonoBehaviour
{
    public float centerX;
    public float centerY;
    public float centerZ;
    public GameObject WaypointCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //imgCenterX = GameObject.Find("ImageCube").transform.position.x;
        //imgCenterZ = GameObject.Find("ImageCube").transform.position.y;
        centerX = gameObject.transform.position.x;
        centerY = gameObject.transform.position.y;
        centerZ = gameObject.transform.position.z;
        
        WaypointCube.transform.position = new Vector3(centerX, 0, centerZ);

        //print("Position X: " + imgCenterX);
        //print("Position Z: " + imgCenterZ);
    }
}
