namespace Condition
{
    using UnityEngine;

    public class BasicTernary : BaseCondition
    {
        [ContextMenu("BasicTernary")]
        void Ternary()
        {
            //if (score >= 50)
            //    showScoreTxt.text = $"More 50";
            //else
            //    showScoreTxt.text = $"Less 50";

            showScoreTxt.text = score >= 50 ? $"More 50" : $"Less 50";
        }
        [ContextMenu("SentParamiterTernary")]
        void ParamiterTernary()
        {
            //if (score >= 50)
            //    SetScore("Pass");
            //else
            //    SetScore("Fail");

            SetScore(score >= 50 ? "Pass" : "Fail");

            #region Internal
            void SetScore(string score)
            {
                showScoreTxt.text = score;
            }
            #endregion
        }
        [ContextMenu("VoidTernary")]
        void VoidTernary()
        {
            //if (score >= 50)
            //    A();
            //else
            //    B();

            //(score >= 50 ? (System.Action)(() => 
            //{
            //    score = 100;
            //    showScoreTxt.text = "IN A";
            //}) : (() => showScoreTxt.text = "IN B"))();

            (score >= 50 ? (System.Action)A : B)();

            #region Internal
            void A()
            {
                score = 100;
                showScoreTxt.text = "IN A";
            }
            void B()
            {
                showScoreTxt.text = "IN B";
            }
            #endregion
        }
    }
}
