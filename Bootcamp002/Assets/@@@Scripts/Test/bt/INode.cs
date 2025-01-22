//노드의 통일성을 위해 인터페이스로 구현
public interface INode
{
    public enum INodeState
    {
        Running,
        Success,
        Failure,
    }

    /// <summary>
    /// 해당 노드의 상태 반환
    /// </summary>
    public INodeState Evaluate();
}