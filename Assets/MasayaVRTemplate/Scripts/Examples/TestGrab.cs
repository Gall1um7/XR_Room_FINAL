using UnityEngine;

public class TestGrab : MonoBehaviour, IGrabbable
{
    VRControllerGrab currentController;
    public GameObject RigidbodyObject;
    public void GrabStart(VRControllerGrab controller)
    {
        Debug.Log("Grab Start");

        RigidbodyObject.GetComponent<Rigidbody>().isKinematic = true; //TURNS OFF GRAVITY

        if(currentController != null)
        {
            if(currentController != controller)
            {
                currentController.GrabEnd();
                currentController = controller;
                ParentObject();
            }
        }
        else
        {
            currentController = controller;
            ParentObject();
        }
    }

    void ParentObject()
    {
        transform.parent = currentController.transform;
    }

    public void GrabEnd()
    {
        RigidbodyObject.GetComponent<Rigidbody>().isKinematic = false; //TURNS ON GRAVITY

        transform.parent = null;
        currentController.GrabGone(true, transform);

        currentController = null;
    }
}
