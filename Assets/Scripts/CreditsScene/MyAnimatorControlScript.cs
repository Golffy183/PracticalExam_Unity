using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kowit.GameDevelopment3
{
    public class MyAnimatorControlScript : MonoBehaviour
    {
        protected Animator m_Animator;

        private static readonly int BootyHipHopDance = Animator.StringToHash("BootyHipHopDance");
        private static readonly int ChickenDance = Animator.StringToHash("ChickenDance");
        private static readonly int TwistDance = Animator.StringToHash("TwistDance");
        private static readonly int HappyIdleTrigger = Animator.StringToHash("HappyIdleTrigger");
        private static readonly int HappyIdleBool = Animator.StringToHash("HappyIdleBool");

        void Start()
        {
            m_Animator = GetComponent<Animator>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                TriggerBootyHipHopDance();
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                TriggerChickenDance();
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                TriggerTwistDance();
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                TriggerHappyIdle();
                BoolHappyIdleOn();
            }
            if (Input.GetKeyUp(KeyCode.M))
            {
                BoolHappyIdleOff();
            }
        }

        void TriggerBootyHipHopDance()
        {
            m_Animator.SetTrigger("BootyHipHopDance");
        }

        void TriggerChickenDance()
        {
            m_Animator.SetTrigger("ChickenDance");
        }

        void TriggerTwistDance()
        {
            m_Animator.SetTrigger("TwistDance");
        }

        void TriggerHappyIdle()
        {
            m_Animator.SetTrigger("HappyIdleTrigger");
        }

        void BoolHappyIdleOn()
        {
            m_Animator.SetBool("HappyIdleBool", true);
        }
        void BoolHappyIdleOff()
        {
            m_Animator.SetBool("HappyIdleBool", false);
        }
    }
}