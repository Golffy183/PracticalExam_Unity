using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Kowit.GameDevelopment3
{
    public class GenericInteractable : MonoBehaviour, IInteractable, IActorEnterExitHandler
    {
        [SerializeField] protected UnityEvent m_OnInteract = new();

        [SerializeField] protected UnityEvent m_OnActorEnter = new();
        [SerializeField] protected UnityEvent m_OnActorExit = new();

        public virtual void Interact(GameObject actor)
        {
            m_OnInteract.Invoke();
        }

        public virtual void ActorEnter(GameObject actor)
        {
            m_OnActorEnter.Invoke();
        }

        public virtual void ActorExit(GameObject actor)
        {
            m_OnActorExit.Invoke();
        }
    }
}