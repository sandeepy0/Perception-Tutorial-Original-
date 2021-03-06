using System.Diagnostics;

using UnityEngine;

namespace Unity.Simulation.Client
{
    public class TestScript : MonoBehaviour
    {
        Stopwatch _timer;

        void Start()
        {
            _timer = new Stopwatch();
            _timer.Start();
        }

        void Update()
        {
            var seconds = _timer.Elapsed.TotalSeconds;
            if (seconds >= 60)
            {
                Application.Quit();
            }
        }
    }
}
