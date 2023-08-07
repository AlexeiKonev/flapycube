using UnityEngine;

// PlayerScript requires the GameObject to have a Rigidbody component
[RequireComponent(typeof(Rigidbody))]
public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private Vector3 gravityDirection = Vector3.down;
    [SerializeField] private Rigidbody playerRigidbody;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GravityChange();
    }

    private void GravityChange()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            if (gravityDirection == Vector3.down)
            {
                gravityDirection = Vector3.up;
                playerRigidbody.velocity = gravityDirection;
            }
            else if (gravityDirection == Vector3.up)
            {
                gravityDirection = Vector3.down;
                playerRigidbody.velocity = gravityDirection;
            }

            Debug.Log("presed");
        }
    }
}
