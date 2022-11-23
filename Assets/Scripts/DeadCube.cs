using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Kowit.GameDevelopment3
{
    public class DeadCube : MonoBehaviour, IInteractable, IActorEnterExitHandler
    {
        protected StarterAssetsInputs m_StarterAssetsInputs;

        void Start()
        {
            Scene currentScene = SceneManager.GetActiveScene();

            string sceneName = currentScene.name;

            if (sceneName == "Stage2")
            {
                m_StarterAssetsInputs = GameObject.Find("PlayerArmature").GetComponent<StarterAssetsInputs>();
            }
        }

        public void Interact(GameObject actor)
        {

        }

        public void ActorEnter(GameObject actor)
        {
            Scene currentScene = SceneManager.GetActiveScene();

            string sceneName = currentScene.name;

            if (sceneName == "Stage1")
            {
                var Player = GameObject.Find("Capsule Player (RC)");
                Player.SetActive(false);
            }
            else if (sceneName == "Stage2")
            {
                var Player = GameObject.Find("PlayerArmature");
                Player.SetActive(false);
            }
            var Time = GameObject.Find("Time - text");
            Time.GetComponent<Timer>().EndTimer();

            var Score = GameObject.Find("ScoreManager");
            Score.GetComponent<ScoreGame>().EndStage();

            var pause = GameObject.Find("Canvas");
            pause.GetComponent<PauseGame>().Pause();

            var LostSound = GameObject.Find("LostSound");
            LostSound.GetComponent<AudioSource>().Play();

            if (sceneName == "Stage2")
            {
                ShowMouse();
            }

            var gameFlow = GameObject.Find("GameAppFlowManager");
            gameFlow.GetComponent<GameAppFlowManager>().LoadSceneAdditive("GameoverScene");
        }

        public void ActorExit(GameObject actor)
        {

        }

        void ShowMouse()
        {
            m_StarterAssetsInputs.cursorLocked = false;
            m_StarterAssetsInputs.cursorInputForLook = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}