using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CaskDetetor : MonoBehaviour
{
    [SerializeField] float timelate = 1f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
   void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "ground")
        {
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("Gotofinish", timelate);
        }
    }

    void Gotofinish()
    {
        SceneManager.LoadScene(0);
    }
}
