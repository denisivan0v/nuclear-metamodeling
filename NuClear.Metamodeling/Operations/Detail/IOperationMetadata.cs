using NuClear.Model.Common.Operations.Identity;

namespace NuClear.Metamodeling.Operations.Detail
{
    /// <summary>
    /// ��������� ��������� ��� ���������� �������� (�����)
    /// </summary>
    public interface IOperationMetadata
    {
    }

    /// <summary>
    /// ��������� ��������� ��� ���������� �����-�� ���������� ��������
    /// </summary>
    public interface IOperationMetadata<TOperationIdentity> : IOperationMetadata
        where TOperationIdentity : IOperationIdentity
    {
    }
}