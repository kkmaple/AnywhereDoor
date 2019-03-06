using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public GameObject controller1;
    public GameObject controller2;
    public GameObject currentController;
    // Start is called before the first frame update
    void Start()
    {
        currentController = controller1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ControllerSwitch()
    {
        if (currentController == controller1)
            currentController = controller2;
        else
            currentController = controller1;
    }
}
