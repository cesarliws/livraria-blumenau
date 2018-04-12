namespace LivrariaBlumenau.Repository
{
    public interface ISecurityKeyRepository
    {
        bool IsValidKey(string key);
    }
}
