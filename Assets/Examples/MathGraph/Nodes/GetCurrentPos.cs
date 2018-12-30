using UnityEngine;

namespace XNode.Examples.MathNodes
{
    public class GetCurrentPos:XNode.Node
    {
        [Input] public Vector3 CurrentPos;
        [Output] public float CurrentX;
        [Output] public float CurrentY;
        [Output] public float CurrentZ;

        public override object GetValue(NodePort port)
        {
            string fieldName= port.fieldName;
            if(fieldName== "CurrentX")
            {
                return CurrentPos.x;
            }
            else if(fieldName== "CurrentY")
            {
                return CurrentPos.y;
            }
            else if(fieldName == "CurrentZ")
            {
                return CurrentPos.z;
            }
            return default(float);
        }

    }
}
