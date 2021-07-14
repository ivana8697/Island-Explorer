using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelLaunch : MonoBehaviour
{
    public Animator ExitOrb;
    private AudioSource NextLevelSound;
    // Start is called before the first frame update
    void Start()
    {
        ExitOrb = GetComponent<Animator>();
        NextLevelSound = GetComponent<AudioSource>();
        
    }

    
   	void OnTriggerEnter (Collider Col) {   //on trigger of orb load next level
        ExitOrb.SetBool("isActivated", true);
        //Debug.Log("collison triggered!");
        
        if (Col.CompareTag("Player")){
            NextLevelSound.Play();
        	Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
	}
}