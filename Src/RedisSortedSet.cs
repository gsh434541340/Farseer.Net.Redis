using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Redis.Internal;

namespace FS.Redis
{
    public class RedisSortedSet
    {
        /// <summary>
        /// Redis客户端
        /// </summary>
        private readonly RedisClient _redisClient;
        private RedisSortedSet() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="redisClient">Redis客户端</param>
        internal RedisSortedSet(RedisClient redisClient)
        {
            _redisClient = redisClient;
        }
    }
}
