using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusTrast : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticles;

    void OnCollisionEnter2D(Collision2D collision)
    {
    if(collision.gameObject.tag == "ground")
        {
            dustParticles.Play();
        }    
    }

     void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            dustParticles.Stop();
        }
    }
}
