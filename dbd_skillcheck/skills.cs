using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skills : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SCArrow"))
        {
            collision.gameObject.GetComponentInParent<NewBehaviourScript>().onSuccessArea = true;
            Debug.Log("girdi");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SCArrow"))
        {
            collision.gameObject.GetComponentInParent<NewBehaviourScript>().onSuccessArea = false;
            Debug.Log("çýktý");
        }
    }
}
