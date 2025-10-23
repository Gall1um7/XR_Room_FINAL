using UnityEngine;

public class BoxTouch : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField]Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == obj)
        {
            anim.SetTrigger("Move");
        }
    }
}
