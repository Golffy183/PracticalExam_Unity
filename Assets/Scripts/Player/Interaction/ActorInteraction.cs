using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Kowit.GameDevelopment3
{
    public class ActorInteraction : MonoBehaviour
    {
        [SerializeField] protected ActorTriggerHandlerV2 m_ActorTriggerHandler;

        [SerializeField] private Key m_InteractionKey;

        [SerializeField] protected UnityEvent m_OnStartInteract = new();

        void Start()
        {
            if (m_ActorTriggerHandler == null)
            {
                m_ActorTriggerHandler = GetComponentInChildren<ActorTriggerHandlerV2>();
            }
        }

        void Update()
        {
            Keyboard keyboard = Keyboard.current;

            if (keyboard[m_InteractionKey].wasPressedThisFrame)
            {
                PerformInteraction();
            }
        }
        protected virtual void PerformInteraction()
        {
            var interactables = m_ActorTriggerHandler.GetInteractables();
            if (interactables?.Length > 0)
            {
                m_OnStartInteract.Invoke();
                foreach (var interactable in interactables)
                {
                    interactable.Interact(gameObject);
                }
            }
        }
    }
}