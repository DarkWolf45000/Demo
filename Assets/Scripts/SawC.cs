using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawC : MonoBehaviour
{
    public PlayerM pm;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

         if (anim.GetCurrentAnimatorStateInfo(0).IsName("Death") && /*anim.GetCurrentAnimatorStateInfo(0).length<*/!(anim.GetCurrentAnimatorStateInfo(0).normalizedTime<1f) )
         {
              // Avoid any reload.
                anim.SetBool("Dead", false);
                pm.gameObject.transform.position = pm.GetVo();
                pm.SetDead(false);

        }

        /* if (pm.GetDead())
         {
            // pd.SetActive(false);
             pm.gameObject.SetActive(true);
             pm.SetDead(false);
         }*/


    }

    private void OnCollisionEnter2D(Collision2D col)

    {
        var HplayerCol = col.collider;
        var HplayerGO = HplayerCol.gameObject;
        var sawGO = col.otherCollider.gameObject;

        if (HplayerGO.tag == "Main")
        {

            pm.SetDead(true);
            anim.SetBool("Dead",true);
            
        }


    }
}
