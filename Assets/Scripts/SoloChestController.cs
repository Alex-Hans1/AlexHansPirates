using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoloChestController : MonoBehaviour
{

    public Animator animator;
    public Score scoreobj;
    bool has_triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            
            animator.SetTrigger("Open");
            if(!has_triggered)
            {
                scoreobj.score += 500;
            }
            has_triggered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetTrigger("Close");
        }
    }
}
