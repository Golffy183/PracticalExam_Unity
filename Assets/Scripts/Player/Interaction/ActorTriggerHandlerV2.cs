using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kowit.GameDevelopment3
{
    public class ActorTriggerHandlerV2 : ActorTriggerHandler
    {
        public virtual IInteractable[] GetInteractables()
        {

            m_TriggeredGameObjects.RemoveAll(gameject => gameject == null);

            if (m_TriggeredGameObjects.Count == 0)
            {
                return null;
            }

            return m_TriggeredGameObjects[0].GetComponents<IInteractable>();
        }
    }
}