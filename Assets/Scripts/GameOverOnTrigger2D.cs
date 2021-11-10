using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class GameOverOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger game over")]
    [SerializeField] string triggeringTag;
    [SerializeField] static int life = 3;
    [SerializeField] public GameObject[] hearts;
    

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            Destroy(other.gameObject);
            if (life >= 1)
            {
                life--;
                this.gameObject.transform.position = new Vector3(0, -3, 0);
            }
            if (life < 1)
            {
                Debug.Log("Game over!");
                Application.Quit();
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #endif

            }
                    
        }
    }
    private void Start()
    {
        
    }
    private void Update() {
        if (life < 3)
        {
            Destroy(hearts[2].gameObject);
        }
        if (life < 2)
        {
            Destroy(hearts[1].gameObject);
        }
        if (life < 1)
        {
            Destroy(hearts[0].gameObject);
        }
    }

}
