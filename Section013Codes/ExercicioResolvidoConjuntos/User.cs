using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section013Codes.ExercicioResolvidoConjuntos
{
    public class User(string username, DateTime instant)
    {
        public string Username { get; set; } = username;
        public DateTime Instant { get; set; } = instant;

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is not User)
            {
                return false;
            }

            User other = obj as User;

            return Username.Equals(other.Username);
        }
    }
}