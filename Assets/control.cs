using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("camera_is_near", false);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        float dis = Vector3.Distance(Camera.main.transform.position, transform.position);
        if(dis<0.15)
            animator.SetBool("camera_is_near", true);
        else
            animator.SetBool("camera_is_near", false);
        Debug.Log("Hey"+dis);
    }
}
