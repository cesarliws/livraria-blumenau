using System.Collections.Generic;

namespace LivrariaBlumenau.Repository
{
    public class SecurityKeyRepository : ISecurityKeyRepository
    {
        public bool IsValidKey(string key)
        {
            var keyItems = new List<string>
            {
                "2ad8ef5ed5d742489971c204cea896d1",
                "8f2adb44f888416bbc11e7daccc55e5b",
                "dc5a6591cefb4652b6cc8f64b2b5ea1c"
            };

            return (keyItems.Contains(key));
        }
    }
}
