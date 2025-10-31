using UnityEngine;
using UnityEngine.InputSystem;

public class RiggedWalekr : MonoBehaviour
{

    private Vector2 movement;
    private Rigidbody2D myBody;
    private Animator myAnimator;

    [SerializeField] private int speed = 5;
    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    private void OnMovement2(InputValue value)
    {
        movement = value.Get<Vector2>();

        myAnimator.SetFloat("x", movement.x);
        myAnimator.SetFloat("y", movement.y);
    }


    private void FixedUpdate()
    {
        myBody.linearVelocity = movement * speed;
    }
}
