using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerCollider : MonoBehaviour
{
    [SerializeField] GameObject player;

    public void OnTriggerEnter(Collider other){
        player.GetComponent<Animator>().SetBool("Dance", true);
    }
}
