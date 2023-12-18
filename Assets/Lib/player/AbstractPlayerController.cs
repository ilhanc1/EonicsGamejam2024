using System;
using UnityEngine;

namespace Lib.player
{
    public abstract class AbstractPlayerController : MonoBehaviour
    {
        [SerializeField] protected float speed;
        [SerializeField] protected float jumpHeight;
        [SerializeField] protected KeyCode jumpKey;
        [SerializeField] protected KeyCode actionKey;
        protected Rigidbody2D rb;
        protected float moveDirection;
        protected PlayerState currentState = PlayerState.OnGround;

        protected virtual void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        protected virtual void Update()
        {
            moveDirection = Input.GetAxisRaw("Horizontal");
            if (CanJump())
            {
                currentState = PlayerState.Jump;
            }

            if (Input.GetKeyDown(actionKey))
            {
                OnAction();
            }
        }

        protected virtual void FixedUpdate()
        {
            Move();
            if (currentState == PlayerState.Jump)
            {
                Jump();
            }

            // Detects when the player is falling
            if (currentState != PlayerState.Falling && rb.velocity.y < 0)
            {
                Fall();
            }

            // Detects when the player lands on the ground
            if (currentState == PlayerState.Falling && rb.velocity.y == 0)
            {
                Land();
            }
        }

        /**
         * The Move method sets the x-velocity of the player's rigidbody to make it move with a constant velocity.
         */
        protected virtual void Move()
        {
            rb.velocity = new Vector2(moveDirection * speed, rb.velocity.y);
        }

        /**
         * This method checks if the player is allowed to jump.
         * The base method has two requirements:
         * 1) The jump key is pressed.
         * 2) The player is not in the air.
         */
        protected virtual bool CanJump()
        {
            return currentState == PlayerState.OnGround && Input.GetKeyDown(jumpKey);
        }

        /**
         * This method sets the y-velocity of the player's rigidbody such that it will reach the jump height.
         */
        protected virtual void Jump()
        {
            rb.velocity = new Vector2(rb.velocity.x, (float)Math.Sqrt(2.0f * rb.gravityScale * jumpHeight * 10));
            currentState = PlayerState.Jumping;
        }

        protected virtual void Fall()
        {
            currentState = PlayerState.Falling;
        }

        protected virtual void Land()
        {
            currentState = PlayerState.OnGround;
        }

        protected abstract void OnAction();

        protected enum PlayerState
        {
            OnGround,
            Jump,
            Jumping,
            Falling,
        }
    }
}