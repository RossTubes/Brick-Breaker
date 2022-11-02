using UnityEngine;

public class Ball : MonoBehaviour
{
   public new Rigidbody2D rigidbody { get; private set; }

    public float speed = 500f;
    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetBall();
    }

    public void ResetBall()
    {
        this.transform.position = Vector2.zero;
        this.rigidbody.velocity = Vector2.zero;

        Invoke(nameof(SetRandomTrajectory), 1f); //to make a delay before the game starts
    }
    private void SetRandomTrajectory()
    {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-1f, 1f); //random left or right force
        force.y = -1f; //start force down

        //this.rigidbody.AddForce(force.normalized * this.speed);
        this.rigidbody.AddForce(force.normalized * this.speed);
    }

    public void AddForce(Vector2 force)
    {
        rigidbody.AddForce(force);
    }
}
