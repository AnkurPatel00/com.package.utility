using UnityEngine;
using UnityEngine.UI;

namespace MonoUtility
{
    public class FPSCounter : MonoBehaviour
    {
        private Text mText;

        private void Awake()
        {
            mText = GetComponent<Text>();
        }
        void Update()
        {
            if (mText != null)
                mText.text = "FPS: " + (int)(1 / Time.deltaTime);
        }
    }
}
