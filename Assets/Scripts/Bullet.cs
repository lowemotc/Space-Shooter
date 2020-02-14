using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{


    public GameObject bullet;
    public Rigidbody2D rb;
    public ParticleSystem rockParticles;
    GameObject go;

    private void Start()
    {
        go = GameObject.Find("Score");
    }

    void Update()
    {
        if (bullet.transform.position.x > 50 || bullet.transform.position.x < -50 || bullet.transform.position.y > 50 || bullet.transform.position.y < -50)
        {
            Destroy(bullet);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            Destroy(collision.gameObject);
            Destroy(bullet);
        }

        if (collision.gameObject.tag == "Asteroid")
        {
            go.GetComponent<Score>().Invoke("ScoreUp", 0);
        }
    }
}
