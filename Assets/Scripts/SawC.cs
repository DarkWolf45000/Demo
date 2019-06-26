using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawC : MonoBehaviour
{
    private Vector3 vo;
    public PlayerM pm;
    public GameObject pd;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        vo = pm.GetVo();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        /* if (anim.GetCurrentAnimatorStateInfo(0).IsName("RealD"))
         {
             // Avoid any reload.
             anim.SetBool("Dead", false);
             pd.SetActive(false);
             pm.gameObject.SetActive(true);
             pm.SetDead(false);
         }*/

        if (pm.GetDead())
        {
           // pd.SetActive(false);
            pm.gameObject.SetActive(true);
            pm.SetDead(false);
        }

        
    }

    private void OnCollisionEnter2D(Collision2D col)

    {
        var playerCol = col.collider;
        var playerGO = playerCol.gameObject;
        var sawGO = col.otherCollider.gameObject;

        if (playerGO.tag == "Main")
        {
            Vector3 change = pm.transform.position;
            pd.transform.position = change;
            pm.SetDead(true);
            playerGO.SetActive(false);
            pd.SetActive(true);
           // anim.SetBool("Dead",true);
            playerGO.transform.position = vo;
            
        }


    }
}
