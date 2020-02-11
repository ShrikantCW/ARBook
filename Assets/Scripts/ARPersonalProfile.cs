using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARPersonalProfile : MonoBehaviour, IVirtualButtonEventHandler
{
    [SerializeField] GameObject developerPlane, sportsPlane, travelPlane;


    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour[] vb = GetComponentsInChildren<VirtualButtonBehaviour>();

        for(int i=0;i<vb.Length;i++)
        {
            vb[i].RegisterEventHandler(this);
        }

        developerPlane.SetActive(false);
        sportsPlane.SetActive(false);
        travelPlane.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "VBDeveloper")
        {
            developerPlane.SetActive(true);
            sportsPlane.SetActive(false);
            travelPlane.SetActive(false);
        }
        else if (vb.VirtualButtonName == "VBSports")
        {
            developerPlane.SetActive(false);
            travelPlane.SetActive(false);
            sportsPlane.SetActive(true);
        }
        else if (vb.VirtualButtonName == "VBTravel")
        {
            sportsPlane.SetActive(false);
            developerPlane.SetActive(false);
            travelPlane.SetActive(true);
           // travelPlane.SetActive(true);
        }
        else if (vb.VirtualButtonName == "VBStop")
        {
            developerPlane.SetActive(false);
            sportsPlane.SetActive(false);
            travelPlane.SetActive(false);
            // travelPlane.SetActive(true);
        }
        else
        {
            throw new UnityException(" not supported " + vb.VirtualButtonName);
        }


    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("button released");
    }

   
}
