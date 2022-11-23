using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kowit.GameDevelopment3
{
    public class DontDestroySoundPlayer : MonoBehaviour
    {
        public static DontDestroySoundPlayer instance;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
                return;
            }

            DontDestroyOnLoad(gameObject);
        }
    }
}