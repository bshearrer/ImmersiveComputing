using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using Vuforia;
public class vbscript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbutton;
    public GameObject buttonText;
    public Animator right_door_ani;
    public Animator left_door_ani;

    public AudioClip doorOpen;
    public AudioClip doorClose;
    public AudioSource source;

    private bool doorsOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        vbutton = GameObject.Find("VirtualButton");

        vbutton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        right_door_ani.GetComponent<Animator>();
        left_door_ani.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        Debug.Log("Button Pressed!");

        
        //Code runs if opening doors
        if(doorsOpen == false){

            buttonText.GetComponent<TextMesh>().text = "Press to\nClose Doors";
            buttonText.GetComponent<TextMesh>().color = Color.red;
            right_door_ani.Play("rd_open");
            left_door_ani.Play("ld_open");
            source.PlayOneShot(doorOpen);
            doorsOpen = true;
        }
        //Code runs if closing doors
        else if(doorsOpen == true) {
            buttonText.GetComponent<TextMesh>().text = "Press to\nOpen Doors";
            buttonText.GetComponent<TextMesh>().color = Color.green;
            left_door_ani.Play("ld_close");
            right_door_ani.Play("rd_close");
            source.PlayOneShot(doorClose);
            doorsOpen = false;
        }

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){
        Debug.Log("Button Released.");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
