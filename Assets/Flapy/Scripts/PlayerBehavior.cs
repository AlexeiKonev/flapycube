using UnityEngine;

// PlayerScript requires the GameObject to have a Rigidbody component
[RequireComponent(typeof(Rigidbody))]
public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private Vector3 gravityDirection = Vector3.up;
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private int currentCoinsCount = 0;
    private float thrust = 300f;

    //[SerializeField] private int currentCoinsCount;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GravityChange();
    }
    private void CollectCoins()
    {

    }
    private void GravityChange()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.Space))
        {

            playerRigidbody.AddForce(transform.up * thrust);

            //if (gravityDirection == Vector3.down)
            //{
            //    gravityDirection = Vector3.up;
            //    playerRigidbody.velocity = gravityDirection;
            //}
            //else if (gravityDirection == Vector3.up)
            //{
            //    gravityDirection = Vector3.down;
            //    playerRigidbody.velocity = gravityDirection;
            //}

            Debug.Log("presed");
        }
    }
}
