using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] lives;
    public int life = 3;
    private bool dead = false;


    // Start is called before the first frame update
    void Start()
    {
        life = lives.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (life >= 1)
        {
            life = life - 1;
            Destroy(lives[life].gameObject);
            if (life < 1)
            {
                dead = true;
            }
            if (dead == true)
            {
                
                //do
            }
        }
        
    }

    //public void TakeLife(int num)
    //{
        
    //}
}
