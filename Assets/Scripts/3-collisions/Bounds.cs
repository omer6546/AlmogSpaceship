using UnityEngine;
using UnityEngine.SceneManagement;

public class Bounds : MonoBehaviour
{

    [SerializeField] Collider2D other;
    void Update()
    {
        
        if (other.tag == "Player")
        {
            Debug.Log("homo"); 
           // transform.position = new Vector3(-transform.position.x, transform.position.y, 0);
            other.transform.position = new Vector3(-transform.position.x, transform.position.y, 0);
        }
    }
}