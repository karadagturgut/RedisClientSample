using System;

namespace RedisClientSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICache redisCache = new RedisCache();
            var user = new User
            {
                Email = "turgut@karadag.com",
                FirstName = "Turgut",
                LastName = "Karadağ",
                Id = 1
            };
            var key = "user_key";
            redisCache.Set(key, user, DateTime.Now.AddMinutes(30));
            if (redisCache.Exists(key))
            {
                var userRedisResponse = redisCache.Get<User>(key);
            }
        }
    }
}
