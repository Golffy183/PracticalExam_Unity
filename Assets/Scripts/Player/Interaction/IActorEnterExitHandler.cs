using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kowit.GameDevelopment3
{
    public interface IActorEnterExitHandler
    {
        void ActorEnter(GameObject actor);
        void ActorExit(GameObject actor);
    }
}