using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;
using Unity.VisualScripting;

public class ChestController : MonoBehaviour
{
    public Animator animator;
    public GameObject GameObject;
    public Score scoreobj;
    
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<GameObject>().SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKey(KeyCode.E))
        {
            animator.SetTrigger("Dig");
            scoreobj.score += 100;
        }
    }
}
