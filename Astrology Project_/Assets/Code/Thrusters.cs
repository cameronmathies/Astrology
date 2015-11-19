using UnityEngine;
using System.Collections;

public class Thrusters : MonoBehaviour {

    /*You need to set the emit of this particle system to 0 at the editor,
 so it will not emit at all during play-mode by itself*/
    public ParticleSystem thruster;
    /* The audio, I am not sure about this one as I have little experience 
    with audio (but you can google on how to play audio in unity*/
    public AudioSource audio;

    void Update()
    {

        if (Input.GetKey(KeyCode.Z))
        {
            thruster.Emit(10); //Emit some particle
            audio.Play();
        }
    }
}
