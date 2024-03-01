using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    private Animator animator;

    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;
    public float score;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola) 
        {
            scoreManager.AddScore(score);
            vfxManager.PlayVFX(collision.transform.position);
            audioManager.PlayBumperSFX(collision.transform.position);
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;
            animator.SetTrigger("hit");
        }
    }
}
