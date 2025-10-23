using UnityEngine;

public class WoodDoorOpen : MonoBehaviour,IInteractable
{
    [SerializeField] Animator animator;

 public void Interact()
    {
        
    }
    public void InteractEnd()
    {
        
        
    }
    public void InteractStart(VRControllerInteraction controller)
    {
        animator.SetTrigger("WoodDoor");
    }
}
