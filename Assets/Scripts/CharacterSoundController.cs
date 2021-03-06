using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundController : MonoBehaviour
{
    private AudioSource audioPlayer;
 
    public AudioClip jump;

    public AudioClip scoreHighlight;

    public void PlayScoreHighlight()
    {
        audioPlayer.PlayOneShot(scoreHighlight);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void PlayJump()
    {
        audioPlayer.PlayOneShot(jump);
    }
}
