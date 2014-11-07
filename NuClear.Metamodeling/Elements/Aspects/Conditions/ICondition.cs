namespace NuClear.Metamodeling.Elements.Aspects.Conditions
{
    public interface ICondition
    {
        bool EvaluateCondition(object document);
    }
}
