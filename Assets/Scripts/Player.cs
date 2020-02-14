using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public float maxLife;
    public float life;
    public Vector3 scaleByLife;


    // Use this for initialization
    void Start()
    {
        maxLife = 3;
        life = 3;
    }

    void Update()
    {
        scaleByLife.x = (2 / maxLife * life);
        scaleByLife.y = (2 / maxLife * life);
        if (life != maxLife)
        {
            player.transform.localScale = scaleByLife;
        }

        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

   void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            life -= 1;
            Destroy(collision.gameObject);
        }
    }
}