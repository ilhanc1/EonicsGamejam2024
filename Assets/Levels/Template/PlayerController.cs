using Lib.player;
using UnityEngine;

namespace Levels.Template
{
    public class PlayerController : AbstractPlayerController
    {
        protected override void Awake()
        {
            base.Awake();
        }

        protected override void Move()
        {
            base.Move();
        }

        protected override bool CanJump()
        {
            return base.CanJump();
        }

        protected override void Jump()
        {
            base.Jump();
        }

        protected override void Fall()
        {
            base.Fall();
        }

        protected override void Land()
        {
            base.Land();
        }

        protected override void OnAction()
        {
            Debug.Log("Action key pressed!");
        }
    }
}