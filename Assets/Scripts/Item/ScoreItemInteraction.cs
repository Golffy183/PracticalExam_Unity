using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kowit.GameDevelopment3
{
    public class ScoreItemInteraction : MonoBehaviour, IInteractable, IActorEnterExitHandler
    {
        public ItemScoreSettingPreset itemScore;
        private ScoreGame m_ScoreGame;

        private GameObject addScoreSound;
        private GameObject minusScoreSound;

        void Start()
        {
            addScoreSound = GameObject.Find("ItemsSoundAddScore");
            minusScoreSound = GameObject.Find("ItemsSoundMinusScore");
            m_ScoreGame = GameObject.Find("ScoreManager").GetComponent<ScoreGame>();
        }

        public void Interact(GameObject actor)
        {
            ItemTypeComponent itc = GetComponent<ItemTypeComponent>();
            if (itc != null)
            {
                switch (itc.Type)
                {
                    case ItemType.ADDSCORE:
                        addScoreSound.GetComponent<AudioSource>().Play();
                        m_ScoreGame.m_Score += itemScore.ScoreUse;
                        break;
                    case ItemType.MINUSSCORE:
                        minusScoreSound.GetComponent<AudioSource>().Play();
                        m_ScoreGame.m_Score -= itemScore.ScoreUse;
                        break;
                }
            }
            Destroy(this.gameObject, 0);
        }

        public void ActorEnter(GameObject actor)
        {
            
        }

        public void ActorExit(GameObject actor)
        {

        }
    }
}