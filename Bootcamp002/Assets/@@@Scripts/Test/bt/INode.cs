//����� ���ϼ��� ���� �������̽��� ����
public interface INode
{
    public enum INodeState
    {
        Running,
        Success,
        Failure,
    }

    /// <summary>
    /// �ش� ����� ���� ��ȯ
    /// </summary>
    public INodeState Evaluate();
}