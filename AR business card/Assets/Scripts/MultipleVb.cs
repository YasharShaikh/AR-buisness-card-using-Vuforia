using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MultipleVb : MonoBehaviour
{
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    public GameObject project1, project2, project3;
    // Start is called before the first frame update
    void Start()
    {
        project1.SetActive(false);
        project2.SetActive(false);
        project3.SetActive(false);

        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i= 0; i<virtualButtonBehaviours.Length; i++)
        {
            virtualButtonBehaviours[i].RegisterOnButtonPressed(onButtonPressed);
            virtualButtonBehaviours[i].RegisterOnButtonReleased(onButtonReleased);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void onButtonReleased(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "projectOne")
        {
            project1.SetActive(true);
            project2.SetActive(false);
            project3.SetActive(false);
        }
        if (vb.VirtualButtonName == "projectTwo")
        {
            project1.SetActive(false);
            project2.SetActive(true);
            project3.SetActive(false);
        }
        if (vb.VirtualButtonName == "projectThree")
        {
            project1.SetActive(false);
            project2.SetActive(false);
            project3.SetActive(true);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName+"vb not working");
        }
    }
   public void onButtonPressed(VirtualButtonBehaviour vb)
    {

    }
}
