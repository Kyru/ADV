using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Animator animator;
    private string SceneToLoad;
    
    public void FadeToLevel(string SceneName){
        SceneToLoad = SceneName;
        animator.SetTrigger("next");        // name of the trigger
        OnFadeCompleted();
    }

    public void OnFadeCompleted(){
        SceneManager.LoadScene(SceneToLoad);
    }
}
