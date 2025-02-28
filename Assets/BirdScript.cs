using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public Rigidbody2D wingsRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
                logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
            {myRigidbody.linearVelocity = Vector2.up * flapStrength;}
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
            {wingsRigidbody.linearVelocity = Vector2.up * flapStrength;}

        if(transform.position.y < -18 || transform.position.y > 18 || transform.position.x < -25)
        {
            logic.gameOver();
            birdIsAlive = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
