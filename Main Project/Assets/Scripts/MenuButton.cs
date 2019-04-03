using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public string SceneToLoad;
    Animator animator;
    public LevelManager levelController;
    public AudioControl audioControl;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void setSelected(bool b)
    {
        animator.SetBool("selected", b);
    }
    public void SetPressed(bool b)
    {
        animator.SetBool("click", b);
        audioControl.PlayAudioClip(2);
        if (b)
        {
            Invoke("changeScene", 1f);
        }

    }


    private void changeScene()
    {
        levelController.FadeToLevel(SceneToLoad);
    }
}
