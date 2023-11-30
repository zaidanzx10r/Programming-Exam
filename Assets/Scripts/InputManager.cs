using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    private static Controls _controls;

    public static void Init(BallController myBall)
    {
        _controls = new Controls();

        _controls.Game.Movement.performed += ctx =>
        {
            myBall.SetMovementDirection(ctx.ReadValue<Vector3>());

        };
    }

    public static void Game()
    {
        _controls.Game.Enable();
        _controls.UI.Disable();
    }

    public static void UImode()
    {
        _controls.UI.Enable();
        _controls.Game.Disable();
    }


}
