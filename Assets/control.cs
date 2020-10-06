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
        //Vector3 Dist = Vector3.Distance(Camera.main.transform.position, transform.position) if (Dist <= TurnDist)
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("camera_is_near", true);
    }
}
