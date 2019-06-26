using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)

    {
        var enemyCol = col.collider;
        var enemyGO = enemyCol.gameObject;
        var swordGO = col.otherCollider.gameObject;


        
        if (enemyGO.tag == "Enemy")
        {
            Debug.Log("si ataca");
            enemyGO.SetActive(false);
        }


    }

}
