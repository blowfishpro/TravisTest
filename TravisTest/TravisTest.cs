using UnityEngine;

namespace TravisTest
{
    [KSPAddon(KSPAddon.Startup.Instantly, true)]
    public class TravisTest : MonoBehaviour
    {
        public void Awake()
        {
            Debug.Log("Hello world!");
        }
    }
}
