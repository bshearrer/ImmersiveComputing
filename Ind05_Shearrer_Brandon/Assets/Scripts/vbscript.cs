using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class vbscript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbutton;
    public Animator animation;
    // Start is called before the first frame update
    void Start()
    {
        vbutton = GameObject.Find("VirtualButton");
        vbutton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        animation.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        Debug.Log("Button Pressed!");
        animation.Play("cube_animation");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){
        Debug.Log("Button Released.");
        animation.Play("none");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
