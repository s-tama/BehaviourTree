//
// BehaviourTree.cs
//

using System.Collections.Generic;
using UnityEngine;


namespace BehaviourTree
{
    public enum BehaviourStatus
    {
        Inactive,   // 非アクティブ
        Success,    // 成功
        Failure,    // 失敗
        Running,    // 実行中
        Completed   // 完了
    }

    public class BehaviourTree
    {

        public class ConditionalReevaluate
        {
            private int _index;
            private BehaviourStatus _status;
            private int _compositeIndex;
            private int _stackIndex;

            public void Initialize(int i, BehaviourStatus status, int stack, int composite)
            {
                _index = i;
                _status = status;
                _stackIndex = stack;
                _compositeIndex = composite;
            }
        }


        private GameObject _owner;
        private Node _rootNode;

        private List<Node> _nodeList = new List<Node>();
        private List<ConditionalReevaluate> _reevaluateList = new List<ConditionalReevaluate>();

        // 現在実行中の枝のスタックを保持
        private Stack<int> _activeStack = new Stack<int>();

        private bool _isCompleted = false;
        private int _activeNodeIndex = -1;


        public BehaviourTree(GameObject owner)
        {
            _owner = owner;
        }

        // -----------------------------------------------------
        // アクティブなノードとしてスタックにプッシュする
        // -----------------------------------------------------
        private void Push(Node node)
        {
            //if(_activeStack.Count == 0 || _activeStack.Peek()
        }
    }
}

