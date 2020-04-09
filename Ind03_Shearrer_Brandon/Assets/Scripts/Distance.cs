using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public GameObject Cube1;
    public GameObject Cube2;
    public float Distance_;
    public Animator heliAni;
    public Animator zombAni;
    // Start is called before the first frame update
    void Start()
    {
        heliAni.GetComponent<Animator>();
        zombAni.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Distance_ = Vector3.Distance(Cube1.transform.position,Cube2.transform.position);
        if(Distance_ <.25){
            heliAni.Play("Fly_Away");
            zombAni.Play("Zombie_Jump");
            Debug.Log("DISTANCE CLOSE!");
        }
        else if(Distance_ > .25){
            heliAni.Play("MainRotor_Idle");
            zombAni.Play("Z_Walk1_InPlace");
            Debug.Log("Safe Distance.");
        }
    }
}
