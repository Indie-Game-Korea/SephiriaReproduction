using UnityEngine;

namespace ToyBoxNightmare
{
    public class TestGame : GameBase
    {
        public override GameMode GameMode => GameMode.Survival;

        private float curTime = 0f;

        public override void Initialize()
        {
            base.Initialize();
        }

        void Start()
        {

        }

        void Update()
        {
            Debug.Log(curTime.ToString("N0"));
            curTime += Time.deltaTime;
        }
    }
}