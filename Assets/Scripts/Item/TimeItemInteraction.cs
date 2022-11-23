using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kowit.GameDevelopment3
{
    public class TimeItemInteraction : MonoBehaviour, IInteractable, IActorEnterExitHandler
    {
        public ItemTimeSettingPreset itemTime;

        private GameObject addTimeSound;
        private GameObject minusTimeSound;
        private Timer timer;


        void Start()
        {
            addTimeSound = GameObject.Find("ItemsSoundAddTime");
            minusTimeSound = GameObject.Find("ItemsSoundMinusTime");
            timer = GameObject.Find("Time - text").GetComponent<Timer>();
        }


        public void Interact(GameObject actor)
        {
            ItemTypeComponent itc = GetComponent<ItemTypeComponent>();

            if (itc != null)
            {
                switch (itc.Type)
                {
                    case ItemType.TIMEUP:
                        addTimeSound.GetComponent<AudioSource>().Play();
                        timer._EndTimeStamp += itemTime.TimeUse;
                        break;
                    case ItemType.TIMEDOWN:
                        minusTimeSound.GetComponent<AudioSource>().Play();
                        timer._EndTimeStamp -= itemTime.TimeUse;
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
