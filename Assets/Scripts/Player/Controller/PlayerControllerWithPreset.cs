using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Kowit.GameDevelopment3
{
    public abstract class PlayerControllerWithPreset : MonoBehaviour, IPlayerController
    {
        [SerializeField] protected CapsulePlayerControllerSettingsPreset m_Preset;

        protected virtual void Update()
        {
            Keyboard keyboard = Keyboard.current;

            if (keyboard[m_Preset.TurnLeftKey].isPressed)
            {
                TurnLeft();
            }
            else if (keyboard[m_Preset.TurnRightKey].isPressed)
            {
                TurnRight();
            }

            if (keyboard[m_Preset.ForwardKey].isPressed)
            {
                if (keyboard[m_Preset.SprintKey].isPressed)
                {
                    MoveForwardSprint();
                }
                else
                {
                    MoveForward();
                }
            }
            else if (keyboard[m_Preset.BackwardKey].isPressed)
            {
                MoveBackward();
            }
        }

        public abstract void MoveForward();
        public abstract void MoveForwardSprint();
        public abstract void MoveBackward();
        public abstract void TurnLeft();
        public abstract void TurnRight();
    }
}