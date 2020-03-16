using UnityEditor;
using UnityEngine;

namespace MonoUtility
{
    public class ClearPrefsUtil : EditorWindow
    {
        [MenuItem("Tools/ClearAllPrefs")]
        public static void ClearAllPrefs()
        {
            PlayerPrefs.DeleteAll();
            Debug.Log("All PlayerPrefs were deleted");
        }
    }
}