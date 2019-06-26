using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour
{
    private Animator anim;
    public PlayerM pm;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown("j"))
        {
            anim.SetBool("Attack", true);
        }
        

        if (pm.GetLR())
        {
            anim.SetBool("AttackL", false);
            anim.SetBool("AttackR", true);
        }
        else
        {
            anim.SetBool("AttackR", false);
            anim.SetBool("AttackL", true);
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("AttackR") || anim.GetCurrentAnimatorStateInfo(0).IsName("AttackL"))
        {
            // Avoid any reload.
            anim.SetBool("Attack", false);
        }
        
    }
}
