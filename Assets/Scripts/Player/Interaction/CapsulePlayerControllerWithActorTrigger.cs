using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Kowit.GameDevelopment3
{
    public class CapsulePlayerControllerWithActorTrigger : CapsulePlayerControllerWithPreset
    {
        [SerializeField] protected ActorTriggerHandler m_ActorTriggerHandler;

        protected override void Update()
        {
            base.Update();

            Keyboard keyboard = Keyboard.current;

            if (keyboard[m_Preset.InteractionKey].wasPressedThisFrame)
            {
                PerformInteraction();
            }
        }

        protected virtual void PerformInteraction()
        {
            var interactable = m_ActorTriggerHandler.GetInteractable();

            if (interactable != null)
            {
                interactable.Interact(gameObject);
            }
        }
    }
}