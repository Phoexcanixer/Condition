namespace Condition
{
    using UnityEngine;
    using UnityEngine.UI;

    public abstract class BaseCondition : MonoBehaviour
    {
        [Range(0, 100)] public int score;
        public Text showScoreTxt;
        void Start() => Debug.Log(GetType());
    }
}

