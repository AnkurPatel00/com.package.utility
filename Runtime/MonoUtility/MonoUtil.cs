using UnityEngine;

namespace MonoUtility
{
    public class MonoUtil 
    {
        public static void ReleaseMemory()
        {
            Resources.UnloadUnusedAssets();
            System.GC.Collect();
        }
    }
}