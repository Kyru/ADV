using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerCollider : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject winnerParticles;
    public AudioControl audioControl;
    private bool ontrigger;

    void Start()
    {
        winnerParticles.SetActive(false);
        ontrigger = true;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (ontrigger)
        {
            player.GetComponent<Animator>().SetBool("Dance", true);
            winnerParticles.SetActive(true);
            audioControl.PlayAudioClip(1);
        }
    }
    private void OnTriggerExit(Collider other) {
        ontrigger = false;    
    }
}
