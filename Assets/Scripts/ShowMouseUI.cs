using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Kowit.GameDevelopment3
{
    public class ShowMouseUI : MonoBehaviour
    {
        private StarterAssetsInputs m_StarterAssetsInputs;
        private bool m_ShowMouse = false;

        void Start()
        {
            m_StarterAssetsInputs = GetComponent<StarterAssetsInputs>();    
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftAlt) && m_ShowMouse == false)
            {
                m_StarterAssetsInputs.cursorLocked = false;
                m_StarterAssetsInputs.cursorInputForLook = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                m_ShowMouse = true;
            }
            else if (Input.GetKeyDown(KeyCode.LeftAlt) && m_ShowMouse == true)
            {
                m_StarterAssetsInputs.cursorLocked = true;
                m_StarterAssetsInputs.cursorInputForLook = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                m_ShowMouse = false;
            }
        }
    }
}