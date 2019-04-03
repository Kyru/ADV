using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            animator.SetBool("open", true);
        } 
    }

    private void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Player"){
            animator.SetBool("open", false);
        }
    }
}
