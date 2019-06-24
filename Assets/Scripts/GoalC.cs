using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoalC : MonoBehaviour
{
    private int nivel;
    // Start is called before the first frame update
    void Start()
    {
        nivel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Main"))
        {
            Debug.Log("Winner");
            if (SceneManager.GetActiveScene().name.Equals("Nivel1"))
            {
                nivel += 1;
                SceneManager.LoadScene("Nivel 2");
            }
            else if(SceneManager.GetActiveScene().name.Equals("Nivel 2"))
            {
                SceneManager.LoadScene("Nivel 3");
            }
            else if (SceneManager.GetActiveScene().name.Equals("Nivel 3"))
            {
                SceneManager.LoadScene("Nivel 4");
            }

        }
            
        
    }


}
