//
// Node.cs
//

using UnityEngine;


namespace BehaviourTree
{
    // --------------------------------------------
    // ビヘイビアツリーノードベースクラス
    // --------------------------------------------
    public abstract class Node
    {

        protected GameObject _owner;
        protected Node _parentNode;
        protected string _name;

        private int _index = -1;
    }
}

