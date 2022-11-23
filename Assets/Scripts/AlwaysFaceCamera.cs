using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kowit.GameDevelopment3
{
    public class AlwaysFaceCamera : MonoBehaviour
    {
        private void Update()
        {
            transform.rotation =
                Quaternion.LookRotation(transform.position - Camera.main.transform.position);
        }
    }
}