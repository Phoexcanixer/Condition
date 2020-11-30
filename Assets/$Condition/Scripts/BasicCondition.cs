namespace Condition
{
    using System;
    using UnityEngine;

    public class BasicCondition : BaseCondition
    {
        public Vector4 grid;
        [ContextMenu("BasicIf")]
        void ConditionIf()
        {
            if (score >= 100)
                showScoreTxt.text = $"Full Score";
        }
        [ContextMenu("BasicIfElse")]
        void ConditionIfElse()
        {
            if (score >= 80)
                showScoreTxt.text = $"A: {score}";
            else
                showScoreTxt.text = $"LessA: {score}";
        }
        [ContextMenu("BasicIfElseIf")]
        void ConditionIfElseIf()
        {
            if (score >= 80)
                showScoreTxt.text = $"A: {score}";
            else if (score >= 75)
                showScoreTxt.text = $"B+: {score}";
            else if (score >= 70)
                showScoreTxt.text = $"B: {score}";
            else if (score >= 65)
                showScoreTxt.text = $"C+: {score}";
            else if (score >= 60)
                showScoreTxt.text = $"C: {score}";
            else if (score >= 55)
                showScoreTxt.text = $"D+: {score}";
            else if (score >= 50)
                showScoreTxt.text = $"D: {score}";
            else
                showScoreTxt.text = $"F: {score}";
        }
        [ContextMenu("BasicNestedIf")]
        void ConditionNestedIf()
        {
            if (score != 10)
            {
                // Nested //
                if (score > 5)
                    showScoreTxt.text = $"More: {score}";
                else
                    showScoreTxt.text = $"Less: {score}";
            }
            else
                showScoreTxt.text = $"Ten: {score}";
        }
        [ContextMenu("BasicSwichCase")]
        void ConditionSwichCase()
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday: showScoreTxt.text = "Red"; break;
                case DayOfWeek.Monday: showScoreTxt.text = "Yellow"; break;
                case DayOfWeek.Tuesday: showScoreTxt.text = "Pink"; break;
                case DayOfWeek.Wednesday: showScoreTxt.text = "Green"; break;
                case DayOfWeek.Thursday: showScoreTxt.text = "Orange"; break;
                case DayOfWeek.Friday: showScoreTxt.text = "SkyBlue"; break;
                default: showScoreTxt.text = "Purple"; break;
            }
        }
        [ContextMenu("BasicConditionInSwichCase")]
        void ConditionConditionInSwichCase()
        {
            switch (grid)
            {
                case Vector4 _grid when _grid.Equals(Vector4.zero): showScoreTxt.text = "Zero"; break;

                case Vector4 _grid when _grid.x < 0:
                case Vector4 _grids when _grids.y < 0: showScoreTxt.text = "x or y Less"; break;

                case Vector4 _grid when _grid.z == 0 || _grid.w == 0: showScoreTxt.text = "z or w Zero"; break;
            }
        }
    }
}
