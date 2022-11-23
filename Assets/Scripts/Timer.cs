using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using StarterAssets;
using UnityEngine.SceneManagement;

namespace Kowit.GameDevelopment3
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] protected int LevelPassScore = 10000;
        [SerializeField] protected float m_TimerDuration = 30;
        protected bool _IsTimerStart = false;
        protected float _StartTimeStamp;
        public float _EndTimeStamp;
        [SerializeField] protected float _CurrentTime;
        protected int CurrentTime = 0;
        [SerializeField] protected TextMeshProUGUI Text;
        protected StarterAssetsInputs m_StarterAssetsInputs;

        private void Start()
        {
            Scene currentScene = SceneManager.GetActiveScene();

            string sceneName = currentScene.name;

            if (sceneName == "Stage2")
            {
                m_StarterAssetsInputs = GameObject.Find("PlayerArmature").GetComponent<StarterAssetsInputs>();
                LockMouse();
            }

            
            StartTimer();
        }

        private void Update()
        {
            if (!_IsTimerStart) return;

            _CurrentTime = _EndTimeStamp - Time.time;
            CurrentTime = (int)_CurrentTime;
            Text.text = "Time : " + CurrentTime.ToString();

            if (Time.time >= _EndTimeStamp)
            {
                EndTimer();
            }
        }

        public virtual void StartTimer()
        {
            if (_IsTimerStart) return;

            _IsTimerStart = true;
            _StartTimeStamp = Time.time;
            _EndTimeStamp = Time.time + m_TimerDuration;
        }

        public virtual void EndTimer()
        {
            _IsTimerStart = false;
            var Score = GameObject.Find("ScoreManager");
            var gameFlow = GameObject.Find("GameAppFlowManager");
            var pause = GameObject.Find("Canvas");
            var WinSound = GameObject.Find("WinSound");
            var LostSound = GameObject.Find("LostSound");

            Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;

            

            if (CurrentTime <= 0)
            {
                Score.GetComponent<ScoreGame>().EndStage();
                pause.GetComponent<PauseGame>().Pause();

                if (ScoreGame.Score < LevelPassScore)
                {
                    LostSound.GetComponent<AudioSource>().Play();
                    if (sceneName == "Stage2")
                    {
                        ShowMouse();
                    }

                    gameFlow.GetComponent<GameAppFlowManager>().LoadSceneAdditive("GameoverScene");
                }
                else if (ScoreGame.Score >= LevelPassScore)
                {
                    WinSound.GetComponent<AudioSource>().Play();
                    if (sceneName == "Stage2")
                    {
                        ShowMouse();
                    }
                    gameFlow.GetComponent<GameAppFlowManager>().LoadSceneAdditive("WinScene");
                }
            }
        }

        void ShowMouse()
        {
            m_StarterAssetsInputs.cursorLocked = false;
            m_StarterAssetsInputs.cursorInputForLook = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        void LockMouse()
        {
            m_StarterAssetsInputs.cursorLocked = true;
            m_StarterAssetsInputs.cursorInputForLook = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}