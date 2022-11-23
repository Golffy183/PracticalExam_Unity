using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kowit.GameDevelopment3
{
    public interface IPlayerController
    {
        void MoveForward();
        void MoveForwardSprint();

        void MoveBackward();

        void TurnLeft();
        void TurnRight();
    }
}